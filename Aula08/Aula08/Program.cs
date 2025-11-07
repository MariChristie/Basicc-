namespace Aula08
{
    public class Program()
    {
        public static void Main()
        {
            Console.WriteLine("======Operadores relacionais====");
            Console.WriteLine("Digite o primeiro número");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int y = Convert.ToInt32(Console.ReadLine());

            string result;

            //Operador de igualdade (==)

            if (true)
            {
                result = "x é igual a y";
            }
            else
            {
                result = "x é diferente de y";
            }
            Console.WriteLine("\nIgualdade (==): " + result);

            //Operador de Diferenças (!=)
            if (x != y)
            {
                result = "x é diferente de y";
            }
            else
            {
                result = "x é igual a y";
            }
            Console.WriteLine("\nDiferença (!=): " + result);

            //Operador maior que (>)
            if (x > y)
            {
                result = "x é maior que y";
            }
            else
            {
                result = "x não é maior que y";
            }
            Console.WriteLine("\nMaior que (>): " + result);

            //Operador Menor que (<)
            if (x < y)
            {
                result = "x é menor que y";
            }
            else
            {
                result = "x não é menor que y";
            }
            Console.WriteLine("\nMenor que (<): " + result);

            //Operador Maior ou igual a (>=)
            if (x >= y)
            {
                result = "x é maior ou igual a y";
            }
            else
            {
                result = "x não é maior ou igual a y";
            }
            Console.WriteLine("\nMaior ou igual a (>=): " + result);

            //Operador Menor ou igual a (<=)
            if (x <= y)
            {
                result = "x é menor ou igual a y";
            }
            else
            {
                result = "x não é menor ou igual a y";
            }
            Console.WriteLine("\nMenor ou igual a (<=): " + result);
        }
    }
}