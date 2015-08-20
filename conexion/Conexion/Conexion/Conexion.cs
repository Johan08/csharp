using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ConectarBD
{
    class Conexion
    {
        private string cadenaConexion = "";
        private SqlConnection miCon = null;
        private SqlCommand miComm = null;
        private SqlDataReader miDR = null;


        public Conexion()
        {
            this.cadenaConexion = "Server=localhost\\sqlexpress;Database=model;Trusted_Connection=True;";
           
        }

        public void openConexion()
        {
            try
            {

                this.miCon = new SqlConnection(this.cadenaConexion);
                this.miCon.Open();
                this.miComm = new SqlCommand();
                this.miComm.Connection = miCon;
                Console.WriteLine("CONECTADO");

            }

            catch (Exception e)
            {
                Console.WriteLine("Error de conexión " + e);

            }


        }// fin metodo openConexion()


        public void closeConexion()
        {
            try
            {
                miCon.Close();
                Console.WriteLine("DESCONECTADO de la BD");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error de desconexión " + e);
            }

        }// fin metodo closeConexion()


        //sql datareader le la informacion de la base de datos.


        public SqlDataReader seleccion(string miconsulta)
        {
            try
            {

                this.miComm.CommandText = miconsulta;
                this.miDR = this.miComm.ExecuteReader();
               
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error de SQL: " + e);
            }


            return this.miDR;

        }// fin metodo seleccion().


        //vamos hacer un metodo tipo boolean para ver si se insertan los datos.

        public bool insertar(string queryIns)
        {

            try
            {
                this.miComm.CommandText = queryIns;
                this.miComm.ExecuteNonQuery();
                return true;
            }
            catch(SqlException e)
            {

                Console.WriteLine("Error de SQL: " + e);
                return false;
            }


        } 



    }
}
