using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tareaProgra
{
    class Program
    {
     
            static void Main(string[] args)
            {

                int[,] K = new int[2, 4];
                Console.WriteLine("Arreglo de dos dimensiones, tipo matriz");
                
                // poblar
                llenar(K);
                
                // MOSTRAR LA VENTA DE CADA MES
                mostrar(K);

                // promedio 4 meses
                //promedio(K);

                promedioAnual(K) ;

                promedio(K);

                peorMes(K);

               // promedioAnual(K);

                Console.ReadKey();

            }


            private static void llenar(int[,] M)
            {
                Console.WriteLine("INGRESO DE VENTAS");

                int ventas;

                // string v;
                //años
                for (int fila = 0; fila < M.GetLength(0); fila++)
                {

                   

                    // meses
                    for (int col = 0; col < M.GetLength(1); col++)
                    {

                        Console.WriteLine("Ingrese las ventas del año: ");

                        // al utiliza el convert si no introducimo un dato nos devuelve 0 
                        //v = Console.ReadLine();
                        //ventas = Convert.ToInt32(v);


                        // al utilizar int32.Parse si no introducimos nada nos devuelve una excepcion tipo null
                        ventas = Int32.Parse(Console.ReadLine());

                        M[fila, col] = ventas;
                       // Random r = new Random();

                      //  M[fila, col] = r.Next(0, 100);

                    }// fin columnas


                }// FIN FOR FILA
            
            }

            
            private static void promedioAnual(int[,] M)
            {
                double suma = 0;
              
                // int contador = 4 ;
                // PROMEDIO DE CUATRO AÑOS
               
                //AÑOS
                for ( int fila=0; fila < M.GetLength(0); fila++)
                {

                    suma = 0;

                    for (int col=0; col < M.GetLength(1); col++)
                    {


                         suma += M[fila,col];
                         
                        

                        Console.WriteLine() ;



                        
                    }// fin columnas

           

                    Console.Write("Promedio Anual " + suma/4);

                }




            }



            private static void promedio(int[,] M)
            {
                double suma = 0 ;
                double s = 0 ;
                double prom = s;
                // int contador = 4 ;
                // PROMEDIO DE CUATRO AÑOS

                //AÑOS
                for (int fila = 0; fila < M.GetLength(0); fila++)
                {

                    suma = 0;

                    for (int col = 0; col < M.GetLength(1); col++)
                    {


                        suma += M[fila, col];



                        Console.WriteLine();

                       


                    }// fin columnas


                    s += suma ;

                    prom = s;

                    Console.WriteLine("Suma de todos los meses " + prom);

                }

                Console.WriteLine("promedio de todos los años " + prom / 2);


            }
            


            
                        private static void mostrar(int[,] M)
                        {
                            Console.WriteLine("VENTAS ANUALES");

                            for (int fila = 0; fila < M.GetLength(0); fila++)
                            {
                                for (int col = 0; col < M.GetLength(1); col++)
                                {
                                    Console.Write(" " + M[fila, col]);
                                }// fin columnas

                                Console.WriteLine();
                            }// FIN FOR FILA
                        }// fin mostrar




                        private static void peorMes(int[,] M)
                        {
                            Console.WriteLine("PEORES MESES");

                            int temp = 0;

                            for (int fila = 0; fila < M.GetLength(0); fila++)
                            {
                                for (int col = 0; col < M.GetLength(1)-1; col++)
                                {
                                    if (M[fila, col] < M[fila, col + 1])
                                    {

                                        temp = M[fila, col];

                                        M[fila, col] = M[fila, col + 1];
                                        
                                        M[fila, col + 1] = temp ;

                                       

                                    }

                                    Console.WriteLine("La peor venta es: " + temp);
                                
                                }// fin columnas

                                

                                Console.WriteLine();
                            }// FIN FOR FILA
                        }// fin mostrar
                      

                        


        }
    }
