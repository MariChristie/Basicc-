using System;

namespace Aula09;

public class Program
{ 
    public static void Main()
    {
        Console.WriteLine("=========Operadores lógicos");

        bool isLogged = true;
        bool hasAdminAcess = false;

        Console.WriteLine("\nInformações do Usuário");
        Console.WriteLine("Usuário logado: " + isLogged);
        Console.WriteLine("Acesso ao painel administrador: " + hasAdminAcess);

        Console.WriteLine("\nPermissões");

        if (isLogged || hasAdminAcess)
        {
            Console.WriteLine("Acesso permitido ao sistema");
        }
        else
        {
            Console.WriteLine("Acesso negado ao sistema");
        }

        if (isLogged && hasAdminAcess)
        {
            Console.WriteLine("Acesso permitido ao painel administrador");
        }
        else
        {
            Console.WriteLine("Acesso negado ao painel administrador");
        }

        if (isLogged == false)
        {    
            Console.WriteLine("Usuário não está logado");
        }
        else        
        {
            Console.WriteLine("Usuário está logado");
        }
    }
}