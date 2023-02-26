using bytebank;


// Conta do André
ContaCorrente contaDoAndre = new ContaCorrente();

contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;

Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);

// Conta da Maria
ContaCorrente contaDaMaria = new ContaCorrente();

contaDaMaria.titular = "Maria Souza";
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 350;

Console.WriteLine("Saldo da conta do André = " + contaDaMaria.saldo);

contaDoAndre.Transferir(50, contaDaMaria);


Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);
Console.WriteLine("Saldo da conta do André = " + contaDaMaria.saldo);