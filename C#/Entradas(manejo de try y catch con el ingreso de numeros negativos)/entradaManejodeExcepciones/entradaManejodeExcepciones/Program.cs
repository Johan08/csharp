using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace entradaManejodeExcepciones
{

    class Program
    {
        static void Main(string[] args)
        {
            // declaramos una variable booleana con el valor true 
            bool cierto = true ;

            do
            {
            
            // Imprimimos en consola
            Console.WriteLine("Ingrese el Numero : ");
  
            // Ingreso de datos en formato string.
            string s = Console.ReadLine();

            // el try va en la conversion
            try
            {

                //Luego se convierte lo obtenido en la entrada(string) y se lleva a un entero, para ello declaramos una variable entera y guadarmos el resultado convertido.
                int n = Convert.ToInt32(s);

                // el entero n ahora se puede utilizar como tal
                
                // si n es < 0 se mostrara el resultado
                if (n < 0)
                {
                    Console.WriteLine("El numero es: " + n);
                   
                    // se cambia la la variable cerrojo true por false cuando el numero sea negativo
                    cierto = false;

                }
                
                // en caso contrario deja un mensaje para que intente nuevamente 
                else
                {

                    Console.WriteLine("Debe ingresar un numero negativo " );
                }
                }

           
            // podemos tener varios catch del más especifico, al más general.

            catch (FormatException e)
            {

                Console.WriteLine("Porfavor ingrese un numero entero. Intente nuevamente...");

            }

            catch (Exception ee)
            {
                Console.WriteLine("Se produjo un error. Intente nuevamente...");

            }
            
            // mientras el valor de cierto siga siendo true se continuara en el ciclo!. Y cuando sea false se saldra.
            }while(cierto) ;


            // para que no se cierre la consola.
            Console.ReadKey();

        }
    }
}
