using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoscsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            double[] peso = new double[5];
            double[] altura = new double[5];
            int i = 0;
            int j = 0;
            int k = 0;
            double[] imc = new double[5];
            for (j = 0; j <= 4; j++)
            {

                Console.WriteLine("Digite o nome do candidato:");
                nome[i] = Console.ReadLine();

                Console.WriteLine("Digite o peso do candidato: ");
                peso[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a altura do candidato");
                altura[i] = double.Parse(Console.ReadLine());

                imc[i] = peso[i] / (altura[i] * altura[i]);

                if (imc[i] < 16)
                {
                    Console.WriteLine("O candidato esta com "+imc[i]+ " magresa grave");
                }
                else if (imc[i] >= 16 && imc[i] < 16.9)
                {
                    Console.WriteLine("O candidato esta com MAGRESA MODERADA");
                }

                else if (imc[i] >= 17 && imc[i] < 18.5)
                {
                    Console.WriteLine("O candidato esta com MAGRESA LEVE");
                }

                else if (imc[i] >= 18.6 && imc[i] < 24.9)
                {
                    Console.WriteLine("O candidato esta com PESO IDEAL");
                }

                else if (imc[i] >=25 && imc[i] < 29.9)
                {
                    Console.WriteLine("O candidato esta com SOBREPESO");
                    k++;
                }
                else if (imc[i] >= 30)
                {
                    Console.WriteLine("O candidato esta com OBESIDADE I");
                    k++;
                }
           
               
                    if (imc[i] > 25)
                {
                    Console.WriteLine("Procure tratamento "+(k/5).ToString("P"));
                }
            } 
                 for (i = 0; i <= 4; i++)
                {
                    Console.WriteLine("O candidato " + nome[i] + " esta com IMC igual a" + imc[i]);
                }
            
            Console.ReadKey();








        }
    }
}
