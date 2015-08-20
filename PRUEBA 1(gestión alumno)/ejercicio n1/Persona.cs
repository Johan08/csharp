using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace system
{
    public class Persona
    {     

     // declaramos los atributos protegidos que seran compartidos hacia la clase Alumno.
       protected string nombre;
       protected string rut;
       protected string digito;

        // metodos getters
        public string getNombre()
        {

            return nombre;
        
        }

        public string getRut()
        {

            return rut;

        }

        public string getDigito()
        {

            return digito;

        }
//////////METODOS SETTERS 
        public void setNombre(string nombre)
        {


            this.nombre = nombre;

        }


        public void setRut(string rut)
        {

            this.rut = rut;

        } 

        public void setDigito(string digito)
        {

            try
            {
                int largo = digito.Length;
                char[] arrayRut = digito.ToCharArray();
                int i = largo - 1;
                int mult = 9, resu = 0;
                while (i >= 0)
                {

                    int num = Convert.ToInt32(new String(arrayRut[i], 1));
                    resu = resu + (mult * num);
                    i--;
                    mult--;
                    if (mult == 3)

                        mult = 9;
                }

                int dv = resu % 11;

                if (dv == 10)
                {
                    this.digito = "k";
                    //d = "k";
                }

                else
                {

                    this.digito = dv.ToString();

                }

            }

            catch (FormatException e)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("EL NUMERO INGRESADO NO ES VALIDO...");

                this.digito = "w";
            }

        } // fin del metodo setDigito()
    }
}
