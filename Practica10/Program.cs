using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica10
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            string seguir = "";
           

            do
            {
                Console.Clear();
                Console.WriteLine("Ejercicios 1-4");
                opc = int.Parse(Console.ReadLine());
                string contraseña = "";
                switch (opc)
                {
                    
                    case 1:
                        ejer1();
                        break;
                    case 2:
                        ejer2();
                        break;
                    case 3:
                        Console.Write("Coloque la contraseña: ");
                        contraseña = Console.ReadLine();

                        ejer3(contraseña);
                        break;
                    case 4:
                        string pass;

                        for (int i = 3; i > 0; i--)
                        {
                            Console.WriteLine("intentos: " + i);
                            Console.Write("Coloque la contraseña: ");
                            pass = Console.ReadLine();

                            if (pass == contraseña)
                            {
                                Console.WriteLine("Bienvenido");
                                i = 1;
                            }
                            else
                            {
                                Console.WriteLine("siga intentando");
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;

                    default:
                        break;
                }
                Console.WriteLine("Desea seguir? s/n");
                seguir = Console.ReadLine();
            } while (seguir == "s");
           
          

            Console.ReadKey();
        }

        static void ejer1()
        {
            int opc = 0;

            Console.WriteLine("[1] Agregar pais");
            Console.WriteLine("[2] Mostrar paises");
            Console.WriteLine("[3] Buscar pais");
             opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    try
                    {
                       
                        Console.WriteLine("Cuantos paises agregara?");
                        Console.WriteLine();
                        int cPaises = int.Parse(Console.ReadLine());
                        StreamWriter sw = new StreamWriter("./ejer1.txt", false);
                        string seguir = "";

                        do
                        {
                            Console.Write("Nombre pais :");
                            string nPais = Console.ReadLine();
                            sw.WriteLine(nPais);
                            Console.WriteLine("Agregar otro pais? s/n" );
                            seguir = Console.ReadLine();

                        } while (seguir == "s");

                        sw.Close();
                        
                        Console.WriteLine();
                        Console.WriteLine("Paises guardados correctamente");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);

                        Console.WriteLine("Se ha producido un error");
                    }
                
                    break;
                case 2:
                   
                    StreamReader sr = new StreamReader("./ejer1.txt");
                    
                   
                    
                    Console.WriteLine(sr.ReadToEnd());

                    sr.Close();

                    break;
                case 3:
                    StreamReader sr1 = new StreamReader("./ejer1.txt");
                    string paisToFind = "";
                    Console.WriteLine("Pais a encontrar:");
                    paisToFind = Console.ReadLine();
                  
                  
                    string linea = sr1.ReadLine();
                    Console.WriteLine(sr1.ReadToEnd());
                    while (linea != null)
                    {
                        while (linea == paisToFind)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(paisToFind);
                        }
                        linea = sr1.ReadLine();
                    }

                    sr1.Close();
                    break;
                default:
                    break;
            }

        }

        static void ejer2()
        {
           
            
            StreamWriter sw = new StreamWriter("./ejer2.txt", true);
            Console.WriteLine("Cuatos paises seran?");
            int cPaises = Convert.ToInt32(Console.ReadLine());
            string[] paises = new string[cPaises];
            Console.WriteLine();
            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine("Pais: ");
                paises[i] = Console.ReadLine();
                sw.WriteLine(paises[i]);
            }
            sw.Close();
            StreamReader sr = new StreamReader("./ejer2.txt");

            Console.WriteLine();
            Console.WriteLine("Paises");
            Console.WriteLine("----------------");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }

        static void ejer3(string contraseña)
        {
           
          

            string a = contraseña.Replace(contraseña, "0paotolpidgg78");



            Stream fs = new FileStream("./ejer03.txt", FileMode.Create, FileAccess.ReadWrite);

            StreamWriter sw = new StreamWriter(fs);
                
                    sw.WriteLine(a);

            sw.Close();
               
            

            StreamReader sr = new StreamReader("./ejer03.txt");
            Console.WriteLine(sr.ReadLine());
            fs.Close();
           
            sr.Close();
            
           

           
           
           
            
            
           


        }

        

        

    }
}
