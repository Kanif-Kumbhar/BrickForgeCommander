using BrickForgeCommanderUI.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;

namespace BrickForgeCommanderUI.Dashboard.Models
{
    public struct RevenueByDate
    {
        public string Date {  get; set; }
        public decimal TotalAmount {  get; set; }
    }

    public class DashBoard : DbConnection
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumCustomers {  get;private set; }
        public int NumSuppliers {  get;private set; }
        public int NumProducts {  get;private set; }
        public List<KeyValuePair<string,int>> TopProductsList { get; private set; }   
        public List<KeyValuePair<string,int>> UnderStockList { get; private set; }   
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; set;}
        public decimal TotalRevenue {  get; set; }
        public decimal TotalProfit {  get; set; }

        public DashBoard() 
        {

        }

        private void GetNumberItems()
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using (var command =new SqlCommand())
                {
                    command.Connection = connection;

                    //Get total number of Customer
                    command.CommandText = "SELECT COUNT(VendorId) FROM BFC.VendorDetails WHERE VendorTypeId=3";
                    NumCustomers = (int)command.ExecuteScalar();
                    
                    //Get total number of Supplier
                    command.CommandText = "SELECT COUNT(VendorId) FROM BFC.VendorDetails WHERE VendorTypeId=4";
                    NumSuppliers = (int)command.ExecuteScalar();

                    //Get total number of Products
                    command.CommandText = "SELECT COUNT(ProductId) FROM BFC.ProductDetails";
                    NumProducts = (int)command.ExecuteScalar();

                    //Get total number of Orders
                    command.CommandText = "SELECT COUNT(OrderId) FROM BFC.Orders WHERE OrderDate BETWEEN @StartDate AND @EndDate";
                    command.Parameters.Add("@StartDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@EndDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    NumOrders = (int)command.ExecuteScalar();
                }
            }
        }

        private void GetOrderAnalysis()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;

            using(var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT OrderDate, SUM(TotalAmount) from BFC.Orders
                                          WHERE OrderDate BETWEEN @StartDate AND @EndDate GROUP BY OrderDate";
                    command.Parameters.Add("@StartDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@EndDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read()) 
                    {
                        resultTable.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1]));
                        TotalRevenue += (decimal)reader[1];
                    }
                    TotalProfit = TotalRevenue * 0.2m; //Purchase price
                    reader.Close();
                    //Group by Hours
                    if (numberDays <= 1)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("hh tt")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(Amount => Amount.Value)
                                            }).ToList();
                    }

                    //Group by Days
                    else if (numberDays <= 30)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("dd MMM")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(Amount => Amount.Value)
                                            }).ToList();
                    }

                    //Group by Weeks
                    else if(numberDays <= 92)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week " + order.Key.ToString(),
                                                TotalAmount = order.Sum(Amount => Amount.Value)
                                            }).ToList();
                    }

                    //Group ny Months
                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MMM yyyy")
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear ? order.Key.Substring(0,order.Key.IndexOf(" ")) : order.Key,
                                                TotalAmount = order.Sum(Amount => Amount.Value)
                                            }).ToList();
                    }

                    //Group By Year
                    else
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("yyyy")
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(Amount => Amount.Value)
                                            }).ToList();
                    }
                }
            }
        }

        private void GetProductAnalysis()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();
            UnderStockList = new List<KeyValuePair<string, int>>();
            using( var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;

                    //Get top 5 Products
                    command.CommandText = @"select top 5 P.ProductName, sum(BFC.OrderDetails.Quantity) as Q
                                            from BFC.OrderDetails
                                            inner join BFC.ProductDetails P on P.ProductId = BFC.OrderDetails.ProductId
                                            inner
                                            join BFC.Orders O on O.OrderId = BFC.OrderDetails.OrderId
                                            where OrderDate between @StartDate and @EndDate
                                            group by P.ProductName
                                            order by Q desc";
                    command.Parameters.Add("@StartDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@EndDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        TopProductsList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                    //Get Under Stock Product
                    command.CommandText = @"SELECT ProductName, Stock FROM BFC.ProductDetails 
                                            WHERE Stock <= 100 AND isDiscontinued = 0";
                    reader = command.ExecuteReader();
                    while(reader.Read()) 
                    {
                        UnderStockList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }
            }
        }

        //Public Methods

        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,endDate.Hour,endDate.Minute,59); 
            if(startDate != this.startDate || endDate != this.endDate) 
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetNumberItems();
                GetProductAnalysis();
                GetOrderAnalysis();
                Console.WriteLine("Refereshed Data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true; 
            }
            else
            {
                Console.WriteLine("Data not refereshed, same query: {0} - {1}",startDate.ToString(),endDate.ToString());
                return false;
            }
        }
    }
}
