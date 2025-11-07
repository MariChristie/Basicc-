namespace Aula06
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("===============Verificador de impar ou par===============");
            Console.Write("Digite um número inteiro: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = number % 2;

            if (result ==0 )
            {
                Console.WriteLine("O número digitado é par.");
            }
            else
            {
                Console.WriteLine("O número é impar");
            }


        }
    }
}