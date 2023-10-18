using bytebank.Contas;
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

        //Cliente cliente = new Cliente();
        //cliente.nome = "Juan Prado";
        //cliente.cpf = "123.456.789-00";
        //cliente.profissao = "Desenvolvedor";

        //ContaCorrente conta = new ContaCorrente();
        //conta.titular = cliente;
        //conta.conta = "1010-X";
        //conta.numero_agencia = 15;
        //conta.saldo = 100;

        //Console.WriteLine("Titular = " + conta.titular.nome);
        //Console.WriteLine("CPF = " + conta.titular.cpf);
        //Console.WriteLine("Profissão = " + conta.titular.profissao);
        //Console.WriteLine("Nº Conta = " + conta.conta);
        //Console.WriteLine("Saldo = " + conta.saldo);
        //Console.WriteLine("Nº Agência = " + conta.numero_agencia);

        //ContaCorrente conta2 = new ContaCorrente();
        //conta2.titular = new Cliente();
        //conta2.titular.nome = "Julia Cristina";
        //conta2.titular.profissao = "Mãe";
        //conta2.titular.cpf = "987654321";
        //conta2.conta = "9999-X";
        //conta2.numero_agencia = 18;
        //conta2.saldo = 100;

        //Console.WriteLine(conta2.titular.nome);

        //ContaCorrente conta2 = new ContaCorrente();
        //conta2.Numero_Agencia = 18;
        //conta2.Conta = "1911-H";
        //conta2.SetSaldo(10);
        //Console.WriteLine(conta2.GetSaldo());
        //Console.WriteLine(conta2.Numero_Agencia);
        //Console.WriteLine(conta2.Conta);

        //ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
        //conta4.SetSaldo(500);
        //conta4.Titular = new Cliente();

        //Console.WriteLine(conta4.GetSaldo());
        //Console.WriteLine(conta4.Numero_Agencia);

        ContaCorrente conta5 = new ContaCorrente(199, "1234-X");
        Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
        ContaCorrente conta6 = new ContaCorrente(200, "5678-X");
        Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
        ContaCorrente conta7 = new ContaCorrente(201, "5678-X");
        Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

    }
}