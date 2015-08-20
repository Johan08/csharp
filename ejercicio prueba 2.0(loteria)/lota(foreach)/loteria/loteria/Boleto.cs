
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loteria
{
    public class Boleto
    {
        private int id;
        private String numero;


        // metodo contructor para incializar 
        public Boleto(int id, String num)
        {
            this.id = id ;
            numero = num;


        }


        public int getId()
        {

            return id;
        }


        // metodo numero
        public void setNumero(String numero)
        {

            this.numero = numero;

        }


        public String getNumero()
        {

            return numero;
        }



    }
}
