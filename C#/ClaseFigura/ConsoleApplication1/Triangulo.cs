using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Triangulo : Figura
    {

        private float altura;

        //
        public float getAltura()
        {
            return altura;

        }

        public void setAltura(float altura)
        {
            if (altura > 0)
                this.altura = altura;

        }

            // le avisamos que vamos a modificar el metodo con la palabra "override"
            public override float calcularArea()
            {
                return (lado * altura) / 2;

            }// fin calcular area

            public override float calcularPerimetro()
            {
                return (lado * 3);

            }// fin calcular area
        }
    } 

