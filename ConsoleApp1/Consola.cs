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
            bool bucle = true;

            while (bucle)
            {
                int valorMenu;
                
                Menu();
                valorMenu = int.Parse(Console.ReadLine());

                switch (valorMenu)
                {
                    case 1:
                        ConvertorDeUpAndDown();
                        break;
                    case 2:
                        ComparadorFecha();
                        break;
                    case 3:
                        Polidromo();
                        break;
                    case 4:
                        Potencia();
                        break;
                    case 5:
                        Dividir();
                        break;
                    case 6:
                        ComparadorDeTexto();
                        break;
                    case 0:
                        bucle = false;
                        break;
                    default:
                        Console.WriteLine("Introduzca una opcion valida");
                        break;
                }
            }
        }

        public static void Menu()
        {
            Console.WriteLine(@"
1.      Comvertor de texto a CamelCase o LowerCase
2.      Comparador de fechas
3.      Comprobar si una palabra es un polidromo
4.      Calcular potencia
5.      Dividir
6.      Comparar text alfabeticamente

Presiona 0 para salir");
        }

        public static void ConvertorDeUpAndDown()
        {
            String cadena;
            String nuevaCadena = "";
            bool mayuscula = true;
            bool minuscula = true;
            int opciones;

            Console.WriteLine("Inserte la cadena de texto");
            cadena = Console.ReadLine();
            Console.WriteLine(@"
1.      Pasar el texto a CamelCase
2.      Pasar el texto a LowerCase");
            opciones = int.Parse(Console.ReadLine());

            switch (opciones)
            {
                case 1:
                    Console.WriteLine(CamelAndLower(cadena, true));
                    break;
                case 2:
                    Console.WriteLine(CamelAndLower(cadena, false));
                    break;
                default:
                    Console.WriteLine("Introduzca una opcion valida");
                    break;
            }
        }

        public static string CamelAndLower(string cadena,bool camel)
        {
            string nuevaCadena = "";
            bool letra = false;
            if (camel)
            {
                foreach (char caracter in cadena)
                {

                    if (caracter.Equals(' ')) 
                        letra = true;
                    else if (letra == true)
                    {
                        nuevaCadena = nuevaCadena + Char.ToUpper(caracter);
                        letra = false;
                    }
                    else if (letra == false) 
                        nuevaCadena = nuevaCadena + Char.ToLower(caracter);
                }

            }
            else
            {
                foreach (char caracter in cadena)
                {

                    if (caracter.Equals(' ')) letra = true;
                    else if (letra == true)
                    {
                        nuevaCadena = nuevaCadena + Char.ToLower(caracter);
                        letra = false;
                    }
                    else if (letra == false) nuevaCadena = nuevaCadena + Char.ToUpper(caracter);
                }
            }

            return nuevaCadena;
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

            polidromo = ComparacionDeCaracteres(entrada);

            if (polidromo) 
                Console.WriteLine("La palabra " + entrada + " es un polinomio");
            else 
                Console.WriteLine("La palabra " + entrada + " no es un polinomio");
        }

        private static bool ComparacionDeCaracteres(string entrada)
        {
            for (int i = 0; i < entrada.Length; i++)
            {
                if (entrada[i] != entrada[entrada.Length-i-1]) 
                    return false; 
            }
            return true;
        }

        public static void Potencia()
        {
            int numero, potencia, resultado;

            Console.WriteLine("Numero a multiplicar: ");
            numero = int.Parse(Console.ReadLine());
            resultado = numero;
            Console.WriteLine("Numero de la potencia: ");
            potencia = int.Parse(Console.ReadLine());

            for (int i = 0; i < potencia; i++)
            {
                resultado = resultado * numero;
            }

            Console.WriteLine("Resultado: " + resultado);
        }

        public static void Dividir()
        {
            Console.WriteLine("Introduzca el numerador");
            int numerador = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el denominador");
            int denominador = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultado: " + ComparadorDivisores(numerador, denominador));
        }

        public static int ComparadorDivisores(int numerador, int denominador)
        {
            int contador = 1;

            while (true)
            {
                if (numerador > denominador)
                {
                    numerador = numerador - denominador;
                    contador++;
                }
                else
                {
                    return contador;
                }
            }
        }

        public static void ComparadorDeTexto()
        {
            Console.WriteLine("Escriba la primera palabra");
            string palabra1 = Console.ReadLine();
            Console.WriteLine("Escriba la segunda palabra");
            string palabra2 = Console.ReadLine();

            Console.WriteLine(ComparadorDePalabras(palabra1, palabra2));
        }

        public static bool ComparadorDePalabras(string palabra1, string palabra2)
        {
            if (palabra1.Length <= palabra2.Length)
            {
                for (int i = 0; i < palabra2.Length; i++)
                {
                    if (palabra1[i] != palabra2[i])
                    {
                        if (palabra1[i] > palabra2[i])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else
            {
                for (int i = 0; i < palabra1.Length; i++)
                {
                    if (palabra1[i] != palabra2[i])
                    {
                        if (palabra1[i] > palabra2[i])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
    }
}