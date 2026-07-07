
namespace Primeiro
{
    public class BankOperations
    {
        decimal balance = 1000;
        public void CheckBalance()
        {
            Console.WriteLine($"Seu saldo e de R${balance}");
        }

        public void Deposit()
        {
            Console.WriteLine("informe o valor a ser depositado: R$");

            if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)

            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Valor invalido. Tente novamente.");
            }
        }

        public void Witdraw()
        {
            Console.WriteLine("informe o valor a ser retirado: R$");

            if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
            {
                if (amount <= balance)
                {
                    balance = balance - amount;
                    Console.WriteLine($"Valor de  R${amount} retirado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Saldo Invalido.");
                }
            }
            else
            {
                Console.WriteLine("Valor invalido. tente novamente.");
            }


        }
    }
}


       