using bytebank;

internal class Program
{
    private static void Main(string[] args)
    {
        ContaCorrente contaDoJuan = new ContaCorrente();
        contaDoJuan.titular = "Juan Prado";
        contaDoJuan.numero_agencia = 18;
        contaDoJuan.conta = "1010-X";
        contaDoJuan.saldo = 100;

        Console.WriteLine("Saldo da conta do Juan = " + contaDoJuan.saldo);

        contaDoJuan.Depositar(100);
        Console.WriteLine("Saldo da conta do Juan pós-depósito = " + contaDoJuan.saldo);

        if(contaDoJuan.Sacar(300))
        {
            Console.WriteLine("Saldo da conta do Juan depois do saque = " + contaDoJuan.saldo); 
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para saque.");
        }

    }
}