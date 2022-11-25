using exercicio3;

ContaCorrente c = new ContaCorrente();
c.NomeCorrentista = "Giovanni";
c.NumeroConta = 51345;
c.NumeroAgencia = 03;

Console.WriteLine(c.Saldo);

c.Depositar(500);
Console.WriteLine(c.Saldo);

c.Sacar(300);
Console.WriteLine(c.Saldo);

c.Sacar(300);
Console.WriteLine(c.Saldo);