using System;

namespace helloword
{
    class Program
    {
        static void Main(string[] args)
        {
            String nomeFilme,sala,hora,data;
            
                Console.WriteLine("Insira do nome do filme");
            nomeFilme = Console.ReadLine();
            Console.WriteLine(" Insira a sala ");
            sala = Console.ReadLine();
            Console.WriteLine("Hora");
            hora = Console.ReadLine();
            Console.WriteLine("Data");
            data = Console.ReadLine();

            Console.WriteLine("Seu nome para o filme {0}, Sala {1}, Hora {2}, Data {3}",nomeFilme,sala,hora,data);



        }
    }
}
