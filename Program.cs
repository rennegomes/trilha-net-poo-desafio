using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("81999999999", "N1", "222222222", 8);
Console.WriteLine("\n-Celular Nokia-");
nokia.Ligar();
nokia.InstalarAplicativo("League of legends");

Iphone iphone = new Iphone("81911111111", "X", "333333333", 16);
Console.WriteLine("\n-Celular Iphone-");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Honkai Star Reail");