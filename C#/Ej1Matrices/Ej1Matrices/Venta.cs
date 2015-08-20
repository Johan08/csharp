using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej1Matrices
{
    class Venta
    {
        int[,] ventas = new int[4, 12];
        /*
         * 
           Promedio: retorna la venta promedio de los años
           PromedioAnual(): retorna un arreglo de 4 posiciones
         * con el promedio de cada año en cualquier orden.
           PeoresMeses(): retorna un arreglo de tamaño 4 donde 
         * cada posición representa un mes a partir desde enero, 
         * el valor de cada posición debe
         * llevar el año con la peor venta para dicho mes.
         */

        public void poblar()//Poblar(): llena la matriz con valores aleatorios.
        {
            Random r = new Random();
            int num1 = 0, num2 = 5;
            for (int fila = 0; fila < ventas.GetLength(0); fila++)
            {
                num1 = r.Next(100) + num1 + num2;
                for (int col = 0; col < ventas.GetLength(1); col++)
                {
                    ventas[fila, col] = num1++;
                }//fin for columnas
                num2 = r.Next(0,10) + num2;
            }//fin for filas
        }//fin poblar

        public void mostrar()
        {
            Console.WriteLine();
            for (int fila = 0; fila < ventas.GetLength(0); fila++)
            {
               for (int col = 0; col < ventas.GetLength(1); col++)
                {
                    Console.Write(" {0}", ventas[fila, col]); 
                }//fin for columnas
                Console.WriteLine();
            }//fin for filas
        }//fin mostrar

        public float promedio(int fila)
        {
            float p = 0f; int sum = 0;
            for (int i = 0; i < ventas.GetLength(1); i++)
            {
                sum += ventas[fila, i];
            }
            p = sum / ventas.GetLength(1);
            return p;
        }//fin promedio

        public float[] promedioGeneral()
        {
            float[] Proms = new float[4];
            Console.WriteLine();
            for (int x = 0; x < ventas.GetLength(0); x++)
            {

                    Proms[x] = promedio(x);
                    Console.Write(" {0}", Proms[x]);
            }//fin for filas
            return Proms;
        }//fin promedioGeneral
    }
}
