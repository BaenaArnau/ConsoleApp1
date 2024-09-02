using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Consola
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int valorMenu;
                
                Menu();
                valorMenu = int.Parse(Console.ReadLine());

                if (valorMenu == 1) ConvertorDeTexto();
                else if (valorMenu == 2) ComparadorFecha();
                else if (valorMenu == 3) Polidromo();   
                else if (valorMenu == 0) break;
                else Console.WriteLine("Escriba una opcion valida");
            }
        }

        public static void Menu()
        {
            Console.WriteLine(@"1.    Comvertor de tecto a CamelCase o LowerCase
2.    Comparador de fechas
3.    Comprobar si una palabra es un polidromo

Presiona 0 para salir");
        }

        public static void ConvertorDeTexto()
        {
            String cadena;
            String nuevaCadena;
            bool mayuscula;
            bool minuscula;
            string opciones;


                nuevaCadena = "";
                mayuscula = true;
                minuscula = true;

                Console.WriteLine("Inserte la cadena de texto");
                cadena = Console.ReadLine();
                Console.WriteLine("Quieres pasarlo a CamelCase o LowerCase");
                opciones = Console.ReadLine();

                if (opciones.ToLower().Equals("camelcase"))
                {

                    foreach (char caracter in cadena)
                    {

                        if (caracter.Equals(' ')) mayuscula = true;
                        else if (mayuscula == true)
                        {
                            nuevaCadena = nuevaCadena + Char.ToUpper(caracter);
                            mayuscula = false;
                        }
                        else if (mayuscula == false) nuevaCadena = nuevaCadena + Char.ToLower(caracter);

                    }

                    Console.WriteLine(nuevaCadena);
                }
                else if (opciones.ToLower().Equals("lowercase"))
                {

                    foreach (char caracter in cadena)
                    {

                        if (caracter.Equals(' ')) minuscula = true;
                        else if (minuscula == true)
                        {
                            nuevaCadena = nuevaCadena + Char.ToLower(caracter);
                            minuscula = false;
                        }
                        else if (minuscula == false) nuevaCadena = nuevaCadena + Char.ToUpper(caracter);
                    }

                    Console.WriteLine(nuevaCadena);
                }
                else Console.WriteLine("Introduzca una opcion valida");
        }

        public static void ComparadorFecha()
        {
            string fecha1, fecha2;
            bool igual = false;

            Console.WriteLine("Escriba la primera fecha a continuacion (ej: MM/dd/yyyy)");
            fecha1 = Console.ReadLine();
            Console.WriteLine("Escriba la segunda fecha a continuacion (ej: MM/dd/yyyy)");
            fecha2 = Console.ReadLine();

            if (fecha1.Length == 10 && fecha2.Length == 10)
            {
                if (fecha1[9] == fecha2[9] && fecha1[8] == fecha2[8] && fecha1[7] == fecha2[7] && fecha1[6] == fecha2[6])
                {
                    if (fecha1[4] == fecha2[4] && fecha1[3] == fecha2[3])
                    {
                        if (fecha1[1] == fecha2[1] && fecha1[0] == fecha2[0])
                        {
                            igual = true;
                        }
                    }
                }

                if (igual)
                {
                    Console.WriteLine("Las dos fechas son iguales");
                }
                else
                {
                    Console.WriteLine("Las dos fechas no son iguales");
                }
            }
            else
            {
                Console.WriteLine("Introduzca un formato correcto");
            }
        }

        public static void Polidromo()
        {
            string entrada;
            bool polidromo = false;

            Console.WriteLine("Escriba la palabra a continuacion:");
            entrada = Console.ReadLine().ToLower();

            for (int i = 0; i < entrada.Length; i++)
            {
                if (entrada[i] == entrada[entrada.Length-i-1]) polidromo = true;
                else
                {
                    polidromo = false; 
                    break;
                }
            }

            if (polidromo) Console.WriteLine("La palabra " + entrada + " es un polinomio");
            else Console.WriteLine("La palabra " + entrada + " no es un polinomio");
        }
    }
}