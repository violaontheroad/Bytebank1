﻿using bytebank;


Console.WriteLine("Boas Vindas ao seu banco, ByteBank!\n");
//ContaCorrente conta1 = new ContaCorrente();
//conta1.titular = "André Silva";
//conta1.conta = "110123-X";
//conta1.numero_agencia = 123;
//conta1.nome_agencia = "Agência Central";
//conta1.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Amanda Nogueira";
//conta2.conta = "10106-X";
//conta2.numero_agencia = 321;
//conta2.nome_agencia = "Agência Central";
//conta2.saldo = 100;

//Console.WriteLine("Saldo da Amanda pré-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do André  pré- Transferência: " + conta1.saldo);
//bool transferencia = conta1.Transferir(50, conta2);
//Console.WriteLine("Transferência realizada com sucesso? "+transferencia);
//Console.WriteLine("Saldo da Amanda pós-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do André  pós- Transferência: " + conta1.saldo);

//Cliente sarah = new Cliente();
//sarah.Nome = "Sarah Silva";
//sarah.Profissao = "Professora";
//sarah.Cpf = "11111111-12";

//Cliente ester = new Cliente();
//ester.Nome = "Ester Almeida";
//ester.Profissao = "Advogada";
//ester.Cpf = "868524125-32";

//Console.WriteLine("Total de clientes: "+ Cliente.TotalClientesCadastrados);

ContaCorrente contaAndre = new ContaCorrente(159,"152869-x");
contaAndre.Titular = new Cliente();
contaAndre.Titular.Nome = " André Pereira";
contaAndre.Titular.Profissao = "Auxiliar Administrativo";
contaAndre.Saldo = 100;

Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);

Console.ReadKey();




