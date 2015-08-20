using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 ;

            string fNum ;

            num1 = 2500;

            //CONVERT TO CURRENCY 
            fNum = num1.ToString("C") ;
            Console.WriteLine(fNum) ;




            num1 = 2500;

            //CONVERT TO a Number 
            fNum = num1.ToString("N");
            Console.WriteLine(fNum);

            num1 = 2500;

            //CONVERT TO a porcentaje 
            double num2 ;
            num2 = 0.5 ;
            fNum = num2.ToString("P");
            Console.WriteLine(fNum);




            Console.ReadKey();
        }
    }
}
