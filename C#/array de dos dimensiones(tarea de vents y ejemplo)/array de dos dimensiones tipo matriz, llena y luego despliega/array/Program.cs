using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {

            // 3 representa los años y el 4 los meses

            int[,] K = new int[3, 4];
            Console.WriteLine("Arreglo de dos dimensiones, tipo matriz");
           
            llenar(K);
            mostrar(K);

            Console.ReadKey();

        }


        private static void llenar(int[,] M)
        {

            for (int fila = 0; fila < M.GetLength(0); fila++)
            {
                for (int col = 0; col < M.GetLength(1); col++)
                {
                    Random r = new Random();
                    M[fila, col] = r.Next();

                }// fin columnas


            }// FIN FOR FILA
        } 


private static void mostrar(int[,] M)
{
    Console.WriteLine() ;

 	for(int fila= 0; fila< M.GetLength(0); fila++)
    {
        for(int col = 0; col<M.GetLength(1) ; col++)
        {
          Console.Write(" " + M[fila,col]) ; 
        }// fin columnas

Console.WriteLine() ;
    }// FIN FOR FILA
}// fin mostrar





    }

}
