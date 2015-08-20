using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace entradaManejodeExcepciones
{
    class Program
    {

       // esta variable se utiliza para todos lo metodos de la clase      
        static int n = 0;
        static int x = 0;
       // metodo Main.
        static void Main(string[] args)
        {
            // declaramos una variable booleana llamada cierto con el valor true.
            bool cierto = true;

            // para declarar un arreglo de 5 elementos enteros.
            int[] A = new int[5] ;
           
        
            

            // 1er do
            do
            {
                //2do do
                do
                {

                   
                    
                    //Le decimos al usuario que ingrese un numero
                    Console.WriteLine("Ingrese el Numero: ");

                    

                    // aqui se va a leer como un string, para luego ser convertido
                    string s = Console.ReadLine();
                    
                   
                    // LLAMADA AL METODO VALIDA-NUM.
                    if(!validaNum(s))
                    
                    // se cambia el valor de la variable cierto de tipo bool a false
                    cierto = false;

                
                //mientras el valor de la variable cierto de tipo bool siga siendo true se continuara en el ciclo, en caso contrario de ser false se saldra de este.
                } while (cierto);

               
                // validamos el ingreso, que solo acepte numeros negativos al array
                if (n < 0)
                {

                    //vamos ingresando un valor al array, mientras este se recorre.
                    A[x] = n;

                    // acá se se va incrementando la x hasta llegar a 5. Osea nos permittira el ingreso de 5 valores. 
                    x++;
                }
                  
                // en caso contrario de no ser un numero negativo, nos mostrara una alerta
                else
                {

                Console.WriteLine("INGRESE UN NUMERO NEGATIVO!") ;
                Console.WriteLine("\n") ;
                
                }

            // mientras que el valor que contenga X al incrementarse sea menor que el tamaño del arreglo A osea 5 continuara en el ciclo en caso contrario de ser igual se saldra.
            } while (x < A.Length);


        // LLAMADA AL METODO, acá se le pasara como parametro el arreglo A de tipo entero.
         mostrarArreglo(A);
        
         //para que no se cierre la consola 
        Console.ReadKey();       
        
        }// fin main



        //----------------METODOS DEFINIDOS-----------------------



        //----------------METODO MOSTRAR ARREGLO-----------------------

        // EL METODO MOSTRAR-ARREGLO, acá lleguA el argumento del arreglo A, pero con la letra K
        static void mostrarArreglo(int[] K)
        {
           // acá se recorrera el arreglo con la ayuda del for. usamos una propiedad llamada Length que mide el tamaño automatico del arreglo.
            for (int x = 0; x < K.Length; x++)
            {
                // se imprime en consola arreglo de numero insertados.
                Console.WriteLine("K [ " + x + " ]= " + K[x]);

            }

        }// FIN DEL METODO MOSTRAR ARREGLO




       // ----------------METODO VALIDA NUM-------------------------
        
        //INICIO DEL METODO PARA VALIDAR NUMERO, EL MATODO ES DE TIPO BOOL.
        //1-) , INGRESA EN TIPO STRING Y SERA CONVERTIDO A UN ENTERO DE TIPO INT.
        static bool validaNum(string s)
        {
            try
            {

                //para convertir string a entero
                 n = Convert.ToInt32(s);
                //n = Int32.Parse(s); // otra forma de convertir, parecida a java

                if(n>0)
                {

                Console.WriteLine("El numero : " + n + " es positivo") ;
                Console.WriteLine();

                }

            else
            {
                Console.WriteLine();
                Console.WriteLine("El numero : " + n + " es negativo");
                Console.WriteLine();
            }

               

             
             return false ;
            
            }

                   

            catch (FormatException e)
            {
         


                    Console.WriteLine("Usted a ingresado un caracter no permitido, Intente nuevamente...");
                    Console.WriteLine() ;
                
                return true ;

            }

          
           
        }// fin del metodo validaNum
       
    }
}
