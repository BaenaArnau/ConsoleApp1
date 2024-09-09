using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraduccionMorse
{
    internal class Program
    {
        static Dictionary<char, string> morseCode = new Dictionary<char, string>()
        {
            { 'A', ".-" },    { 'B', "-..." },  { 'C', "-.-." },  { 'D', "-.." },
            { 'E', "." },     { 'F', "..-." },  { 'G', "--." },   { 'H', "...." },
            { 'I', ".." },    { 'J', ".---" },  { 'K', "-.-" },   { 'L', ".-.." },
            { 'M', "--" },    { 'N', "-." },    { 'O', "---" },   { 'P', ".--." },
            { 'Q', "--.-" },  { 'R', ".-." },   { 'S', "..." },   { 'T', "-" },
            { 'U', "..-" },   { 'V', "...-" },  { 'W', ".--" },   { 'X', "-..-" },
            { 'Y', "-.--" },  { 'Z', "--.." },  { '0', "-----" }, { '1', ".----" },
            { '2', "..---" }, { '3', "...--" }, { '4', "....-" }, { '5', "....." },
            { '6', "-...." }, { '7', "--..." }, { '8', "---.." }, { '9', "----." },
            { ' ', "/" }
        };

        static Dictionary<string, char> morseToSpanish = new Dictionary<string, char>()
        {
            { ".-", 'A' },   { "-...", 'B' }, { "-.-.", 'C' }, { "-..", 'D' },
            { ".", 'E' },    { "..-.", 'F' }, { "--.", 'G' },  { "....", 'H' },
            { "..", 'I' },   { ".---", 'J' }, { "-.-", 'K' },  { ".-..", 'L' },
            { "--", 'M' },   { "-.", 'N' },   { "---", 'O' },  { ".--.", 'P' },
            { "--.-", 'Q' }, { ".-.", 'R' },  { "...", 'S' },  { "-", 'T' },
            { "..-", 'U' },  { "...-", 'V' }, { ".--", 'W' },  { "-..-", 'X' },
            { "-.--", 'Y' }, { "--..", 'Z' }, { "-----", '0' },{ ".----", '1' },
            { "..---", '2' },{ "...--", '3' },{ "....-", '4' },{ ".....", '5' },
            { "-....", '6' },{ "--...", '7' },{ "---..", '8' },{ "----.", '9' },
            { "/", ' ' }
        };

        static void Main(string[] args)
        {
            while (Menu());
        }

        static bool Menu()
        {
            Console.WriteLine("1.   Traducir de español a morse");
            Console.WriteLine("2.   Traducir de morse a español");
            Console.WriteLine();
            Console.WriteLine(" Pulsa 0 para salir del programa");

            if (int.TryParse(Console.ReadLine(), out int respuesta))
            {
                if (respuesta == 0)
                    return false;
                else if (respuesta == 1)
                    Console.WriteLine(Traduccion(true));
                else if (respuesta == 2)
                    Console.WriteLine(Traduccion(false));
            }
            else
            {
                Console.WriteLine("No has introducido una opcion valida");
            }
            return true;
        }

        static string Traduccion(bool HaMorse)
        {
            string palabraDeEntrada;
            string palabraDeSalida = "";

            Console.WriteLine("Introduce el texto a traducir: ");
            palabraDeEntrada = Console.ReadLine().ToUpper();

            if (HaMorse)
            {
                foreach (char caracter in palabraDeEntrada)
                {
                    string morse;
                    if (morseCode.TryGetValue(caracter, out morse))
                    {
                        palabraDeSalida += morse + " ";
                    }
                }
            }
            else
            {
                string[] caracteres = palabraDeEntrada.Split();

                foreach (string caracter in caracteres)
                {
                    char morse;
                    if (morseToSpanish.TryGetValue(caracter, out morse))
                    {
                        palabraDeSalida += morse;
                    }
                }
            }

            return palabraDeSalida;
        }
    }
}
