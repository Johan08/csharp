using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Circulo:Figura
    {

        private float pi = 3.14f;



        public override float calcularArea()
        {
            return (lado * lado) * pi ;

        }// fin calcular area


        public override float calcularPerimetro()
        {
            return (2 * lado * pi );

        }// fin calcular area
    }
}


