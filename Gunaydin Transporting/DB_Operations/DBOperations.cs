using GunaydinTransporting.web.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunaydinTransporting.web.DB_Operations
{
    public class DBOperations
    {
        public static void InsertData(string name, string e_mail, string password, float cost, string phoneNumber, DateTime timeOfEnter, DateTime timeOfQuit)
        {
            using (var myDB = new LiteDatabase("@GunaydinDBFile.db"))
            {
                var customers = myDB.GetCollection<Customers>("head");
                var customer = new Customers
                {
                    Name = name,
                    E_mail = e_mail,
                    Password = password,
                    Cost = cost,
                    PhoneNumber = phoneNumber,
                    TimeOfEnter = timeOfEnter,
                    TimeOfQuit = timeOfQuit

                };
                customers.Insert(customer);

            }

        }
        public static void GetAllDatas()
        {
            using (var myDB = new LiteDatabase("@GunaydinDBFile.db"))
            {
                var dbList = myDB.GetCollection<Customers>("head");
                var frList = dbList.FindAll();

                foreach (var item in frList)
                {
                    Console.WriteLine("ID:" + item.Id);
                    Console.WriteLine("Name:" + item.Name.ToString());
                    Console.WriteLine("Surname:" + item.E_mail.ToString());

                }
            }
        }
        public static void UpdateData(int id, string name, string e_Mail, string password, float cost, string phoneNumber, DateTime timeOfEnter, DateTime timeOfQuit)
        {
            using (var myDB = new LiteDatabase("@GunaydinDBFile.db"))
            {
                var customers = myDB.GetCollection<Customers>("head");
                var customer = new Customers();
                customer.Id = id;
                customer.Name = name;
                customer.E_mail = e_Mail;
                customer.Password = password;
                customer.Cost = cost;
                customer.PhoneNumber = phoneNumber;
                customer.TimeOfEnter = timeOfEnter;
                customer.TimeOfQuit = timeOfQuit;

                customers.Update(customer);

            }

        }
        public static void DeleteData(int id)
        {
            using (var myDB = new LiteDatabase("@GunaydinDBFile.db"))
            {
                var customers = myDB.GetCollection<Customers>("head");
                customers.Delete(x => x.Id == id);

            }
        }
        public static string FindDataById(int id)
        {
            string NameOfPerson = String.Empty;

            using (var myDB = new LiteDatabase("@GunaydinDBFile.db"))
            {
                var customers = myDB.GetCollection<Customers>("head");
                var FindResult = customers.Find(x => x.Id == id);

                // return FindResult;

                foreach (var item in FindResult)
                {
                    NameOfPerson = item.Name.ToString();
                }
            }

            return "The Person is : " + NameOfPerson;


        }


        public static string FindDataByName(string name)
        {
            string NameOfPerson = String.Empty;

            using (var myDB = new LiteDatabase("@GunaydinDBFile.db"))
            {
                var customers = myDB.GetCollection<Customers>("head");
                var FindResult = customers.Find(x => x.Name == name);

                // return FindResult;

                foreach (var item in FindResult)
                {
                    NameOfPerson = item.Name.ToString();
                }
            }

            return "The Person is : " + NameOfPerson;


        }
    }
}
