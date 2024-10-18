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

        public static List<ModelBase> GetPhoneList(SQLiteDataReader reader)
        {
            List<ModelBase> list = new List<ModelBase>();
            while (reader.Read())
            {
                Phone phone = new Phone();
                phone.UID = Convert.ToUInt64(reader["UID"]);
                phone.PersonUID = Convert.ToUInt64(reader["PERSON_UID"]);
                phone.Number = reader["PHONE_NUMBER"].ToString()!;
                list.Add(phone);
            }
            return list;
        }

        public static List<ModelBase> GetEmailList(SQLiteDataReader reader)
        {
            List<ModelBase> list = new List<ModelBase>();
            while (reader.Read())
            {
                Mail mail = new Mail();
                mail.UID = Convert.ToUInt64(reader["UID"]);
                mail.PersonUID = Convert.ToUInt64(reader["PERSON_UID"]);
                mail.Email = reader["EMAIL"].ToString()!;
                list.Add(mail);
            }
            return list;
        }

        public static List<ModelBase> GetAddressList(SQLiteDataReader reader)
        {
            List<ModelBase> list = new List<ModelBase>();
            while (reader.Read())
            {
                Address address = new Address();
                address.UID = Convert.ToUInt64(reader["UID"]);
                address.CityUID = Convert.ToUInt64(reader["CITY_UID"]);
                address.CityName = reader["CITY_NAME"].ToString()!;
                address.AddressName = reader["ADDRESS"].ToString()!;
            }
            return list;
        }

        public static List<ModelBase> GetContactList(SQLiteDataReader reader)
        {
            List<ModelBase> list = new List<ModelBase>();
            while (reader.Read())
            {
                Contact contact = new Contact();
                contact.UID = Convert.ToUInt64(reader["UID"]);
                contact.FirstName = reader["FIRST_NAME"].ToString()!;
                contact.LastName = reader["LAST_NAME"].ToString()!;
                contact.Address = reader["ADDRESS"].ToString()!;
                contact.City = reader["CITY"].ToString()!;
                contact.PhoneNumber = reader["PHONE"].ToString()!;
                contact.Mail = reader["MAIL"].ToString()!;
                contact.Description = reader["DESCRIPTION"].ToString()!;
                contact.CityUID = Convert.ToUInt64(reader["CITY_UID"]);

                list.Add(contact);
            }
            return list;
        }
    }
}
