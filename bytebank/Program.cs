using bytebank.Contas;
using bytebank.Titular;


// Conta do André
ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = new Cliente();
contaDoAndre.titular.nome = "André Silva";
contaDoAndre.titular.cpf = "123456789";
contaDoAndre.titular.profissao = "dev";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;

Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);

// Conta da Maria
ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = new Cliente();
contaDaMaria.titular.nome = "Maria Souza";
contaDaMaria.titular.cpf = "221665778";
contaDaMaria.titular.profissao = "Analista";
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 350;

Console.WriteLine("Saldo da conta do André = " + contaDaMaria.saldo);

// Conta do Pedro
ContaCorrente contaDoPedro = new ContaCorrente();
contaDoPedro.titular = new Cliente();
contaDoPedro.titular.nome = "Pedro Silva";

