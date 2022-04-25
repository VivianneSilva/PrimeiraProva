using System;

namespace ProvaFarmacia
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Remedios[] todosRemedios = RemediosRepository.InitializeRemedios();

           

            string resposta = "S";
            while (resposta == "S")
            {

               
                Console.Write("Digite o nome do remedio: ");
                string busca = Console.ReadLine().TrimStart().ToUpper();
                Remedios[] remedios = encontrarRemedios(todosRemedios, busca);

                if (remedios.Length > 0)

                {
                    foreach (Remedios rem in remedios)
                    {
                        Console.WriteLine($"Remedio disponivel: {rem.nome}");
                        Console.WriteLine($"Itens localizados: {remedios.Length.ToString()}");
                        Console.WriteLine($"Total de itens na lista: {todosRemedios.Length.ToString()}");
                        
                    }
                }
                else
                {
                    Console.WriteLine($"Remedio não encontrado {busca}");
                    
                }
                Console.WriteLine("Deseja fazer uma nova busca? (s/n)");
                resposta = Console.ReadLine().TrimStart().ToUpper();

            }

         
        }
        public static Remedios[] encontrarRemedios(Remedios[] remedios, string busca)
        {
            return Array.FindAll(remedios, remedio => remedio.nome == busca || remedio.nome.Contains(busca));
        }
    }
}
