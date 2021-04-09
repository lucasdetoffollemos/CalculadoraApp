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
                Console.WriteLine("Calculadora ");

                Console.WriteLine("Digite 1 para somar: ");
                Console.WriteLine("Digite 2 para subtrair: ");
                Console.WriteLine("Digite 3 para multiplicar: ");
                Console.WriteLine("Digite 4 para dividir: ");
                Console.WriteLine("Digite 5 para ver as operações: ");
                Console.WriteLine("Digite S para sair: ");

                opcao = Console.ReadLine();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "s" && opcao != "S" && opcao != "5")
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

               if(opcao == "5")
                {

                    if(cont == 0)
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

                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }   
        

                Console.WriteLine("Digite um número: ");

                double primeiroNumero = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");

                double segundoNumero = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                string simboloOperacao = "";
                
                switch (opcao)
                {
                    case "1": resultado = primeiroNumero + segundoNumero;
                        simboloOperacao = "+"; 
                        break;
                    case "2": resultado = primeiroNumero - segundoNumero;
                        simboloOperacao = "-";
                        break;
                    case "3": resultado = primeiroNumero * segundoNumero;
                        simboloOperacao = "*";
                        break;
                    case "4": 
                        if(segundoNumero != 0)
                        {
                            resultado = primeiroNumero / segundoNumero;
                            simboloOperacao = "/";
                        }
                        else
                        {
                            Console.WriteLine("Não é possível dividir um número por zero.");
                            continue;
                        }
                        
                        break;
                    
                    default: break;

                }

                Console.WriteLine("Resultado: " + resultado);

                arrayOperacoes[cont] = primeiroNumero + " " + simboloOperacao + " " + segundoNumero + " = " + resultado;
                cont++;

                Console.ReadLine();
                Console.Clear();

            }
        }
    }
}
