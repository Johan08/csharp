using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej1Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Desarrollar un programa que permita poblar con números enteros de forma aleatoria una matriz de 12 filas 
             * y 4 columnas, la cual representa las ventas realizadas para los 12 meses de los últimos 4 años a partir 
             * desde el 2011, de esta información se necesita conocer la venta promedio de los cuatro años, la suma de
             * las ventas de año y para cada mes conocer en qué año se tuvo la venta más baja.
             */
            Venta v = new Venta();
            v.poblar();
            v.mostrar();
            v.promedioGeneral();
            Console.ReadKey();
        }
    }
}
