using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ConectarBD
{
    class Program
    {
        static void Main(string[] args)
        {

            Conexion cx = new Conexion();

            Console.WriteLine("nos conectamos a la bd\n");

            cx.openConexion();


            Console.WriteLine("CONSULTA\n");

            string consulta = "select * from persona";
            SqlDataReader misDatos = cx.seleccion(consulta);

            while (misDatos.Read())
            {

                Console.WriteLine(misDatos["perso_id"].ToString()+misDatos["perso_rut"].ToString()+misDatos["perso_nombre"].ToString()+misDatos["perso_fechnac"].ToString());

            }
            cx.closeConexion();
            cx = new Conexion();
            cx.openConexion();

            int id = 200;
            string resp = "s";
            do
            {
                string rut = "";
                string nom = "";
                string fnac = "";



                Console.WriteLine("");
                Console.WriteLine("Ingrese rut: ");
                rut = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Ingrese nombre: ");
                nom = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Ingrese fecha_nacimiento dd-mm-aaaa: ");
                fnac = Console.ReadLine();
                Console.WriteLine("");

                string q = "insert into persona values(" + id + ",'" + rut + "','" + nom + "','" + fnac + "')";
                Console.WriteLine(q);

                if (cx.insertar(q))
                {
                    id++;
                    Console.WriteLine("Inserción exitosa!");
                    Console.WriteLine("");
                }

                Console.WriteLine("para seguir ingresando presiones la tecla 's'. Para finalizar use otra tecla");
                resp = Console.ReadLine();

            } while (resp == "s" || resp == "s");
            

            Console.WriteLine("ahora desconectamos\n");
            cx.closeConexion();

            Console.ReadKey();

            
        }
    }
}
