using p_ch_m_i.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using System.ComponentModel.DataAnnotations;


namespace p_ch_m_i.Controllers
{
    public class Repository : IRepository
    {
        protected string connectionString;
        public Repository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddOform(PurchaseModel model)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"INSERT INTO Purchases('purchase_date', 'product_id'," +
                        "'quantity', 'total_price', 'provider_id') values (" +
                        "@purchase_date, @product_id, @quantity, @total_price, @provider_id)";
                    command.Parameters.Add("@purchase_date", System.Data.DbType.String).Value = model.Purchase_date;
                    command.Parameters.Add("@product_id", System.Data.DbType.Int32).Value = model.Product_id;
                    command.Parameters.Add("@quantity", System.Data.DbType.String).Value = model.Quantity;
                    command.Parameters.Add("@total_price", System.Data.DbType.String).Value = model.Total_price;
                    command.Parameters.Add("@provider_id", System.Data.DbType.String).Value = model.Provider_id;
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteProduct(int id)
        {
            string query = $"DELETE FROM Products WHERE product_id=" + id;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteProvider(int id)
        {
            string query = $"DELETE FROM Providers WHERE provider_id=" + id;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public IEnumerable<OrderModel> GetAllOrders()
        {
            var orderList = new List<OrderModel>();
            string query = $"SELECT * FROM Orders ORDER BY order_id ASC";
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var orderModel = new OrderModel();
                        orderModel.Order_id = Convert.ToInt32(reader[0]);
                        orderModel.Order_data = reader[1].ToString();
                        orderModel.Order_time = reader[2].ToString();
                        orderModel.Product_id = Convert.ToInt32(reader[3]);
                        orderModel.Quantity = reader[4].ToString();
                        orderModel.Client_fio = reader[5].ToString();
                        orderModel.Client_phone_num = reader[6].ToString();
                        orderModel.Client_email = reader[7].ToString();
                        orderModel.Status = reader[8].ToString();
                        orderModel.Sent = reader[9].ToString();
                        orderList.Add(orderModel);
                    }
                }
                return orderList;
            }
        }

        public IEnumerable<ProductModel> GetAllProducts()
        {
            var productList = new List<ProductModel>();
            string query = $"SELECT * FROM Products ORDER BY product_id ASC";
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.Product_id = Convert.ToInt32(reader[0]);
                        productModel.Product_name = reader[1].ToString();
                        productModel.Product_size = reader[2].ToString();
                        productModel.Price = reader[3].ToString();
                        productModel.In_stock = reader[4].ToString();
                        productModel.Quantity = reader[5].ToString();
                        productModel.Category = reader[6].ToString();
                        productModel.Provider_id = Convert.ToInt32(reader[7]);
                        productList.Add(productModel);
                    }
                }
                return productList;
            }
        }
        public IEnumerable<ProviderModel> GetAllProviders()
        {
            var providerList = new List<ProviderModel>();
            string query = $"SELECT * FROM Providers ORDER BY provider_id ASC";
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providerModel = new ProviderModel();
                        providerModel.Provider_id = Convert.ToInt32(reader[0]);
                        providerModel.Provider_name = reader[1].ToString();
                        providerModel.Provider_phone_num = reader[2].ToString();
                        providerModel.Provider_email = reader[3].ToString();
                        providerList.Add(providerModel);
                    }
                }
                return providerList;
            }
        }

        public IEnumerable<PurchaseModel> GetAllPurchases()
        {
            var purchaseList = new List<PurchaseModel>();
            string query = $"SELECT * FROM Purchases ORDER BY purchase_id ASC";
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var purchaseModel = new PurchaseModel();
                        purchaseModel.Purchase_id = Convert.ToInt32(reader[0]);
                        purchaseModel.Purchase_date = reader[1].ToString();
                        purchaseModel.Product_id = Convert.ToInt32(reader[2]);
                        purchaseModel.Quantity = reader[3].ToString();
                        purchaseModel.Total_price = reader[4].ToString();
                        purchaseModel.Provider_id = Convert.ToInt32(reader[5]);
                        purchaseList.Add(purchaseModel);
                    }
                }
                return purchaseList;
            }
        }

        public IEnumerable<SendingModel> GetAllSendings()
        {
            var sendingList = new List<SendingModel>();
            string query = $"SELECT * FROM Sendings ORDER BY sending_id ASC";
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var sendingModel = new SendingModel();
                        sendingModel.Sending_id = Convert.ToInt32(reader[0]);
                        sendingModel.Product_id = Convert.ToInt32(reader[1]);
                        sendingModel.Quantity = reader[2].ToString();
                        sendingModel.Total_price = reader[3].ToString();
                        sendingModel.Delivery_status = reader[4].ToString();
                        sendingList.Add(sendingModel);
                    }
                }
                return sendingList;
            }
        }

        public IEnumerable<SuppliesModel> GetAllSupplies()
        {
            var suppliesList = new List<SuppliesModel>();
            string query = $"SELECT * FROM Supplies ORDER BY supply_id ASC";
            using (var connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var supplyModel = new SuppliesModel();
                        supplyModel.Supply_id = Convert.ToInt32(reader[0]);
                        supplyModel.Supply_date = reader[1].ToString();
                        supplyModel.Supply_time = reader[2].ToString();
                        supplyModel.Product_id = Convert.ToInt32(reader[3]);
                        supplyModel.Quantity = reader[4].ToString();
                        supplyModel.Provider_id = Convert.ToInt32(reader[5]);
                        suppliesList.Add(supplyModel);
                    }
                }
                return suppliesList;
            }
        }
    }
}
