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
            SayHello(" Sezer");
         
            Person person1 = new Person();
            _ = person1.Firstname;   // I dont know it is a good idea using _ for each, yet. It just works.
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
           
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }

       static void SayHello(string name = " isimsiz")
        {
             Console.WriteLine("Hello" + name );
        } 

    }
 
}
