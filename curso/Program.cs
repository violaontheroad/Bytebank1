//Console.WriteLine("Bem vindo ao seu banco,  Bytebank ");

//string titular = "André Silva";
//string conta = "101023-X";
//string agencia = "Agência Central";
//double saldo = 100;

//Console.WriteLine($"Títular da conta: {titular}");
//Console.WriteLine($"Número da conta: {conta}");
//Console.WriteLine($"Agência: {agencia}");
////Console.WriteLine($"Saldo R$ {saldo}");
//Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", saldo)}");

//Console.WriteLine("===============================================");

//string titular2 = "Selina Correa";
//string conta2 = "365987-A";
//string agencia2 = "Agência Bairro União";
//double saldo2 = 375;

//Console.WriteLine($"Títular da conta: {titular2}");
//Console.WriteLine($"Número da conta: {conta2}");
//Console.WriteLine($"Agência: {agencia2}");
//Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", saldo2)}");

using bytebank;

ContaCorrente conta = new ContaCorrente();
conta.titular = "André Silva";
conta.conta = "12345-Y";
conta.agencia = "Agência Rua dos Bancos";
conta.saldo = 123.96;

Console.WriteLine($"Títular da conta: {conta.titular}");
Console.WriteLine($"Número da conta: {conta.conta}");
Console.WriteLine($"Agência: {conta.agencia}");
Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta.saldo)}");

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Amanda Silva";
conta2.conta = "625433-Y";
conta2.agencia = "Agência Rua 25 de Março";
conta2.saldo = 5156.9;

Console.WriteLine($"Títular da conta: {conta2.titular}");
Console.WriteLine($"Número da conta: {conta2.conta}");
Console.WriteLine($"Agência: {conta2.agencia}");
Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta2.saldo)}");