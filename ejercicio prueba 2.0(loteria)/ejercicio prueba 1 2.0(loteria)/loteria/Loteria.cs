using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Loteria
{
    public class Loteria
    {
        // delaramos un arrayList
        ArrayList boletos = new ArrayList();
        
        // vamos agregar el boleto 1
        int indice = 1 ;


        // creamos el metodo ventaBoleto

        public void ventaBoleto(String numCliente)
        {
            
            

            boletos.Add(new Boleto(indice, numCliente));
            indice++;
            Console.Beep();
            

        }// fin metodo venta Boleto


        public void muestraLista()
        {

            foreach(Boleto obj in boletos)
            {
                Console.Write("LA SECUENCIA DE NUMEROS ES LA SIGUIENTE: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("{0} {1}", obj.getId().ToString(),obj.getNumero());                
                Console.WriteLine("");
              

            }

            
        }



        // Buscar por id 

        public void buscarID()
        {

            int idUsuario;

            try
            {
                Console.Write("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingrese el ID del usuario: ");
                Console.Write("");
                Console.Beep();
                idUsuario = Convert.ToInt32(Console.ReadLine());
            }

            catch
            {

                idUsuario = -1;
            }

            //
            if (idUsuario > 0)
            {


            foreach (Boleto obj in boletos)
            {

                if (idUsuario == obj.getId())
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("La secuencia de numeros escogidos por el usuario es la siguiente: ");
                    Console.Write("{0}", obj.getNumero());
                    Console.WriteLine();
                }// fin if


                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El ID del usuario no se encuentra.");
                }

            }

 
        }

         
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ID incorrecto");
                Console.Write("");
            }

            

        }// fin del metodo buscar


        public void buscarNumero()
        {

            int numeros2;

                Console.Write("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingrese los numeros del usuario: ");
                Console.Write("");
                string s2 = Console.ReadLine();

                bool valida2 = int.TryParse(s2, out numeros2);
     
               // numeros2 = Convert.ToInt32(Console.ReadLine());
            
               //bool convert = int.TryParse()

                if (valida2 == true && s2.Length == 6)
                {


                    string convertido = numeros2.ToString();


                    foreach (Boleto obj in boletos)
                    {

                        //bool valido = true;


                        if (convertido == obj.getNumero())
                        {

                           // valido = false;

                            //Console.Write("{1}", obj.getId().ToString(), obj.getNumero());
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("El ID del usuario es: ");
                            Console.Write("");
                            Console.Write("{0}", obj.getId().ToString());
                            Console.WriteLine();
                        }// fin if

                       
                    }

                }

                else
                {
                    Console.Write("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error en el ingreso");
                    Console.Write("");
                }




        }


    }
}
