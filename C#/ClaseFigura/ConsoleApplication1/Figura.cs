using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Figura
    {
        protected float lado;
       

        // para heredar el metodo a cuadrado la palabra clave "virtual"
        public virtual float calcularArea()
        {
            return 0;
        }// fin calcular area

        public float getLado()
        {
            return lado;
        }

        public void setLado(float lado)
        {
            if (lado > 0)
            this.lado = lado;
        }


        // para heredar el metodo a cuadrado la palabra clave "virtual"
        public virtual float calcularPerimetro()
        {
            return 0;
        }// fin calcular perimetro



    }
}
