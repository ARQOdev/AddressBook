using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class ModelBase
    {
        public ModelBase()
        {
            UID = 0;
        }

        public ulong UID { get; set; }

        public static List<ModelBase> GetCityList(SQLiteDataReader reader)
        {
            List<ModelBase> list = new List<ModelBase>();
            while (reader.Read())
            {
                City city = new City();
                city.UID = Convert.ToUInt64(reader["UID"]);
                city.CityName = reader["CITY"].ToString()!;
                list.Add(city);
            }
            return list;
        }

    }
}
