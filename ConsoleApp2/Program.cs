using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y, area, P;
            x = new Triangulo();
            y = new Triangulo();
            P = new Triangulo();
            area = new Triangulo();
            Console.Write("Por favor, insira o valor do lado A do triângulo X: ");
            x.A = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Por favor, insira o valor do lado B do triângulo X: ");
            x.B = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Por favor, insira o valor do lado C do triângulo X: ");
            x.C = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Por favor, insira o valor do lado A do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Por favor, insira o valor do lado B do triângulo Y: ");
            y.B = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Por favor, insira o valor do lado C do triângulo Y: ");
            y.C = double.Parse(Console.ReadLine());
            Console.Clear();
            Triangulo teste = new Triangulo();
            double areaX = teste.CalculoX(x.A, x.B, x.C);
            double areaY = teste.CalculoY(y.A, y.B, y.C);
            Console.WriteLine($"Área de X: {Math.Round(Math.Sqrt(areaX), 4)}");
            Console.WriteLine($"Área de Y: {Math.Round(Math.Sqrt(areaY), 4)}");
            if ((Math.Sqrt(areaX)) > (Math.Sqrt(areaY)))
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Idade();
            Salario();

        }
        static void Idade()
        {
            Pessoa A = new Pessoa();
            Pessoa B = new Pessoa();

            Console.Write("Por favor, informe o seu nome: ");
            A.nome = Convert.ToString(Console.ReadLine());
            Console.Write("Por favor, informe a sua idade: ");
            A.idade = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Por favor, informe o seu nome: ");
            B.nome = Convert.ToString(Console.ReadLine());
            Console.Write("Por favor, informe a sua idade: ");
            B.idade = int.Parse(Console.ReadLine());
            Console.Clear();
            Pessoa calculo = new Pessoa();
            String V = calculo.MaisVelho(A.idade, B.idade, A.nome, B.nome);
            Console.WriteLine($"A pessoa mais velha é: {V}");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        static void Salario()
        {
            Salario A, B, Media;
            A = new Salario();
            B = new Salario();
            Media = new Salario();
            A.dados = "Dados do primeiro funcionário";
            B.dados = "Dados do segundo funcionário";
            Console.WriteLine(A.dados);
            Console.WriteLine("");
            Console.Write("Por favor, informe o seu nome: ");
            A.nome = Convert.ToString(Console.ReadLine());
            Console.Write("Por favor, informe o seu salário: ");
            A.salario = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(B.dados);
            Console.WriteLine("");
            Console.Write("Por favor, informe o seu nome: ");
            B.nome = Convert.ToString(Console.ReadLine());
            Console.Write("Por favor, informe o seu salário: ");
            B.salario = double.Parse(Console.ReadLine());
            Console.Clear();
            Salario media = new Salario();
            
            double resultado = media.MediaSalario(A.salario, B.salario);
            Console.WriteLine($"A média de salários é: {resultado}");

        }
    }
}
