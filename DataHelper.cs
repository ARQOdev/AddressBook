using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal static class DataHelper
    {
        public static string ConnectionString { get; set; }
        
        public static void ExecuteQuery(string query, Dictionary<string, object> pars)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataHelper.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SQLiteCommand command = connection.CreateCommand();
                    command.CommandText = query;
                    foreach(KeyValuePair<string, object> pair in pars)
                    {
                        command.Parameters.AddWithValue(pair.Key, pair.Value);
                    }
                    int rows_affected = command.ExecuteNonQuery();
                    connection.Close();
                }
                catch(Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }
        }

    }
}
