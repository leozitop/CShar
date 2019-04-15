using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao TsukaBank");

            ContaCorrente conta1 = new ContaCorrente();//novo objeto do tipo ContaCorrente
            System.Console.WriteLine("Digite o nome do titular");
            conta1.titular = Console.ReadLine();
            Console.WriteLine("Digite o número da Agência");
            conta1.agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número da conta");
            conta1.numeroConta = int.Parse(Console.ReadLine());
            conta1.Depositar(1000);
            // System.Console.WriteLine($"Quanto você quer sacar {conta1.titular}?");
            // double valor = double.Parse(Console.ReadLine());
            // bool resultado = conta1.Sacar(valor);

            ContaCorrente conta2 = new ContaCorrente();
            Console.WriteLine("Digite o nome do titular");
            conta2.titular = Console.ReadLine();
            Console.WriteLine("Digite o número Agência");
            conta2.agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número da conta");
            conta2.agencia = int.Parse(Console.ReadLine());
            conta2.Depositar(3000);
            // System.Console.WriteLine($"Quanto você quer sacar {conta2.titular}?");
            // double valor2 = double.Parse(Console.ReadLine());
            // bool resultado2 = conta2.Sacar(valor); 

            Console.WriteLine($"--------------------------------");
            Console.WriteLine($"Titular {conta1.titular}");
            Console.WriteLine($"Agência {conta1.agencia}");
            Console.WriteLine($"Numero da conta {conta1.numeroConta}");
            Console.WriteLine($"Saldo {conta1.saldo}");
            Console.WriteLine($"--------------------------------");

            Console.WriteLine($"--------------------------------");
            Console.WriteLine($"Titular {conta2.titular}");
            Console.WriteLine($"Agência {conta2.agencia}");
            Console.WriteLine($"Numero da conta {conta2.numeroConta}");
            Console.WriteLine($"Saldo {conta2.saldo}");
            Console.WriteLine($"--------------------------------");
            
            bool resultadoTransferencia = true;
            do{
                Console.WriteLine($"Quanto deseja transferir da conta1 para a conta2");
                double valorTransferencia = double.Parse(Console.ReadLine());
                resultadoTransferencia = conta1.Transferir(valorTransferencia, conta2);
            } while (resultadoTransferencia != true);

            Console.WriteLine("-------Resultado Após Transferência-------");
            Console.WriteLine($"Saldo conta1: {conta1.saldo}");
            Console.WriteLine($"Saldo conta2: {conta2.saldo}");
        }

    }

}
