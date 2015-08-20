using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace caracteres
{
    class Program
    {
        static int n = 0;
        static char[] A = new char[5];
        static char temp;
        
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.WriteLine("ingrese un caracter distinto de letra");
                    temp = Convert.ToChar(Console.ReadLine());
                    if (!char.IsLetter(temp))
                    {
                        A[n] = temp;
                        n++;
                    }
                    else
                    {
                        Console.WriteLine("no debe ser letra");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("debe ingresar un solo caracter. Intente nuevamente");
                }

            } while (n < A.Length);

            mostrarArr(A);
            Console.ReadKey();
        }//fin main

        static void mostrarArr(char[] A)
        {
            for (int x = 0; x < A.Length; x++)
            { Console.WriteLine("A[" + x + "]=" + A[x]); }

        }//fin mostrarArr
    }
}