using AddressBook.Models;
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

        public delegate List<ModelBase> SelectDelegate(SQLiteDataReader reader);

        public static void ExecuteQuery(string query, Dictionary<string, object>? pars = null)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DataHelper.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = connection.CreateCommand())
                    {
                        command.CommandText = query;
                        if (pars != null)
                        {
                            foreach (KeyValuePair<string, object> pair in pars)
                            {
                                command.Parameters.AddWithValue(pair.Key, pair.Value);
                            }
                        }
                        int rows_affected = command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                catch(Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }
        }

        public static List<ModelBase> ExecuteSelect(SelectDelegate func, string query, Dictionary<string, object>? pars = null)
        {
            List<ModelBase> list = null;
            using (SQLiteConnection connection = new SQLiteConnection(DataHelper.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = connection.CreateCommand())
                    {
                        command.CommandText = query;
                        if (pars != null)
                        {
                            foreach (KeyValuePair<string, object> pair in pars)
                            {
                                command.Parameters.AddWithValue(pair.Key, pair.Value);
                            }
                        }
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            /*while (reader.Read())
                            {
                                System.Diagnostics.Debug.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
                            }*/

                            if (func != null)
                                list = func(reader);
                        }
                    }
                    connection.Close();
                }
                catch(Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }
            return list;
        }

    }
}
