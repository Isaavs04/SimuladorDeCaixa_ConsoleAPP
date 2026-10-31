using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo = 852.50, deposito, saque;
            int escolha;
            string choice = "N";
            Console.Write("Programa que simula um caixa");
            do
            {
                Console.Write("\n1 - Ver saldo\n2- Depositar\n3- Sacar\n4- Sair\nDigite a opcao desejada:  ");
                escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Write("Saldo em conta: " + saldo.ToString("C2"));
                        Console.ResetColor();
                        break;
                    case 2:
                        Console.Write("Digite o valor do deposito:  ");
                        deposito = double.Parse(Console.ReadLine());
                        if (deposito > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            saldo = saldo + deposito;
                            Console.Write("Deposito no valor de "+ deposito.ToString("C2") + " realizado");
                            Console.ResetColor();   
                        }
                        else if (deposito == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Nao e possivel depositar 0 reais");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Nao e possivel depositar valores negativos");
                            Console.ResetColor();
                        }
                        break;
                    case 3:
                        Console.Write("Digite o valor do seu saque:  ");
                        saque = double.Parse(Console.ReadLine());
                        if (saque <= saldo && saque > 0)
                        {
                            saldo = saldo - saque;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Saque no valor de " + saque.ToString("C2") + " realizado");
                            Console.ResetColor();
                        }
                        else if(saque < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Nao e possivel sacar valor negativo");
                            Console.ResetColor();
                        }
                        else if (saque > saldo)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Nao e possivel sacar valor maior que o da conta");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Nao e possivel sacar 0");
                            Console.ResetColor();
                        }
                        break;
                    case 4:
                        Console.Write("Saindo do aplicativo");
                        break;
                    default:
                        Console.Write("Operaçao nao reconhecida");
                        break;
                }
                if (escolha != 4)
                {
                    do
                    {
                        if (escolha != 4)
                        {
                            Console.Write("\nDigite S para tentar novamente e N para encerrar:   ");
                            choice = Console.ReadLine().ToUpper();
                            if (choice != "S" && choice != "N")
                            {
                                Console.Write("Resposta inválida");
                            }
                        }
                        else
                        {
                            Console.Write("Saindo do aplicativo");
                            choice = "N";
                        }
                        
                    } while (choice != "S" && choice != "N");
                }
                Console.Clear();
            } while (choice == "S");
            Console.ReadKey();
        }
    }
}
