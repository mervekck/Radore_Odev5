using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_5
{
    public class ORM
    {
        public void Orm()
        {
            string connectionString = @"Data Source=LAPTOP-P1TC8HDR\MSSQL;Initial Catalog=RadoreDB;uid=sa;Password=123;";
            string columnName = "CLASS_NAME";

            string tableName = "OdemeTipleri";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = $"SELECT {columnName} FROM {tableName}";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {

                            string x = reader.GetString(0);
                            string fileName = x + ".cs";
                            string filePath = $"C:/Users/merve/Desktop/RadoreBootcamp/Odev_5/Odev_5/{fileName}";

                            using (StreamWriter writer = new StreamWriter(filePath))
                            {
                                writer.WriteLine("using System;");
                                writer.WriteLine("using System.Collections.Generic;");
                                writer.WriteLine("using System.ComponentModel.DataAnnotations;");
                                writer.WriteLine("using System.Linq;");
                                writer.WriteLine("using System.Text;");
                                writer.WriteLine("using System.Threading.Tasks;");
                                writer.WriteLine("namespace Odev_5");
                                writer.WriteLine("{");
                                writer.WriteLine($"public class {x} : IOdemeTipi");
                                writer.WriteLine("{");
                                writer.WriteLine("public string ode(double tutar)");
                                writer.WriteLine("{");
                                writer.WriteLine($"return tutar + \" {x} ile ödendi\";");
                                writer.WriteLine("}");
                                writer.WriteLine("}");
                                writer.WriteLine("}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close(); 
                }
            }
        }
    }
}
