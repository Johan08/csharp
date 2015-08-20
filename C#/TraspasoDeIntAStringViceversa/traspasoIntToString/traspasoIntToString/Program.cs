using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace traspasoIntToString
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero = 4 ;

            //Lectura entrada estandar 
            // Console.readLine()

            string convertido = Convert.ToString(numero) ;


            switch (numero)
            {

                case 1:

                    Console.WriteLine("Uno");

                break;


                case 2:

                Console.WriteLine("Dos");

                break;


                default :

                Console.WriteLine("No se encuentra");

                break;

            }

            Console.ReadKey();

        }
    }
}
