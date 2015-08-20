using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loteria
{
    class GestionLoteria
    {
        static void Main(string[] args)
        {

            int opcion = 0;

            Loteria o = new Loteria();

            do
            {
                
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("..................    LOTERIA   .....................");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.WriteLine("---------------        MENU              -----------");
                Console.WriteLine(" ");
                Console.WriteLine("     1---------   Ingreso de los Numeros -----------");
                Console.WriteLine("     2---------   Mostrar los Numeros    -----------");
                Console.WriteLine("     3---------   Buscar por ID          -----------");
                Console.WriteLine("     4---------   Buscar por los numeros -----------");
                Console.WriteLine("     5---------       Salir              -----------");

                
               
                //CREAR MENU
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("INGRESE SU OPCION: ");
                Console.Write("");
                Console.Write("");
                

                try
                {
                    opcion = int.Parse(Console.ReadLine());

                    

                }
                catch
                {
                   
                    opcion = 0;

                }

                if (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4 || opcion == 5)
                {
                    
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("OPCION VALIDA");
                    Console.WriteLine();
                    
                   
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("OPCION INVALIDA");
                }

               
                
                    switch (opcion)
                    {



                        case 1:

                            int numeroLota;
                            Console.Write("");
                            Console.Write("");
                            Console.ForegroundColor = ConsoleColor.White;
                          
                            // valida el ingreso del string sea numero.
                            Console.WriteLine("Ingrese su secuencia ganadora de 6 digitos: ");
                            
                            String s1 = Console.ReadLine();
                            
                            bool valida = int.TryParse(s1, out numeroLota);

                            if (valida == true && s1.Length == 6)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("REGISTRO EXITOSO");
                                o.ventaBoleto(s1);
                                
                            }

                            else
                            {
                                Console.Write("");
                                Console.Write("");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Error ingrese correctamente");
                             
                            }


                            

                            break;


                        case 2:

                            

                            o.muestraLista();

                            

                            break;


                        case 3:

                            o.buscarID();

                            

                            break;

                        case 4:

                            o.buscarNumero();

                            

                            break;


                        


                        case 5:

                            Console.WriteLine("Hasta Luego");

                            

                            break;


                        default:

                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red ;
                            Console.WriteLine("Ingrese una opción valida");
                            Console.WriteLine();

                            break;

                           

                    }// fin switch

                    

                }//
               
           
           
            while (opcion != 5);


            Console.Clear();


        }// fin main
    
    
    }
}
