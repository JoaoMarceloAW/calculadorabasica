using System.Dynamic;

namespace calculadorabasica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ehparacontinuar = true;

            do
            {
                Console.Clear();
                Console.WriteLine("Calculadora Basica");


                Console.WriteLine();
                Console.WriteLine("Digite 1 para somar");
                Console.WriteLine("Digite 2 para subtrair");
                Console.WriteLine("Digite 3 para multiplicar");
                Console.WriteLine("Digita 4 para Dividir");
                Console.WriteLine("Digite S para sair!");
                string operacao = Console.ReadLine();
                if (operacao == "S")
                {
                    break;

                }


                if (operacao != "1" && operacao != "2 " && operacao != "3" && operacao != "4" && operacao != "S")
                {
                    Console.WriteLine("Essa operação não existe tente novamente....");
                    Console.ReadLine();
                    continue;

                }
                Console.WriteLine("Digite o primeiro valor");
                decimal valora = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor");
                decimal valorb = Convert.ToDecimal(Console.ReadLine());
                bool ehadicao = operacao == "1";
                bool ehsubtraçao = operacao == "2";
                bool ehmulti = operacao == "3";
                bool ehadivisao = operacao == "4";

                decimal resultado;

                if (ehadicao)
                {
                    resultado = valora + valorb;
                    Console.WriteLine("O valor da operação é: " + resultado);
                }
                if (ehsubtraçao)
                {
                    resultado = valorb - valorb;
                    Console.WriteLine("O valor da operação é: " + resultado);
                }
                if (ehmulti)
                {
                    resultado = valora * valorb;
                    Console.WriteLine("O valor da operação é: " + resultado);
                }
                if (ehadivisao)
                {
                    if (valorb == 0)
                    {
                        Console.WriteLine("O segundo valor não pode ser zero tente novamente:");
                        Console.ReadLine();
                    }
                    if (valorb != 0)
                    {
                        resultado = valora / valorb;
                        Console.WriteLine("O valor da operação é: " + resultado);
                    }
                }

                Console.ReadLine();
        } while (ehparacontinuar);
        }
    }
}
        
    