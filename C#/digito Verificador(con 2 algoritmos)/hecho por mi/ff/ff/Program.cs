using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ff
{
    class Program
    {
       static int Digito;
      //static int Contador;
      static int Multiplo;
      
      //static int Acumulador;
       static string RutDigito;
 
      

        static void Main(string[] args)
        {
            Console.WriteLine("INGRESE SU RUT: ");
            Console.WriteLine();
            string s = Console.ReadLine();

            digitoVerificador(s);

           // Console.WriteLine(" el Numero: " + s);


            Console.ReadKey();
        }

        static string digitoVerificador(string rut)
        {

           int ruti = Convert.ToInt32(rut);

           int Contador = 2;
           int Acumulador = 0;

            while (ruti != 0)
            {

                Multiplo = (ruti % 10) * Contador;
                Acumulador = Acumulador + Multiplo;
                ruti = ruti/10;
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
                RutDigito = "K";
               // Console.WriteLine(" RutDigito = K");

            }
            if (Digito == 11)
            {

               // Console.WriteLine(" RutDigito = 0");
                RutDigito = "0";
            }
            Console.WriteLine();
            Console.WriteLine(" SU DIGITO VERIFICADOR ES: "+ RutDigito);
            return (RutDigito);

            
        }

        
    }

}
