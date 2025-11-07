namespace Aula07;

public class Program
{ 
    public static void Main()
    {
        Console.Write("=====Operadores de Atribuição======");

        //inicializar a variável
        int x = 10;
        Console.WriteLine("Valor inicial da Variável de x: " + x);

        //Operador de atribuição simples (=)

        x = 20;
        Console.WriteLine("\nAtribuição Simples (=)");
        Console.WriteLine("Novo valor de x" + x);

        //Atribuição composta (-=)
        x -= 10;

        Console.WriteLine("\nAtribuição composta (++)");
        Console.WriteLine("Novo valor de x: (++) \n" + x);
    }
}