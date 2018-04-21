using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_02
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            int a = 100;
            long b = 12345678901L; //L을 붙어야 long이 된다 안붙이면 int 됨
            Console.WriteLine("{0}", a);
            Console.WriteLine("{0:D8}", a); //D자릿수, 0으로 채운다
            Console.WriteLine("{0}", b);

            //Console.WriteLine("{0}", 1234567 * 1234567);// ctr+k+c =//
            Console.WriteLine("{0}", 1234567L * 1234567L);//ctr+k+u = 주석 없앰

            Console.WriteLine("----------------------------");
            float c = 1.23456789f;
            double d = 1.2345674890123;

            Console.WriteLine("{0}", c); //반올림을 해서 결과값을 보여준다
            Console.WriteLine("{0:F5}", c);
            Console.WriteLine("{0}", d); //반올림 하지 않음

            Console.WriteLine("----------------------------");

            char e = 'ㄱ';
            string f = "abcdefghijklmnopqrstuvwxyz";
            String g = "가나다라마바사";
            Console.WriteLine("char : {0}", e);
            Console.WriteLine("string : {0}", f);
            Console.WriteLine("string : {0}", g);
            Console.WriteLine("----------------------------");

            string h = "\nUnicode Test\n";
            string i = "\u2605\u2606";

            Console.WriteLine("{0}", h);
            Console.WriteLine("\t conde : {0}", i);


            //10+7
            CMyClass.Add(10 ,7);
            CMyClass CM = new CMyClass();
            CM.Multiply(10, 7);

            int banti = 22338285;
            double banti2 = 2233.8286;

            Console.WriteLine("{0:n}", banti);
            Console.WriteLine("double = {0:f3}", banti2);
            int hayoung = 17;
            Console.WriteLine("double = 0x{0:x}",hayoung);

        }
    }
}
