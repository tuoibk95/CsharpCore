using System;
using System.Data;
using System.Data.SqlClient;

namespace Microsoft.AdoNet.DataSetDemo
{
    class NorthwindDataSet
    {
        static void Main()
        {
            string connectionString = GetConnectionString();
            ConnectToData(connectionString);
        }

        private static void ConnectToData(string connectionString)
        {
            //Create a SqlConnection to the Northwind database.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection.
                connection.Open();
                Console.WriteLine("The SqlConnection is open.");

                // Create a second Adapter and Command to get
                // the Products table, a child table of Suppliers.
                SqlDataAdapter productsAdapter = new SqlDataAdapter();
                productsAdapter.TableMappings.Add("Table", "tbl_user");

                // Fill the DataSet.
                DataSet dataSet = new DataSet("tbl_user");
                DataTable dt = new DataTable("tbl_user");

                SqlCommand productsCommand = new SqlCommand("SELECT * FROM tbl_user;",connection);
                productsAdapter.SelectCommand = productsCommand;

                // Fill the DataSet.
                productsAdapter.Fill(dataSet);

                // For each table in the DataSet, print the row values.
                foreach (DataTable table in dataSet.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        foreach (DataColumn column in table.Columns)
                        {
							Console.Write(column.ColumnName.ToString() + ": ");
                            Console.WriteLine(row[column]);
                        }
						Console.WriteLine("++++++++++++++++++++++++++++++++++");
                    }
                }

                // Close the connection.
                connection.Close();
                Console.WriteLine("The SqlConnection is closed.");
            }
        }

        static private string GetConnectionString()
        {
            // To avoid storing the connection string in your code,
            // you can retrieve it from a configuration file.
            return "data source=TuoiLV;initial catalog=manageuser_01_lucvantien;persist security info=True;user id=sa;password=LVTdeveloper1;MultipleActiveResultSets=True;App=EntityFramework"
                + "Integrated Security=SSPI";
        }
    }
}