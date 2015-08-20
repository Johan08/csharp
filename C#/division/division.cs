using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace division
{
    class Program
    {
        static double resultado = 0;
        static int num1;
        static int num2;
        static int n;


        static void Main(string[] args)
        {
            do
            {



                try
                {
                    Console.WriteLine("ingrese su primer numero: ");
                    string s1 = Console.ReadLine();
                    num1 = Convert.ToInt32(s1);


                    Console.WriteLine("Ingrese su segundo numero: ");
                    string s2 = Console.ReadLine();
                    num2 = Convert.ToInt32(s2);

                    resultado = num1 / num2;

                    Console.WriteLine("El resultado de su división es: " + resultado);

                }
                catch (DivideByZeroException )
                {
                    Console.WriteLine("no debe dividir entre 0 ");

                }


                Console.WriteLine("Ingrese 5 si quiere salir ");
                //string s3 = Console.ReadLine();

                n = Int32.Parse(Console.ReadLine());

                //n = Convert.ToInt32(s3);



            } while (n != 5);


            Console.ReadKey();
        }//fin main
    }
}
