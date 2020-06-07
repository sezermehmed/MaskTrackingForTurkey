using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Citizen vatandas1 = new Citizen();

            SayHello(" Sezer");
           // SayHello(" Ahmet");
           // SayHello(" Ayse");
           // SayHello();

           // int result = Sum(3, 5);

            // Arrays
         /*   string student1 = "Engin";
            string student2 = "Kerem";
            string student3 = "Berkay";

            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Kerem";
            students[2] = "Berkay";

            students = new string[4];
            students[3] = "ilker";
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            string[] cities1 = new[] { "Ankara", "Istanbul", "Izmir" };
            string[] cities2 = new[] { "Bursa", "Antalya", "Diyarbakir" };

            cities2 = cities1;
            cities1[0] = "Adana";
            Console.WriteLine(cities2[0]);
         */
            Person person1 = new Person();
            _ = person1.Firstname;          // I dont know it is a good idea using _ for each, yet. It just works.
            _ = person1.Lastname;
            _ = person1.DateOfBirthYear;
            _ = person1.NationalIdentitiy;
            Console.Write("Your name:  ");
            person1.Firstname = Console.ReadLine();
            Console.Write("Your lastname:  ");
            person1.Lastname = Console.ReadLine();
            Console.Write("Your Birth year:  ");
            person1.DateOfBirthYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your ID:  ");
            person1.NationalIdentitiy = Convert.ToInt64(Console.ReadLine());

            /*

                        Person person2 = new Person();
                        person2.Firstname = "Murat";

                        foreach (string city in cities1)
                        {
                            Console.WriteLine(city);
                        }

                        //Mylist
                        List<string> newCities1 = new List<string> { "Ankara 1", "Istanbul 1 ", "Izmir 1" };

                        newCities1.Add("Adana 1");

                        foreach(var city in newCities1)
                        {
                            Console.WriteLine(city);
                     }
                     */
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

           // Console.ReadLine();
        }

      
       static void SayHello(string name = " isimsiz")
        {
             Console.WriteLine("Hello" + name );
      } 
      /*
        static int Sum(int num1 = 5, int num2 = 10)
        {
        int result = num1 + num2;
        Console.WriteLine("Sum: " + result.ToString());
        return result;
        }
        private static void Variables()
        {
            string massage = "merhaba";
            double amount = 10000;              
            int number = 100;
            bool islogIn = false;
            
            string name = "Engin";
            string surname = "Demirog";
            int birthDate = 1985;
            long identity = 12345678910;
        }
        public class Citizen
        {
            string name = "Engin";
            string surname = "Demirog";
            int birthDate = 1985;
            long identity = 12345678910;
        }
      */
    }
   
 
}
