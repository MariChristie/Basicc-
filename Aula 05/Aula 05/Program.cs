namespace Aul05
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Aula 05 - Operadores Aritméticos");
            Console.WriteLine("Digite o número 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            int subctraction = number1 - number2;
            int multiplication = number1 * number2;
            int division = number1 / number2;
            int module = number1 % number2;

            Console.WriteLine("O valor da soma é: " + sum);
            Console.WriteLine("O valor da subtração é: " + subctraction);
            Console.WriteLine("O valor da soma é: " + multiplication);
        }
    }
    
 }