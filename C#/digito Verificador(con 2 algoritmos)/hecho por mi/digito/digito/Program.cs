using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace digito
{
    class Program
    {
         static int Digito;
        static int Contador;
        static int Multiplo;
        static int Acumulador;
        static string RutDigito;
       
        

        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el Numero: ");
            string s = Console.ReadLine();

            digitoVerificador(s);

        }

        static string digitoVerificador(string rut)
        {

            int ruti = Convert.ToInt32(s);

            Contador = 2;
            Acumulador = 0;

            while (ruti != 0)
            {
                Multiplo = (ruti % 10) * Contador;
                Acumulador = Acumulador + Multiplo;
                ruti = ruti / 10;
                Contador = Contador + 1;
                if (Contador == 8)
                {
                    Contador = 2;
                }

            }

            Digito = 11 - (Acumulador % 11);
            RutDigito = Digito.ToString().Trim();
            if (Digito == 10)
            {
                //RutDigito = "K";
                Console.WriteLine(" RutDigito = K");
            }
            if (Digito == 11)
            {

                Console.WriteLine(" RutDigito = 0");
            }
            return (RutDigito);
        }
        }
    }

