using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mete una frase: ");
            char[] frase = Console.ReadLine().ToCharArray();
            int num = contarVocales(frase);
            Console.WriteLine("El numero de vocales es \n" + num);
            Console.ReadKey();

            primeraParteB();

            Console.WriteLine("==================Segunda parte===================\n");

            votacion();
            
        }

        static bool esVocal (char x)
        {
            char[] vocales = "aeiouAEIOUáéíóú".ToCharArray();
            int i = 0;
            while (i < vocales.Length)
            {
                if (vocales[i] == x) return true;
                i++;
            }
            return false;
        }

        static  int contarVocales (char[] f)
        {
            int contador = 0;
            int i = 0;
            while (i<f.Length)
            {
                if (esVocal(f[i])) 
                {
                    contador++;
                }
                i++;
            }
            return contador;
        }

        static void primeraParteB()
        {

            string frase;
            frase = "mi mama m$ mima\n";
            char[] texto = frase.ToCharArray();
            int num = 0;
            int i = 0;
            while (frase[i] == ' ') i++;

            if (frase[i] == '$') num--;

            while (frase[i] != '$')
            {
                if (frase[i] == ' ')
                {
                    num++;
                    while (frase[i] == ' ') i++;
                    if (frase[i] == '$') num--;
                }
                else i++;
            }
            num++;
            Console.WriteLine($"{frase}");
            Console.WriteLine($"la frase tiene {num} palabras\n");

            Console.ReadKey();
        }
        
        static void votacion()
        {
            int v1 = 0;
            int v2 = 0;
            int v3 = 0;
            int voto = 0, total;

            Console.WriteLine("{1}Mateo {2}Juan {3}Salir\n");

            do
            {
                Console.WriteLine("Seleccione el candidato: \n");
                voto = int.Parse(Console.ReadLine());

                if (voto == 1)
                {
                    v1 = v1 + 1;
                }

                else if (voto == 2)
                {
                    v2 = v2 + 1;
                }

                else if (voto > 4)
                {
                    v3 = v3 + 1;
                }


            } while (voto != 3);

            Console.ReadKey();

            total = v1 + v2 + v3;

            Console.WriteLine($"Mateo tiene: {v1} \n");
            Console.WriteLine($"Juan tiene: {v2} \n");
            Console.WriteLine($"Total de votos nulos: {v3} \n");
            Console.WriteLine($"Los totales de votos fueron: {total} \n");

            if (v1 > v2)
            {
                Console.WriteLine("Mateo es el ganador\n");


            }

            if (v2 > v1)
            {
                Console.WriteLine("Juan es el ganador \n");
            }

            if (v1 == v2)
            {
                Console.WriteLine("Hubo un empate \n");
            }

            Console.ReadLine();

        }

    }
}
