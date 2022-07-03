using System.Security.AccessControl;
using System.Collections.Concurrent;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Reflection.Emit;
using System.Data;
// See https://aka.ms/new-console-template for more information
using System;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o primeiro valor");
            double v2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da operação:1- Soma/2- divisao/3- multiplicacao/4- subtracao/5- sair");
            string operacao = Console.ReadLine();
            switch (operacao) {
            case "1":Soma(v1,v2);break;
            case "2":Divisao(v1,v2);break;
            case "3":Multiplicacao(v1,v2);break;
            case "4":Subtracao(v1,v2);break;
            case "5":Sair();break;
            default :Console.WriteLine("Não existe essa operação!");break;
           }
        }
        static void Soma(double valor1, double valor2)
        {
            var resultado = valor1 + valor2;
            Console.WriteLine(resultado);
            
        }
        static void Divisao(double valor1, double valor2)
        {
            var resultado = valor1 / valor2;
            Console.WriteLine(resultado);
        }
        static void Multiplicacao(double valor1, double valor2)
        {
            var resultado = valor1 * valor2;
            Console.WriteLine(resultado);
        }
        static void Subtracao(double valor1, double valor2)
        {
            var resultado = valor1 - valor2;
            Console.WriteLine(resultado);
        }
        static void Sair()
        {
            Console.WriteLine("Obrigado por utilizar!");
            System.Environment.Exit(0);
        }
    }
}