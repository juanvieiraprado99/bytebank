using bytebank;

internal class Program
{
    private static void Main(string[] args)
    {
        ContaCorrente contaDoJuan = new ContaCorrente();
        ContaCorrente contaDaJulia = new ContaCorrente();
        contaDaJulia.titular = "Julia Cristina";
        contaDaJulia.numero_agencia = 23;
        contaDaJulia.conta = "1010-5";
        contaDaJulia.saldo = 350;

        contaDoJuan.titular = "Juan Prado";
        contaDoJuan.numero_agencia = 18;
        contaDoJuan.conta = "1010-X";
        contaDoJuan.saldo = 100;

        Console.WriteLine("Saldo da conta do Juan = " + contaDoJuan.saldo);

        Console.WriteLine("Saldo da conta da Julia = " + contaDaJulia.saldo);


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

        contaDoJuan.Transferir(50, contaDaJulia);

        Console.WriteLine("Saldo da conta do Juan depois de transferir = " + contaDoJuan.saldo);

        Console.WriteLine("Saldo da conta da Julia depois de receber transferencia = " + contaDaJulia.saldo);

        ContaCorrente contaDoGael = new ContaCorrente();
        Console.WriteLine(contaDoGael.titular);
        Console.WriteLine(contaDoGael.saldo);
        Console.WriteLine(contaDoGael.numero_agencia);
        Console.WriteLine(contaDoGael.conta);
    }
}