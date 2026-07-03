using System;
using System.IO;
using System.Reflection.Metadata;
using System.Threading.Channels;

namespace Primeiro
{
    class Program
    {
        static void Main()
        {
            //1. Estrutura
            string path = @"""\""";
            string fileName = "shooping_list.text";
            string filePath = path + fileName;

            List<string> shoopingList = new List<string>();

            //Lógica

            if (File.Exists(filePath))
            {
                shoopingList.AddRange(File.ReadLines(filePath));
            }

            while (true)
            {
                Console.WriteLine("\n=== Lista de Compras ===");
                Console.WriteLine("1, Adicionar item");
                Console.WriteLine("2. Remover item");
                Console.WriteLine("3. Exibir Lista");
                Console.WriteLine("4. Sair");
                Console.WriteLine("Escolha um numero para continuar:");

                String choiceUser = Console.ReadLine();

                switch (choiceUser)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do item para adicionar:");
                        string itemInsert = Console.ReadLine();


                        if (!string.IsNullOrEmpty(itemInsert))
                        {
                            shoopingList.Add(itemInsert);
                            Console.WriteLine($"Item'{itemInsert}' adicionado com sucesso!");
                        }

                        else
                        {
                            Console.WriteLine("O item nao pode ser vazio!");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Digite o nome do item para remover:");
                        string itemRemove = Console.ReadLine();

                        var test = (shoopingList.Remove(itemRemove));
                        if (shoopingList.Remove(itemRemove))
                        {
                            Console.WriteLine($"Item '{itemRemove}' removido com sucesso!");
                        }                       


                        break;

                    case "3":
                        Console.WriteLine("\n Itens na sua lista de Compras:");
                        if (shoopingList.Count == 0)
                        {
                            Console.WriteLine("Sua lista  está vazia.");
                        }
                        else
                        {
                            for (int i =0; i<shoopingList.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {shoopingList[i]}");
                            }                    
                        }
                    break;

                        case "4":
                             File.WriteAllLines(filePath, shoopingList);
                        Console.WriteLine("Lista salva! Saindo...");
                        return;

                    default:
                        Console.WriteLine("Opçao Invalida. Tente novamente");
                    break;


                }
            }

        }
    }

}






