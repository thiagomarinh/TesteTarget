using System;

namespace target
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //fibonacci();
            //percentual();
            inverter();
        }

        //Questão 2 Fibonacci
        private static void fibonacci()
        {
            int j = 1;
            int x = 0;
            int soma;
            Console.WriteLine("Digite um numero para saber se está na sequencia de fibonacci: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 1000; i++)
            {
                soma = x + j;
                j = x;
                x = soma;
                if (soma == n)
                {
                    Console.WriteLine($"O numero {n} contem na sequencia!!!");
                }
                else
                {
                    Console.WriteLine($"O numero {n} não contem na sequencia");
                }
            }
        }
        //Questão 4
        //Como queremos apenas a procentagem preferi usar os valores como inteiros
        public static void percentual()
        {
            int sp = 6783643;
            int rj = 3667866;
            int mg = 2922988;
            int es = 2716548;
            int outros = 1984953;

            int total = sp + rj + mg + es + outros;

            int percentualsp = (sp * 100) / total;
            int percentualrj = (rj * 100) / total;
            int percentualmg = (mg * 100) / total;
            int percentuales = (es * 100) / total;
            int percentualoutros = (outros * 100) / total;

            Console.WriteLine($"O Percentual do estado de SP {percentualsp} %");
            Console.WriteLine($"O Percentual do estado de RJ {percentualrj} %");
            Console.WriteLine($"O Percentual do estado de MG {percentualmg} %");
            Console.WriteLine($"O Percentual do estado de ES {percentuales} %");
            Console.WriteLine($"O Percentual dos outros estados {percentualoutros} %");
        }
        //Questão 05
        //Usei uma variavel para armazenar o valor da letra que seria invertida
        public static void inverter()
        {
            string texto = "oi";
            char[] textoArray = texto.ToCharArray();
            char n = textoArray[0];
            textoArray[0] = textoArray[1];
            textoArray[1] = n;
            Console.WriteLine(textoArray);


        }
    }
}