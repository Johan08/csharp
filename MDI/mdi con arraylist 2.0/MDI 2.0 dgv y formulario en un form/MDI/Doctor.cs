using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MDI
{
    public class Doctor
    {

        public string nombre;
        public string apellido;
        public string especialidad;

        
        // cosntructor

         public Doctor(string nombre,string apellido, string especialidad)
        {
            // inicializamos las variables 

            // estos atributos pertenecen a Persona que son de tipo protegido
            this.nombre = nombre;
            this.apellido = apellido;
            this.especialidad = especialidad;

            // estos atributos son exclusivos de la clase Alumno 
            

        }

         public Doctor()
         {

             this.nombre = "";
             this.apellido = "";
             this.especialidad = "";
         }
      

        // metodos getters
        public string getNombre()
        {

            return nombre;

        }

        public string getApellido()
        {

            return apellido;

        }

        public string getEspecialidad()
        {

            return especialidad;

        }
        //////////METODOS SETTERS 
        public void setNombre(string nombre)
        {


            this.nombre = nombre;

        }


        public void setApellido(string apellido)
        {

            this.apellido = apellido;

        }


        public void setEspecialidad(string especialidad)
        {

            this.especialidad = especialidad;

        }


    
    }
}
