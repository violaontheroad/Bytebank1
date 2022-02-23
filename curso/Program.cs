using bytebank;

Console.WriteLine("Bem vindo ao seu banco,  Bytebank ");

Cliente titular1 = new Cliente("25035211002", "André Silva","Administrador");
ContaCorrente conta1 = new ContaCorrente("012596-X",789,"Agencia Central",188,titular1);
conta1.InformacaoConta();

Console.WriteLine("Total de Contas Criadas: "+ContaCorrente.TotalDeContasCriadas);

Cliente titular2 = new Cliente("23115799080", "Miguel Ostrander", "Roteirista");
ContaCorrente conta2 = new ContaCorrente("5248616-X", 963, "Agencia Marataízes", 100, titular2);
conta2.InformacaoConta();

Console.WriteLine("Total de Contas Criadas: " + ContaCorrente.TotalDeContasCriadas);

Console.ReadKey();