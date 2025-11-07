namespace Aula04;

public class Porgram
{
    public static void Main()
    {
        Console.WriteLine("Digite seu Nome ");
        string name = Console.ReadLine();

        Console.WriteLine("Digite sua idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("-----------------------------");

        Console.WriteLine("Nome do Usuário: " + name);
        Console.WriteLine("Idade do Usuário: " + age);
    }
}