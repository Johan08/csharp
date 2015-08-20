using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
     public class Cuadrado:Figura
    {
         // le avisamos que vamos a modificar el metodo con la palabra "override"
        public override float calcularArea()
        {
            return lado * lado ;
        
        }// fin calcular area

        public override float calcularPerimetro()
        {
            return lado * 4;

        }// fin calcular area


    }
}




