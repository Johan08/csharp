using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace system
{
    public class ListadoAlumno
    {
        
        // declaramos el objeto ArrayList llamado "alumno".
        ArrayList alumno = new ArrayList(); 


//////// METODO AGREGAR
        // pasamos el obAlumno desde RegistroAlumno ahora se llamara a que contendra los metodos tanto de alumno como de parsona ya que alumno proviene de persona.
        public void agregarAlumno(Alumno a)   
        {
          
            Console.WriteLine("------------- AÑADIR ALUMNO ----------------");
                                 
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Gray;

             bool valida3 = false ;
             bool valida4 = false;
/////AGREGAMOS EL NOMBRE DEL ALUMNO 
            do
            {
                 
                    int numString = 0;

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("NOMBRE DEL ALUMNO:  ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string name2 = Console.ReadLine();

                    bool valida = int.TryParse(name2, out numString);
                    
                    if (valida == false && name2.Length > 0)
                    {
                        a.setNombre(name2);
                        valida3 = true;
                    }
                    else if(valida == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("El NOMBRE NO PUEDE CONTENER NUMEROS...");
                        valida3 = false;
                    }
                        
                    else if (name2.Length == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("DEBE INGRESAR EL NOMBRE...");
                        valida3 = false;
                    }
            
            }while(valida3 == false);




////// AGREGAMOS EL RUT DEL ALUMNO Y EL DIGITO VERIFICADOR

                    bool sigue2 = false;
                    string dv2;
                    do
                    {
                        do
                        {

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("R.U.T DEL ALUMNO SIN DIGITO VERIFICADOR :  ");
                            // valor de vd
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            dv2 = Console.ReadLine();

                            a.setDigito(dv2);
                          

                        } while (a.getDigito() == "w");

                        //aqui creamos una variable string llamada dvr que compara con getdv() si estos resultan iguales se agrega el dv osea el rut al metodo set rut y en caso de ser contrario entrgaremos un msje "incorrecto dv"
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("DIGITO VERIFICADOR DEL R.U.T:  ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string dvr = Console.ReadLine();

                        //comparamos, si resulta corrrecta la comparacion del rut...
                        if (dvr == a.getDigito())
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            //agregamos el valor de dv al metodo setRut(dv) que ya tiene una validacion
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("DIGITO VERIFICADOR CORRESPONDE AL R.U.T INGRESADO...");
                           
                            // AGREGAMOS EL RUT 
                            a.setRut(dv2);

                            sigue2 = true;

                        }

                        else
                        {                          
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("DIGITO VERIFICADOR NO CORRESPONDE AL R.U.T INGRESADO. INTENTE NUEVAMENTE");
                           // SI EL DV NO CORRESPONDE AL RUT INGRESADO LO TORNA VACIO.
                            Console.WriteLine("");
                            a.setRut("");
                          
                            sigue2 = false;
                       
                        }

                        /*
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("PARA PROBAR NUEVAMENTE DIGITE 1, PARA SALIR 0 o <Enter> : ");

                        sigue2 = Int32.Parse(Console.ReadLine());
                    */
                      

              } while (sigue2 == false);   
           
       
///////////// AGREGAMOS LA CARRERA  Y NUMERO DE ASIGNATURAS CURSADAS   /////////////////////////////////////////////////////////////////////////////////
///////////// AGREGAMOS LA CARRERA 
                    do
                    {

                        int numString2 = 0;
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("INGRESE LA CARRERA:  ");
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        string carr2 = Console.ReadLine();
                        valida4 = int.TryParse(carr2, out numString2);

                        
                      

                        if (valida4 == false && carr2.Length > 0)
                        {
                            a.setCarrera(carr2);
                            valida4 = true;
                        }

                        else if (valida4 == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("EL NOMBRE DE LA CARRERA NO PUEDE CONTENER NUMEROS...");
                            valida4 = false;
                        }

                        else if (carr2.Length == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("DEBE INGRESAR EL NOMBRE DE LA CARRERA...");
                            valida3 = false;
                        }


                    } while (valida4 == false);

                    ////////AGREGAMOS ASIGNATURAS CURSADAS 
                     bool valida2 = false;
                     do
                     {
                         
                         
                         Console.ForegroundColor = ConsoleColor.White;
                         Console.Write("CANTIDAD DE ASIGNATURAS CURSADAS:  ");

                         try
                         {
                             Console.ForegroundColor = ConsoleColor.Yellow;
                             int ac2 = Int32.Parse(Console.ReadLine());
                             if (ac2 >= 0)
                             {
                                 a.setAsignaturasCursadas(ac2);
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
                             Console.ForegroundColor = ConsoleColor.Red;
                             Console.WriteLine("INGRESE UN NUMERO ENTERO..." );
                         }
                     
                     } while (valida2 == false);

                   
                     // agregamos el nombre, rut, digito, carrera y asignaturasCursadas.
            
                      alumno.Add(new Alumno(a.getNombre(),a.getRut(),a.getDigito(),a.getCarrera(),a.getAsignaturasCursadas()));

                      Console.WriteLine("");
                      Console.WriteLine("");
                      Console.ForegroundColor = ConsoleColor.Yellow;
                      Console.WriteLine("            ALUMNO HA SIDO INGRESADO AL SISTEMA...      ");
                      Console.WriteLine("");
        } // FIN DEL METODO AGREGAR ALUMNO
       
///////////MOSTRAR ALUMNO

        public void mostrarAlumno()
        {
            // foreach recorrera el arrayList alumno y con obj . obtenemos los datos de alumno
            foreach (Alumno obj in alumno)
            {           
                Console.ForegroundColor = ConsoleColor.Yellow;//COLOR PARA EL TITULO
                Console.WriteLine("");
                Console.WriteLine("............... INFORMACION DEL ALUMNO.................");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("       NOMBRE DEL ALUMNO: " + obj.getNombre());              
                Console.WriteLine("       R.U.T DEL ALUMNO : " + obj.getRut());
                if (obj.getRut() == "")
                Console.WriteLine("       DIGITO VERIFICADOR: " );
                else
                Console.WriteLine("       DIGITO VERIFICADOR: " + obj.getDigito());
                Console.WriteLine("       CARRERA: " + obj.getCarrera());
                Console.WriteLine("       N° DE ASIGNATURAS CURSADAS: " + obj.getAsignaturasCursadas().ToString());
                Console.WriteLine("");
            }
        }

///////////MODIFICAR CANTIDAD DE ASIGNATURAS CURSADAS

        public void modificarAsignatura(string rut, int cantidad)
        {
            bool valida = false; 

            foreach (Alumno obj in alumno)
           {

               

                if (obj.getRut() == rut)
                {
                    
                    obj.setAsignaturasCursadas(cantidad);
                    valida = true;
                }

           }// cierre del foreach

            if (valida == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("EL RUT INGRESADO SE ENCUENTRA EN LA LISTA...");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("EL N° DE ASIGNATURAS CURSADAS HA SIDO MODIFICADO CON EXITO...");
            }

            else if (valida == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NO SE PUDO MODIFICAR EL N° DE ASIGNATURAS CURSADAS. EL RUT INGRESADO NO SE ENCUENTRA EN LA LISTA.");
            }

            Console.WriteLine("");
        }// cierre del metodo modificarAsignatura

       
    }//cierre del ListadoAlumno  
}// cierre del namespace 
