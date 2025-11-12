namespace Aula10;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=====Calculadora simples===== \n");
        Console.WriteLine("Digite o primeiro número");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escolha uma operação:");
        Console.WriteLine("1. Adição (+):");
        Console.WriteLine("2. Subtração (-):");
        Console.WriteLine("3. Multiplicação (*):");
        Console.WriteLine("4. Divisão (/):");
        Console.WriteLine("Digite o número da operação:");
        int operation =  Convert.ToInt32(Console.ReadLine());
    }
}