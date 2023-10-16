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

        contaDoJuan.saldo = 200;
        Console.WriteLine("Saldo da conta do Juan = " + contaDoJuan.saldo);
    }
}