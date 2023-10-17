using bytebank;

internal class Program
{
    private static void Main(string[] args)
    {
        //ContaCorrente contadojuan = new ContaCorrente();
        //ContaCorrente contadajulia = new ContaCorrente();
        //contadajulia.titular = "julia cristina";
        //contadajulia.numero_agencia = 23;
        //contadajulia.conta = "1010-5";
        //contadajulia.saldo = 350;

        //ContaCorrente contadajulia2 = new ContaCorrente();
        //contadajulia2.titular = "julia cristina";
        //contadajulia2.numero_agencia = 23;
        //contadajulia2.conta = "1010-5";
        //contadajulia2.saldo = 350;

        //Console.WriteLine(contadajulia == contadajulia2);

        //contaDoJuan.titular = "Juan Prado";
        //contaDoJuan.numero_agencia = 18;
        //contaDoJuan.conta = "1010-X";
        //contaDoJuan.saldo = 100;

        //Console.WriteLine("Saldo da conta do Juan = " + contaDoJuan.saldo);

        //Console.WriteLine("Saldo da conta da Julia = " + contaDaJulia.saldo);


        //contaDoJuan.Depositar(100);
        //Console.WriteLine("Saldo da conta do Juan pós-depósito = " + contaDoJuan.saldo);

        //if(contaDoJuan.Sacar(300))
        //{
        //    Console.WriteLine("Saldo da conta do Juan depois do saque = " + contaDoJuan.saldo); 
        //}
        //else
        //{
        //    Console.WriteLine("Saldo insuficiente para saque.");
        //}

        //contaDoJuan.Transferir(50, contaDaJulia);

        //Console.WriteLine("Saldo da conta do Juan depois de transferir = " + contaDoJuan.saldo);

        //Console.WriteLine("Saldo da conta da Julia depois de receber transferencia = " + contaDaJulia.saldo);

        //ContaCorrente contaDoGael = new ContaCorrente();
        //Console.WriteLine(contaDoGael.titular);
        //Console.WriteLine(contaDoGael.saldo);
        //Console.WriteLine(contaDoGael.numero_agencia);
        //Console.WriteLine(contaDoGael.conta);

        //double valor = 300;
        //double valor2 = valor;

        //Console.WriteLine(valor == valor2);

        Cliente cliente = new Cliente();
        cliente.nome = "Juan Prado";
        cliente.cpf = "123.456.789-00";
        cliente.profissao = "Desenvolvedor";

        ContaCorrente conta = new ContaCorrente();
        conta.titular = cliente;
        conta.conta = "1010-X";
        conta.numero_agencia = 15;
        conta.saldo = 100;

        Console.WriteLine("Titular = " + conta.titular.nome);
        Console.WriteLine("CPF = " + conta.titular.cpf);
        Console.WriteLine("Profissão = " + conta.titular.profissao);
        Console.WriteLine("Nº Conta = " + conta.conta);
        Console.WriteLine("Saldo = " + conta.saldo);
        Console.WriteLine("Nº Agência = " + conta.numero_agencia);


    }
}