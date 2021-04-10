using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraApp2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            string[] arrayOperacoes = new string[100];
            int cont = 0;
            while (true)
            {

                MostraMenu();

                opcao = Console.ReadLine();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if (VerificaOpcaoInvalida(opcao))
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

               if(opcao == "5")
                {

                    MostraOperacoes(cont, arrayOperacoes);

                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                double primeiroNumero = 0, segundoNumero = 0;

                Console.WriteLine("Digite o primiero numero número: ");

                primeiroNumero = Convert.ToDouble(Console.ReadLine());

                if (opcao == "4")
                {
                    segundoNumero = verficaDivisor0(segundoNumero);
                }
                else
                {
                    Console.WriteLine("Digite o segundo número: ");
                    segundoNumero = Convert.ToDouble(Console.ReadLine());
                }

                string simboloOperacao = geraSimbolo(opcao);

                double resultado = realizaOperacoes(opcao, primeiroNumero, segundoNumero);

                Console.WriteLine("Resultado: " + resultado);

                arrayOperacoes[cont] = primeiroNumero + " " + simboloOperacao + " " + segundoNumero + " = " + resultado;
                cont++;

                Console.ReadLine();
                Console.Clear();

            }
        }


        public static void MostraMenu()
        {
            Console.WriteLine("Calculadora ");

            Console.WriteLine("Digite 1 para somar: ");
            Console.WriteLine("Digite 2 para subtrair: ");
            Console.WriteLine("Digite 3 para multiplicar: ");
            Console.WriteLine("Digite 4 para dividir: ");
            Console.WriteLine("Digite 5 para ver as operações: ");
            Console.WriteLine("Digite S para sair: ");

            
        }

        public static bool VerificaOpcaoInvalida(string opcao) 
        {

            bool opcaoInvalida = opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "s" && opcao != "S" && opcao != "5";

            return opcaoInvalida;
        }

        public static void MostraOperacoes(int cont, string[] arrayOperacoes)
        {
            if (cont == 0)
            {
                Console.WriteLine("Nehuma operção foi realizada.");

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Operações: ");
                for (int i = 0; i < arrayOperacoes.Length; i++)
                {
                    if (arrayOperacoes[i] != null)
                        Console.WriteLine(arrayOperacoes[i]);
                }

            }

        }

        public static double realizaOperacoes(string op, double primeiroNumero, double segundoNumero)
        {
            double resultado = 0;
            switch (op)
            {
                case "1":
                    resultado = primeiroNumero + segundoNumero;
                  
                    break;
                case "2":
                    resultado = primeiroNumero - segundoNumero;
                    
                    break;
                case "3":
                    resultado = primeiroNumero * segundoNumero;
                   
                    break;
                case "4":
                    resultado = primeiroNumero / segundoNumero;
                   
                    break;

                default: break;

            }
            return resultado;
        }

        public static string geraSimbolo(string opcao)
        {
            string simbolo = " ";
            switch (opcao)
            {
                case "1": simbolo = "+"; break;
                case "2": simbolo = "-"; break;
                case "3": simbolo = "*"; break;
                case "4": simbolo = "/"; break;
                default: break;
            }


            return simbolo;
        }

        public static double verficaDivisor0(double segundoNumero)
        {
            int contador = 0;
            do
            {
                if (contador >= 1)
                {
                    Console.WriteLine("Número zero não é possivel, tente novamente.");
                }
                Console.WriteLine("Digite o segundo número: ");
                segundoNumero = Convert.ToDouble(Console.ReadLine());

                Console.Clear();
                contador++;

            }
            while (segundoNumero == 0);

            return segundoNumero;
        }
            

            

    }
}
