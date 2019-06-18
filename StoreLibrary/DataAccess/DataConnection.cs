using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using StoreLibrary.Models;
using System.Data.SqlClient;
using System.Data;

namespace StoreLibrary.DataAccess
{
    public class DataConnection
    {
        private static DataConnection instance;
        public static DataConnection Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DataConnection();
                }
                return instance;
            }
        }

        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Projects\c#\store_db.accdb";
        private OleDbConnection connection;

        private DataConnection()
        {
            connection = new OleDbConnection(connString);
        }

        private void OpenConnection()
        {
            if(connection != null)
            {
                connection.Open();
            }
        }

        private void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }

        public List<GroupModel> GetGroups()
        {
            List<GroupModel> groups = new List<GroupModel>();
            try
            {
                OpenConnection();

                OleDbCommand command = connection.CreateCommand();
                command.CommandText = @"SELECT * FROM [Group]";
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    GroupModel group = new GroupModel()
                    {
                        ID = int.Parse(reader["ID"].ToString()),
                        Name = reader["Group_name"].ToString()
                    };

                    groups.Add(group);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                CloseConnection();
            }
            return groups;
        }

        public List<ProductModel> GetProductsInGroup(int groupID)
        {
            List<ProductModel> products = new List<ProductModel>();
            try
            {
                OpenConnection();

                OleDbCommand command = connection.CreateCommand();
                command.CommandText = 
                    $"SELECT * " +
                    $"FROM [Product] " +
                    $"WHERE ID in " +
                    $"(SELECT Product_ID " +
                    $"FROM [PRODUCT_GROUP] " +
                    $"WHERE Group_ID = @groupID)";
                command.Parameters.AddWithValue("groupID", groupID);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ProductModel product = new ProductModel()
                    {
                        ID = int.Parse(reader["ID"].ToString()),
                        Name = reader["Product_name"].ToString(),
                        Price = double.Parse(reader["Price"].ToString()),
                        Discount = double.Parse(reader["Discount"].ToString())
                    };

                    products.Add(product);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                CloseConnection();
            }
            return products;
        }

        public ProductModel CreateProduct(ProductModel product, int groupID)
        {
            OleDbTransaction transaction = null;
            try
            {
                OpenConnection();
                transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                OleDbCommand command = connection.CreateCommand();
                command.Transaction = transaction;

                command.CommandText =
                    $"INSERT INTO PRODUCT(Product_name,Price,Discount) " +
                    $"VALUES (@name,@price,@discount)";
                command.Parameters.AddWithValue("name", product.Name);
                command.Parameters.AddWithValue("price", product.Price);
                command.Parameters.AddWithValue("discount", product.Discount);
                
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    command.CommandText = 
                        $"SELECT @@IDENTITY AS ID";
                    int productID = int.Parse(command.ExecuteScalar().ToString());

                    command.CommandText =
                        $"INSERT INTO PRODUCT_GROUP(Group_ID,Product_ID) " +
                        $"VALUES (@groupID, @productID)";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("groupID", groupID);
                    command.Parameters.AddWithValue("productID", productID);

                    int res = command.ExecuteNonQuery();
                    if (res > 0)
                    {
                        transaction.Commit();
                        product.ID = productID;
                    }
                    else
                    {
                        throw new Exception("Failed to asign group to product");
                    }
                }
                else
                {
                    throw new Exception("Failed to create product");
                }
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                product = null;
            }
            finally
            {
                CloseConnection();
            }
            return product;
        }

        public ProductModel UpdateProduct(ProductModel product)
        {
            try
            {
                OpenConnection();
                OleDbCommand command = connection.CreateCommand();

                command.CommandText =
                    $"UPDATE PRODUCT " +
                    $"SET Product_name = @name, " +
                    $"Price = @price, " +
                    $"Discount = @discount " +
                    $"WHERE id = @id";
                command.Parameters.AddWithValue("name", product.Name);
                command.Parameters.AddWithValue("price", product.Price);
                command.Parameters.AddWithValue("discount", product.Discount);
                command.Parameters.AddWithValue("id", product.ID);

                int result = command.ExecuteNonQuery();
                if (result < 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                product = null;
            }
            finally
            {
                CloseConnection();
            }
            return product;
        }

        public ProductModel DeleteProduct(int id)
        {
            ProductModel product = null;
            try
            {
                OpenConnection();
                OleDbCommand command = connection.CreateCommand();

                command.CommandText =
                    $"SELECT * " +
                    $"FROM PRODUCT " +
                    $"WHERE id = @id";

                command.Parameters.AddWithValue("id", id);

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    product = new ProductModel()
                    {
                        ID = int.Parse(reader["ID"].ToString()),
                        Name = reader["Product_name"].ToString(),
                        Price = double.Parse(reader["Price"].ToString()),
                        Discount = double.Parse(reader["Discount"].ToString())
                    };
                }
                reader.Close();

                command.CommandText =
                    $"DELETE " +
                    $"FROM PRODUCT " +
                    $"WHERE id = @id";


                int result = command.ExecuteNonQuery();
                if (result < 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                product = null;
            }
            finally
            {
                CloseConnection();
            }
            return product;
        }

        public ReceiptModel CreateReceipt(ReceiptModel receipt)
        {
            try
            {
                OpenConnection();
                OleDbCommand command = connection.CreateCommand();
                command.CommandText =
                    $"INSERT INTO RECEIPT(Price,Receipt_date,Receipt_Time) " +
                    $"VALUES (@price,@date,@time)";
                command.Parameters.AddWithValue("price", receipt.Price);
                command.Parameters.AddWithValue("date", receipt.Date);
                command.Parameters.AddWithValue("time", receipt.Time);
                int result = command.ExecuteNonQuery();
                if(result > 0)
                {
                    command.CommandText =
                           $"SELECT @@IDENTITY AS ID";
                    int receiptID = int.Parse(command.ExecuteScalar().ToString());
                    receipt.ID = receiptID;
                }
            }
            catch (Exception ex)
            {
                receipt = null;
            }
            finally
            {
                CloseConnection();
            }
            return receipt;
        }

        public List<ReceiptModel> GetReceipts(DateTime dateFrom, DateTime dateTo)
        {
            List<ReceiptModel> receipts = new List<ReceiptModel>();
            string format = "yyyy/MM/dd";
            try
            {
                OpenConnection();
                OleDbCommand command = connection.CreateCommand();
                command.CommandText =
                    $"SELECT * " +
                    $"FROM [Receipt] " +
                    $"WHERE Receipt_date BETWEEN " +
                    $"@from and @to";
                command.Parameters.AddWithValue("from", dateFrom.ToString(format));
                command.Parameters.AddWithValue("to", dateTo.ToString(format));

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DateTime date = DateTime.Parse(reader["Receipt_date"].ToString());
                    TimeSpan time = DateTime.Parse(reader["Receipt_time"].ToString()).TimeOfDay;
                    date = date.Add(time);
                    ReceiptModel receipt = new ReceiptModel()
                    {
                        ID = int.Parse(reader["ID"].ToString()),
                        Price = double.Parse(reader["Price"].ToString()),
                        FullTime = date
                    };

                    receipts.Add(receipt);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                CloseConnection();
            }
            return receipts;
        }
    }
}
