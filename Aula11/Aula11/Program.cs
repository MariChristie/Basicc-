namespace Aula11;

public class Program
{
    public static void Main()
    {
        //bool boolValue = true;

        //switch (boolValue)
        //{
        //    case true:
        //        Console.WriteLine("O valor é true");
        //        break;

        //    case false:
        //        Console.WriteLine("O valor é false");
        //        break;
        //}

        Console.WriteLine("======Dia da Semana======");
        Console.WriteLine("Digite um número de 1 a 7:");
        int dayOfWeek = Convert.ToInt32(Console.ReadLine());

        switch (dayOfWeek)
        {
            case 1:
                Console.WriteLine("O dia da semana é Segunda-Feira");
                break;

            case 2:
                Console.WriteLine("O dia da semqana é Terça-Feira");
                break;
        }
    }
}