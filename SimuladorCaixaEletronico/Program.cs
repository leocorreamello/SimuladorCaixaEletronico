using System;

namespace SimuladorCaixaEletronico
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = "userData.txt";

            Console.WriteLine($"************************\n" +
                              $"* Caixa Eletronico 24h *\n" +
                              $"************************");

            while (true)
            {
                Console.WriteLine($"\nEscolha uma opção:" + 
                                  $"\n1. Entrar\n" +
                                  $"2. Criar conta\n" +
                                  $"3. Sair\n");

                Console.Write("---> ");

                string escolhaUser = Console.ReadLine();
                int escolhaUserInt = Convert.ToInt32(escolhaUser);

                if (escolhaUserInt < 1 || escolhaUserInt > 3)
                {
                    Console.WriteLine($"Alternativa Invalida!\n" +
                                      $"Tente-Novamente!\n");
                }
                else if (escolhaUserInt == 1)
                {
                    Console.WriteLine("\n* Login *\n");

                    Console.Write("Id da conta: ");
                    string idUser = Console.ReadLine();

                    Console.Write("Senha: ");
                    string senhaUser = Console.ReadLine();

                    int idUserInt = Convert.ToInt32(idUser);
                    int senhaUserInt = Convert.ToInt32(senhaUser);

                    Conta user = Conta.LoadFromFile(filePath);

                    if (user != null && idUserInt == user.Id && senhaUserInt == user.Senha)
                    {
                        Console.WriteLine("Login realizado com sucesso!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Id ou Senha incorreta!");
                    }
                }
                else if (escolhaUserInt == 2)
                {
                    Console.WriteLine("\n* Criação de contas *\n");

                    Console.Write("Nome: ");
                    string nameUser = Console.ReadLine();

                    Console.Write("Id da conta: ");
                    string idUser = Console.ReadLine();

                    Console.Write("Senha: ");
                    string senhaUser = Console.ReadLine();

                    int idUserInt = Convert.ToInt32(idUser);
                    int senhaUserInt = Convert.ToInt32(senhaUser);

                    Conta user = new Conta
                    {
                        Name = nameUser,
                        Id = idUserInt,
                        Senha = senhaUserInt
                    };

                    user.SaveToFile(filePath);
                    Console.WriteLine("Conta criada com sucesso!");
                }
                else if (escolhaUserInt == 3)
                {
                    Console.WriteLine("Encerrando a aplicação...");
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("\n* Menu Principal *\n");

            Console.WriteLine($"Olá, {Conta.LoadFromFile(filePath).Name}!\n");
           
            while (true){
                Console.WriteLine($"\nEscolha uma opção:\n" +
                              $"1. Consultar saldo\n" +
                              $"2. Depositar\n" +
                              $"3. Sacar\n" +
                              $"4. Transferir\n" +
                              $"5. Sair\n");

                Console.Write("---> ");

                string escolhaUser = Console.ReadLine();
                int escolhaUserInt = Convert.ToInt32(escolhaUser);

                if (escolhaUserInt < 1 || escolhaUserInt > 5)
                {
                    Console.WriteLine($"Alternativa Invalida!\n" +
                                      $"Tente-Novamente!\n");
                }
                else if (escolhaUserInt == 1)
                {
                    Console.WriteLine($"\nSeu saldo é: R${Conta.LoadFromFile(filePath).Saldo}");
                }
                else if (escolhaUserInt == 2)
                {
                    
                }
                else if (escolhaUserInt == 3)
                {

                }
                else if (escolhaUserInt == 4)
                {

                }
                else if (escolhaUserInt == 5)
                {
                    Console.WriteLine("Encerrando a aplicação...");
                    Environment.Exit(0);
                }
            }

            Console.ReadLine();
        }
    }
}
