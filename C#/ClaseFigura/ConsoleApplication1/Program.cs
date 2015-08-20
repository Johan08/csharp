using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Cuadrado objC = new Cuadrado() ;
            Triangulo objT = new Triangulo() ;
            Circulo objCir = new Circulo() ;
            


            //radio del circulo 
            objCir.setLado(4);

            
            // lado del cuadrado 
            objC.setLado(7);
            
            
            
            Console.WriteLine("Area del Circulo es: " + objCir.calcularArea());


            Console.WriteLine("Area del Cuadrado es: " + objC.calcularArea());


         

            objT.setLado(6) ;
            objT.setAltura(9) ;
            // salto de linea 
            Console.WriteLine();
            Console.WriteLine("Area del triangulo es: " + objT.calcularArea());
            Console.WriteLine();
            Console.WriteLine("Perimetros de la figura ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Perimetro del cuadrado es: " + objC.calcularPerimetro());
            Console.WriteLine("Perimetro del triangulo es: " + objT.calcularPerimetro());
            Console.WriteLine("Perimetro del circulo es: " + objCir.calcularPerimetro());
            
            // PARA NO CERRAR LA CONSOLA
            Console.ReadKey();

        }
    }
}
