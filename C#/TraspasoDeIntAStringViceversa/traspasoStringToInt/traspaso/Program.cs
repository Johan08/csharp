using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace traspaso
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("CONVERSION DE STRING A ENTERO") ;

            string numeroCadena = "698" ;

            int numeroEntero = Convert.ToInt32(numeroCadena) ;

            Console.WriteLine(numeroEntero) ;

            Console.ReadLine() ;

            


            Console.ReadKey();

            }
        }
    }

