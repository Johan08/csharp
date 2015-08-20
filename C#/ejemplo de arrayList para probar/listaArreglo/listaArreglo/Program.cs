using System;
// para trabajar en forma dinamica con arreglos se saca la plabra Generic
using System.Collections;
using System.Linq;
using System.Text;

namespace listaArreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            // crear e inicializar un arrayList

            // los arrayList no almacenan enteros solo se manejan objetos
            
            ArrayList miArrList = new ArrayList();
            miArrList.Add("Este ");
            miArrList.Add("es ");
            miArrList.Add("un ");
            miArrList.Add("ejemplo ");
            miArrList.Add("de ");
            miArrList.Add("arrayList ");

            // ver la cantidad de elementos de u arayList

            Console.WriteLine("Este arrList tiene un total de {0} elementos", miArrList.Count);
            Console.WriteLine("Este arrList tiene el siguiente contenido: ");
            mostrar(miArrList);


            Console.ReadKey();

        }

        // el metodo mostrar recibe un array list
        private static void mostrar(ArrayList miLista)
        {
            // para recorrer el arrayList necesitamos un foreach

            // para cada objeto que encuentre dentro de esta lista 
            foreach (Object obj in miLista)
            {
                Console.WriteLine(" {0}", obj);
                Console.WriteLine();
            }


            
        }
    }
}
