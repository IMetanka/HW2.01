using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Грушина Татьяна Александровна";
            byte years = 30;
            string email = "tanya@mail.ru";
            double Programming = 97.1;
            double Maths = 94.3;
            double Physics = 91.5;


            string newPattern = "ФИО: {0} \nВозраст: {1} \nEmail: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}";

Console.WriteLine(newPattern,
        fullName,
        years,
        email,
        Programming,
        Maths,
        Physics);

            Console.ReadKey();
            
        }
    }
}
