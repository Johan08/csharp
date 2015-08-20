using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace digitoVerificador
{
    class Program
    {
        static void Main(string[] args)
        {
            int sigue = 0;
            do
            {
                string d = "w";
                do
                {
                    Console.WriteLine("Ingrese su rut sin dígito verificador, sin puntos ni guiones");
                    string rut = Console.ReadLine();
                    d = retornaDV(rut);
                } while (d == "w");
                Console.WriteLine("Digito verificador: " + d);
                Console.WriteLine("Para probar otro rut digite 1, para salir 0 o <Enter>");
                try
                {
                    sigue = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    sigue = 0;
                }
            } while (sigue == 1);
            //Console.ReadKey();
        }

        static string retornaDV(string r)
        {
            try
            {
                int largo = r.Length;
                char[] arrayRut = r.ToCharArray();
                int i = largo - 1;
                int mult = 9, resu = 0;
                while (i >= 0)
                {
                    int num = Convert.ToInt32(new String(arrayRut[i], 1));
                    resu = resu + (mult * num);
                    i--;
                    mult--;
                    if (mult == 3) mult = 9;
                }
                int dv = resu % 11;
                if (dv == 10) return "k";
                else return dv.ToString();
            }
            catch (FormatException e)
            {
                Console.WriteLine("El número ingresado no es válido.");
                return "w";
            }
        }//fin retornaDV
    }
}