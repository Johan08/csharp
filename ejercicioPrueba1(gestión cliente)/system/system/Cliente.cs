using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace system
{
    public class Cliente:Persona
    {
        string numeroCuenta;
       // float saldo = 10000;
        float saldo;

    // creo el objeto p de tipo persona
    Persona p = new Persona();


    // constructor
        public Cliente(string numeroCuenta , float saldo)
        {

            this.numeroCuenta = numeroCuenta;
            this.saldo = saldo;

        } 


    // metodos getters

        public string getNumcuenta()
        {

            return numeroCuenta;

        }

       
        public float getSaldo()
        {

            return saldo;

        }



        // metodos setters 

        public void setNumcuenta(string numeroCuenta)
        {

            this.numeroCuenta = numeroCuenta;


        }


        public void setSaldo(float saldo)
        {

            this.saldo = saldo;


        }

       public float girarDinero()
        {

            
            // preguntamos el saldo a sacar
           Console.Write("SALDO A GIRAR: ");
           // guadamos el valor que quiere sacar 
           Console.ForegroundColor = ConsoleColor.Yellow;
           string salario = Console.ReadLine();

           // transformamos el valor que quiere sacar y lo guardamos en la variable sal de tipo float
           float sal = Convert.ToSingle(salario);

           // generamos el calculo donde el saldo es de 10000 inicialmente y lo restamos a sal(el valor que puso el usuario) lo guardamos en la variable saldo perteneciente a la clase cliente
           saldo = saldo - sal;

           // retornamos el valor
           return (saldo);
       
       }// fin del metodo girarDinero

      

        public float depositarDinero()
       {
           Console.ForegroundColor = ConsoleColor.Yellow;
           Console.Write(" SALDO A DEPOSITAR: ");

           Console.ForegroundColor = ConsoleColor.Yellow;
           string salario = Console.ReadLine();

           float sal = Convert.ToSingle(salario);

           saldo = saldo + sal;

           return (saldo);
       
       }// fin del metodo depositarDinero()
    }
}
