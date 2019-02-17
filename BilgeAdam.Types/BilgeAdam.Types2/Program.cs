using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Types2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 8;
            var b = a;
            a = 7;

            var c = 3.4;
            var d = c;
            c++;

            Console.WriteLine("A: " + a);
            Console.WriteLine("B: " + b);

            Console.WriteLine("-----------------");
            var numbers = new int[] { 2, 5, 12, 6, 7 };
            var others = numbers;
            numbers[2] = 0;
            others[4] = 21;

            Console.Write("numbers...: ");
            foreach (var item in numbers)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            Console.Write("others....: ");
            foreach (var item in others)
            {
                Console.Write("{0} ", item);
            }

            var p1 = new Kisi
            {
                name = "Can PERK",
                birthDate = new DateTime(1988, 2, 8),
                height = 183,
                city = "Kars",
                status = MaritialStatus.Married
            };

            var p2 = p1;
            p2.height = 173;
            p2.name = "Deniz ASLAN";
            p2.city = "Ankara";
            p2.status = MaritialStatus.Single;
            p2.birthDate = p2.birthDate.AddYears(8).AddMonths(4);

            var deger = "sdfsdfsjkdsdkjfhsdjkf";
            deger.Replace("s", "a");


            var text = "hamdım yandım piştim";//immutable
            text = text.ToUpper().Replace("M", "N");
            //text = "Gittim gördüm gezdim";
            Console.ReadKey();
        }
    }

    struct Kisi
    {
        public string name;
        public DateTime birthDate;
        public string city;
        public int height;
        public MaritialStatus status;
    }

    enum MaritialStatus
    {
        Married = 0,
        Single = 1
    }
}

/*
 
 Reference Type : class
 Value Type     : struct
     
     */
