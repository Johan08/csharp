using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace system
{
 
    public class Alumno : Persona
    {

       private string carrera;       
       private int asignaturasCursadas;
       

        // constructor
        // este guardara lo que el usuario le pase 
        public Alumno(string nombre,string rut, string digito, string carrera, int asignaturasCursadas)
        {
            // inicializamos las variables 

            // estos atributos pertenecen a Persona que son de tipo protegido
            this.nombre = nombre;
            this.rut = rut;
            this.digito = digito;

            // estos atributos son exclusivos de la clase Alumno 
            this.carrera = carrera;
            this.asignaturasCursadas = asignaturasCursadas;

        }

         //creamos otro constructor que no toma argumentos que servira en la clase RegistroAlumno.para cuando pasemos el obAlumno. y no estemos pasandole argumentos. Ejemplo Alumno obAlumno = new Alumno(); ya que estaremos repitiendo la operacion. y la idea es que el usuario agregue.
        public Alumno()
        {

        }

        

        public string getCarrera()
        {

            return carrera;

        }


        public int getAsignaturasCursadas()
        {

            return asignaturasCursadas;

        }



        public void setCarrera(string carrera)
        {

            this.carrera = carrera;

        }


        public void setAsignaturasCursadas(int asignaturasCursadas)
        {
            
            this.asignaturasCursadas = asignaturasCursadas;


        }
    }
}
