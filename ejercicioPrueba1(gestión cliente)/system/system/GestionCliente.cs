// hacer getter y seterrs y cosntructor
// agregar metodos agregarCliente(persona p)-> void, girarDinero(int cantidad) -> tipo float 
// depositarDinero(int cantidad)-> float , mostrarCliente()-> void


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace system
{
    public class GestionCliente
    {

        static void Main(string[] args)
        {

            

            // crear un objeto de la clase cliente para poder llamar a los metodos

              Cliente obCliente = new Cliente("1234",0);

            //Cliente obCliente = new Cliente();
            // para llamar a los metodos se utiliza obCliente

            
            // creamos una variable tipo float llamada "sa" que guarda el valor obtenido mediante la llamada al metodo girarDinero() y depositarDinero() ; 
            float sa;

            int opcion;

            do
            {


                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("................. GESTION CLIENTE .....................");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.WriteLine("---------------        MENU       ---------------");
                Console.WriteLine(" ");
                Console.WriteLine("     1---------   Agregar Cliente    -----------");
                Console.WriteLine("     2---------   Mostrar Cliente    -----------");
                Console.WriteLine("     3---------    Girar Dinero      -----------");
                Console.WriteLine("     4---------   Depositar Dinero   -----------");
                Console.WriteLine("     5---------       Salir          -----------");

                //CREAR MENU
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("INGRESE SU OPCION: ");
                Console.Write("");
                Console.Write("");
                // Console.WriteLine(" ");
                //opcion = Convert.ToInt32(Console.ReadLine());
                //opcion = Convert.ToInt32(Console.ReadLine());


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
                    Console.WriteLine("OPCION VALIDA...");
                    Console.WriteLine();
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("OPCION INVALIDA...");
                }



                switch (opcion)
                {

                   // AGREGAR CLIENTE
                    case 1:

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("....................  AÑADIR CLIENTE  ....................");
                        Console.WriteLine("");
                        // agregamos el nombre de la persona 

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("NOMBRE DEL CLIENTE:  ");


                        Console.ForegroundColor = ConsoleColor.Yellow;
                       
                        string name = Console.ReadLine() ;
                        // le pasamos el nombre al metodo setNombre(name) de la clase persona 
                      
                        obCliente.setNombre(name) ;

                       
                       
                    
                        // AGREGAMOS EL DIGITO VERIFICADOR
                   
                        int sigue = 0;
                        string dv;
                  do
                    {
                        
                     

                       do
                       {

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("R.U.T DEL CLIENTE SIN DIGITO VERIFICADOR :  ");
                        // valor de vd
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        dv = Console.ReadLine();
                        
                        
                        obCliente.setDigito(dv);   
                     
                           
                       } while(obCliente.getDigito()=="w") ;

                          //aqui creamos una variable string llamada dvr que compara con getdv() si estos resultan iguales se agrega el dv osea el rut al metodo set rut y en caso de ser contrario entrgaremos un msje "incorrecto dv"
                           Console.ForegroundColor = ConsoleColor.White;
                           Console.Write("DIGITO VERIFICADOR DEL R.U.T:  ");
                           Console.ForegroundColor = ConsoleColor.Yellow;
                           string dvr = Console.ReadLine();

                           //comparamos, si resulta corrrecta la comparacion del rut...
                           if (dvr == obCliente.getDigito())
                           {
                               Console.WriteLine("");
                               Console.WriteLine("");
                               //agregamos el valor de dv al metodo setRut(dv) que ya tiene una validacion
                               Console.ForegroundColor = ConsoleColor.Yellow;
                               Console.WriteLine("DIGITO VERIFICADOR CORRESPONDE AL R.U.T INGRESADO...");
                               obCliente.setRut(dv);
                           }

                           else
                           {
                               // y en caso de ser contrario no agregamos el valor de dv al metodo setRut(dv) por lo que quedaria nulo
                               Console.WriteLine("");
                               Console.ForegroundColor = ConsoleColor.Red;
                               Console.WriteLine("DIGITO VERIFICADOR NO CORRESPONDE AL R.U.T INGRESADO...");
                               // ponemos en nada"" el dv para que no quede guardado algun valor anterior con el mismo rut.
                               obCliente.setRut("");
                           }
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("PARA PROBAR NUEVAMENTE DIGITE 1, PARA SALIR 0 o <Enter> : ");
                               
                           
                              //

                           try
                           {
                               Console.ForegroundColor = ConsoleColor.White;
                               sigue = Convert.ToInt32(Console.ReadLine());
                           }
                           catch (Exception e)
                           {
                               sigue = 0;
                           }

                   } while (sigue == 1);

                  //obCliente.setRut("");

                    break;  // fin del agregar cliente


                    // mostramos la información del cliente
                    case 2:                     
                        
                       
                       
                    // si el valor de get rut no es nulo osea contiene un valor y si a la vez es mayor que 0 que me imrpima el getdigito 
                        if (obCliente.getRut() != null && obCliente.getRut().Length > 0)
                        {
                            
                            Console.ForegroundColor = ConsoleColor.Yellow;//COLOR PARA EL TITULO
                            Console.WriteLine("");
                            Console.WriteLine("............... INFORMACION DEL CLIENTE.................");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("       NOMBRE DEL CLIENTE: " + obCliente.getNombre());
                            Console.WriteLine("       R.U.T DEL CLIENTE : " + obCliente.getRut());
                            Console.WriteLine("       DIGITO VERIFICADOR: " + obCliente.getDigito());                            
                           /////////////////////////////////////////////////////////////////////////////////
                            Console.WriteLine("       NUMERO DE CUENTA: " + obCliente.getNumcuenta());
                            Console.WriteLine("       SALDO: " + obCliente.getSaldo());
                            Console.WriteLine("");
                            
                        }                 
                    
                       else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("............... INFORMACION DEL CLIENTE.................");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("       NOMBRE DEL CLIENTE: NULO");
                            Console.WriteLine("       R.U.T DEL CLIENTE : NULO");
                            Console.WriteLine("       DIGITO VERIFICADOR: NULO");
                            Console.WriteLine("");
                        }
                       
                      
                        break; // FIN CASE 2
                                     
                    //CASE 3 hacemos el giro de dinero 
                    case 3:

                   
                        // primero mostramos el saldo inicial que tenemos en nuestra cuenta
                        if (obCliente.getRut() != null && obCliente.getRut().Length > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("SALDO INICIAL: " + obCliente.getSaldo());


                            sa = obCliente.girarDinero();

                            Console.ForegroundColor = ConsoleColor.Red;
                            // mostramos el nuevo saldo de la variable sa
                            Console.WriteLine("NUEVO SALDO: " + sa);
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR... VERIFIQUE SU RUT Y DIGITO VERIFICADOR");
                        }

                    break;// FIN CASE 3
                                         
                     
                    // hacemos el deposito de dinero
                    case 4:

                        // ingreso del saldo, verificamo el rut del cliente 
                    if (obCliente.getRut() != null && obCliente.getRut().Length > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SALDO INICIAL: " + obCliente.getSaldo());

                        sa = obCliente.depositarDinero();

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("NUEVO SALDO: " + sa);
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR... VERIFIQUE SU RUT Y DIGITO VERIFICADOR");
                    }
                       

                     break;// FIN CASE 4



                    case 5:
                     Console.ForegroundColor = ConsoleColor.DarkGray;
                     Console.WriteLine("HASTA LUEGO");


                     break;

                       
                    
                   default:

                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INGRESE UNA OPCIÓN VALIDA");
                    Console.WriteLine();

                    break;



                }// fin switch



            }//

            while (opcion != 5);

        }// fin main
    }// fin class
}// fin namespace 
