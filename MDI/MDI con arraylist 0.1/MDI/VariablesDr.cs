using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MDI
{
    public class VariablesDr
    {

        
        private static string name;
        private static string apell;
        private static string especi;
       

    // creamos los constructores

        public VariablesDr(string name, string apell, string especi)
        {

            VariablesDr.name = name;
            VariablesDr.apell = apell;
            VariablesDr.especi = especi;

        }


        public VariablesDr()
        {

            VariablesDr.name = "";
            VariablesDr.apell = "";
            VariablesDr.especi = "";

        }



        public static string Nombre
        {

            get {
                return VariablesDr.name;
                }

            set
            {
                VariablesDr.name = value;
            }

        }


        public static string Apellido
        {

            get
            {
                return VariablesDr.apell;
            }

            set
            {
                VariablesDr.apell = value;
            }

        }


        public static string Especialidad
        {

            get
            {
                return VariablesDr.especi;
            }

            set
            {
                VariablesDr.especi = value;
            }

        }

        //--------------------------------------------------------

        public string getNombre()
        {

            return name;

        }

        //--------------------------------------------------------

        public void setNombre(string name)
        {

            VariablesDr.name = name;

        }

       // ------------------------------------------------

        public string getApellido()
        {

            return apell;

        }



        public void setApellido(string apell)
        {

            VariablesDr.apell = apell;

        }

        //-------------------------------------------------------------

        public string getEspecialidad()
        {

            return especi;

        }



        public void setEpecialidad(string especi)
        {

            VariablesDr.especi = especi;

        }

        //-----------------------------------------------------


    }// FIN CLASE VARIABLES DR
}
