﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen
{
    public struct RevenueByDate
    {
        public string Date { get;  set; }
        public decimal TotalAmount { get;  set; }
    }
    public class Dashboard:DbConnection
    {
        private DateTime start_date;
        private DateTime end_date;
        private int numberDays;

        public int NumSales { get; private set; }
        public int NumStudent { get; private set; }
        public int Numproducts { get; private set; }

        public List<KeyValuePair<string,int>> TopProductsList { get; private set; }
        public List<KeyValuePair<string, int>> UnderStockList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal Totalprofit { get; set; }

        public Dashboard()
        {

        }
        //private methods
        private void GetNumberItems()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command=new SqlCommand())
                {
                    command.Connection = connection;
                    //get total number of Products
                    command.CommandText = "select count(Pro_ID) from Product";
                    Numproducts = (int)command.ExecuteScalar();

                    //get total number of students
                    command.CommandText = "select count(Student_ID) from Student";
                    NumStudent = (int)command.ExecuteScalar();

                    //get total number of Orders
                    command.CommandText = @"select count(invoice_ID) from [Invoice] " +
                        "where invoice_Date between  @fromDate and  @toDate";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = start_date;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = end_date;
                    NumOrders = (int)command.ExecuteScalar();
                }
              


            }

        }

        private void GetOrderAnalysis()
        {
            GrossRevenueList = new List<RevenueByDate>();
            Totalprofit = 0;
            TotalRevenue = 0;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select invoice_Date, sum(total)
                        from [Invoice] where invoice_Date between  @fromDate
                        and  @toDate group by invoice_Date";

                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = start_date;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = end_date;
                    var reader = command.ExecuteReader();
                    var resultTabel = new List<KeyValuePair<DateTime, decimal>>();
                    while(reader.Read())
                    {
                        resultTabel.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0],(decimal)reader[1]));
                        TotalRevenue += (decimal)reader[1];
                    }
                    Totalprofit = TotalRevenue * 0.2m; //20%
                    reader.Close();

                    //Group by days
                    if(numberDays<=30)
                    {
                        foreach (var item in resultTabel)
                        {
                            GrossRevenueList.Add(new RevenueByDate()
                            {
                                Date = item.Key.ToString("dd MM"),
                                TotalAmount=item.Value
                            }); 
                        }
                    }

                    //Group by weeks
                    else if (numberDays<=92)
                    {
                        GrossRevenueList = (from orderList in resultTabel
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                             into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week " + order.Key.ToString(),
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }
                                          ).ToList();
                    }
                    //Group by months

                    else if (numberDays <= 365*2)
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderList in resultTabel
                                            group orderList by orderList.Key.ToString("MM yyyy")
                                             into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear?  order.Key.Substring(0, order.Key.IndexOf(" ")):order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }
                                          ).ToList();
                    }
                    //Group by years

                    else 
                    {
                        
                        GrossRevenueList = (from orderList in resultTabel
                                            group orderList by orderList.Key.ToString("yyyy")
                                             into order
                                            select new RevenueByDate
                                            {
                                                Date =  order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }
                                          ).ToList();
                    }


                }
            }
        }

        private void GetProductAnalysis()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();
            UnderStockList = new List<KeyValuePair<string, int>>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    //Get Top 5 products
                    command.CommandText = @"select top 5 p.Pro_Name,sum(Sales.Qty) as Q
                                          FROM [SmartDB].[dbo].[Sales] 
                              inner join [SmartDB].[dbo].[Product] p on p.Pro_ID= Sales.product_id 
                              inner join [SmartDB].[dbo].[Invoice] o on o.invoice_ID=Sales.invoice_id 
                              where invoice_Date between  @fromDate and  @toDate 
                              group by p.Pro_Name order by Q desc";

                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = start_date;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = end_date;
                    reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        TopProductsList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                    //Get underStock

                    command.CommandText = @"select Pro_Name,Quantity  from Product
                                                      where Quantity <=6";
                    reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        UnderStockList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }

            }
        }

        //public methods

        public bool loadData(DateTime startDate,DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour,
                endDate.Minute, 59);
            if (startDate != this.start_date || endDate != this.end_date)
            {
                this.start_date = startDate;
                this.end_date = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetNumberItems();
                GetProductAnalysis();
                GetOrderAnalysis();
                Console.WriteLine("Refreashed Data: {0} - {1}",startDate.ToString(),endDate.ToString());

                return true;
            }
            else
            {
                Console.WriteLine(" Data not Refreashed, same query : {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
    }
}
