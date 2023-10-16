using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08
{
    class Program
    {
       public static int v1;
       public static int v2;
       public static int soma;
       public static int sub;
       public static int div;
       public static int mult;

        static void Somar()
        {
            Console.WriteLine("Digite um valor: ");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro valor: ");
            v2 = Convert.ToInt32(Console.ReadLine());
            soma = v1 + v2;
            Console.WriteLine("A soma dos valores é: {0}", soma);
        }

        static void Subtrair()
        {
            Console.WriteLine("Digite um valor: ");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro valor: ");
            v2 = Convert.ToInt32(Console.ReadLine());
            sub = v1 - v2;
            Console.WriteLine("A subtração dos valores é: {0}", sub);
        }

        static void Multiplicar()
        {
            Console.WriteLine("Digite um valor: ");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro valor: ");
            v2 = Convert.ToInt32(Console.ReadLine());
            mult = v1 * v2;
            Console.WriteLine("A multiplicação dos valores é: {0}", mult);
        }

        static void Dividir()
        {
            Console.WriteLine("Digite um valor: ");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro valor: ");
            v2 = Convert.ToInt32(Console.ReadLine());
            div = v1 / v2;
            Console.WriteLine("A divisão dos valores é: {0}", div);
        }

        static void mostrarOpcaoInvalida()
        {
            Console.WriteLine("Digite uma Opção válida");
        }

        static void Main(string[] args)
        {
           
            int opcao = 0;

            do
            {
                Console.WriteLine("Digite uma Opção");
                Console.WriteLine("[ 1 ] - Somar");
                Console.WriteLine("[ 2 ] - Subtrair");
                Console.WriteLine("[ 3 ] - Multiplicar");
                Console.WriteLine("[ 4 ] - Dividir");
                Console.WriteLine("[ 0 ] - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Somar();                     
                        break;
                    case 2:
                        Subtrair();                       
                        break;
                    case 3:
                        Multiplicar();                       
                        break;
                    case 4:
                        Dividir();                        
                        break;
                    case 5:
                    default:
                        mostrarOpcaoInvalida();
                        break;
                }
            } while (opcao != 0);
        }
    }
}