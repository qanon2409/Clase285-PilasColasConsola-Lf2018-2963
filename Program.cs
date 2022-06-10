using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase285
{
    class Program
    {
        static void Main(string[] args)
        {

            //PILAS Y COLAS

            Stack<string> lb = new Stack<string>();
            Queue<string> lb2 = new Queue<string>();

            bool a = true;
            while (a)
            {
                Console.WriteLine("-------SELECCIONAR METODO DE ALMACENAMIENTO--------");
                Console.WriteLine("1. Pila");
                Console.WriteLine("2. Cola");
                Console.WriteLine("3. Salir");


                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        {
                            Pila();
                            break;
                        }

                    case 2:
                        {
                            Cola();
                            break;
                        }
                    case 3:
                        {
                            a = false;
                            break;
                        }



                }

                void Pila()
                {
                    Console.WriteLine("1. Aniadir titulo");
                    Console.WriteLine("2. Eliminar titulo");
                    Console.WriteLine("3. Mostrar todo");
                    Console.WriteLine("4. Salir");


                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            {
                                Console.WriteLine("Escriba titulo de libro ");
                                string b = Console.ReadLine();
                                lb.Push(b);
                                break;
                            }

                        case 2:
                            {
                                Console.WriteLine("Eliminar titulo de libro ");
                                var b = lb.Pop();
                                Console.WriteLine($"El elemento eliminado es: {b}");
                                break;
                            }

                        case 3:
                            {
                                foreach (var i in lb)
                                {
                                    Console.WriteLine(i);
                                }
                                Console.ReadKey();
                                break;
                            }
                    }



                }

                void Cola()
                {
                    Console.WriteLine("1. Aniadir titulo");
                    Console.WriteLine("2. Eliminar titulo");
                    Console.WriteLine("3. Mostrar todo");
                    Console.WriteLine("4. Salir");


                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            {
                                Console.WriteLine("Escriba titulo de libro ");
                                string b = Console.ReadLine();
                                lb2.Enqueue(b);
                                break;
                            }

                        case 2:
                            {
                                Console.WriteLine("Eliminar titulo de libro ");
                                var b = lb2.Dequeue();
                                Console.WriteLine($"El elemento eliminado es: {b}");
                                break;
                            }

                        case 3:
                            {
                                foreach (var i in lb2)
                                {
                                    Console.WriteLine(i);
                                }
                                Console.ReadKey();
                                break;
                            }
                    }








                }



            }
        }
    }
}

