using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Types
{
    class Program
    {

        public static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
        static void Main(string[] args)
        {
            var i = 300;
            var i1 = Convert.ToByte(i);

            var stream = new FileStream(@"C:\Code\kalp.png", FileMode.Open);
            var bytes = ReadFully(stream);

            var l = 3534553545L;
            var l1 = (int)l;
            var a = "9";
            var n = Convert.ToInt32(a);
            var m = int.Parse(a);
            

            var c = 9D;
            var c1 = Convert.ToInt32(c);
            var c2 = (int)c;//boxing

            var d = 9;
            var d1 = (double)d;//unboxing

            object t = "Can Perk - 08.02.1988";

            Person p = (Person)t;//çeviremezse exception fırlatır
            Person r = t as Person;//çeviremezse null değer üretir
            Console.WriteLine(p.name);
            var s = (Person)t;
            var u = t as Person;
        }
    }

    class Person
    {
        public string name;
        public string birthDate;
    }
}
