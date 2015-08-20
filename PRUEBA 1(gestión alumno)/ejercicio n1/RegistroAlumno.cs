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
           
            // creamos un objeto llamado obList para llamar a los metodos. que se encuentran en ListadoAlumno
            ListadoAlumno obList = new ListadoAlumno();

            //   creamos el objeto de tipo alumno llamado obAlumno para pasarlo al metodo agregarAlumno(obAlumno)

             Alumno obAlumno = new Alumno();

       
            int opcion;

            do
            {


                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("................. REGISTRO ALUMNO .....................");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.WriteLine("---------------        MENU       ---------------");
                Console.WriteLine(" ");
                Console.WriteLine("     1----------   AGREGAR ALUMNO   -----------");
                Console.WriteLine("     2--------- INFORMACION DEL ALUMNO --------");
                Console.WriteLine("     3---------   MODIFICAR ALUMNO      -------");
                Console.WriteLine("     4---------       SALIR         -----------");

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

                if (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4 )
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
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

                    
                    case 1:

                        //AGREGAR ALUMNO, pasamos el objeto obAlumno
                        obList.agregarAlumno(obAlumno);
         
                    
                    break;
                    
                    
                    case 2:
                  

                        //MOSTRAR ALUMNO
                         obList.mostrarAlumno();
                          

                     break; 


             
                    case 3:
                               Console.ForegroundColor = ConsoleColor.Yellow;
                               Console.WriteLine("............... MODIFICACIÓN DE ASIGNATURAS CURSADAS .................");
                               Console.WriteLine("");

//////////////////////////////VALIDACION DEL RUT PARA MODIFICAR
                              int numRut = 0;
                              bool valida2 = false;
                              string dv2;
                              
                              do
                              {
                                  Console.ForegroundColor = ConsoleColor.Yellow;
                                  Console.Write("INGRESE EL R.U.T DEL ALUMNO SIN DIGITO VERIFICADOR NI PTOS: ");

                                  Console.ForegroundColor = ConsoleColor.White;
                                  dv2 = Console.ReadLine();

                                  bool convertRut = int.TryParse(dv2, out numRut);

                                  if (convertRut == true && dv2.Length == 8)
                                  {
                                      Console.ForegroundColor = ConsoleColor.Yellow;
                                      Console.WriteLine("ES UN R.U.T VALIDO...");
                                      valida2 = true;
                                  }


                                  else
                                  {
                                      Console.ForegroundColor = ConsoleColor.Red;
                                      Console.WriteLine("INGRESE UN R.U.T VALIDO...");
                                  }

                              } while (valida2 == false);

/////////////////////////VALIDACIÓN DE LA CANTIDAD DE ASIGNATURAS A CURSAR 
                              valida2 = false;
                     
                     do
                     {
                         Console.ForegroundColor = ConsoleColor.White;
                         Console.Write("INGRESE EL NUEVO N° DE ASIGNATURAS CURSADAS A MODIFICAR:  ");
                         try
                         {
                             int ac2 = Int32.Parse(Console.ReadLine());
                             if (ac2 >= 0)
                             {
                                 
                                 obList.modificarAsignatura(dv2, ac2);
                                 Console.WriteLine("");
                                 valida2 = true;
                             }

                             else
                             {
                                 Console.ForegroundColor = ConsoleColor.Red;
                                 Console.WriteLine("EL ENTERO NO PUEDE SER NEGATIVO. INTENTE NUEVAMENTE...");
                             }
                         }
                         catch (Exception e)
                         {
                             Console.ForegroundColor = ConsoleColor.Yellow;
                             Console.WriteLine("INGRESE UN NUMERO ENTERO...");
                         }
                     
                     } while (valida2 == false);


                      break;// FIN CASE 3



                    case 4:

                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("HASTA LUEGO");

                     break;// FIN CASE 4


                    default:

                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("INGRESE UNA OPCIÓN VALIDA");
                        Console.WriteLine();

                      break;

                }// fin switch

            }//

            while (opcion != 4);

        }// fin main
    }// fin class
}// fin namespace 
