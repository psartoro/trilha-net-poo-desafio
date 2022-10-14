using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("\nNokia");
Smartphone nokia = new Nokia("1899999999", "Nokia 5.4", "111111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\nIPhone");
Smartphone iphone = new Iphone("1899999999", "Iphone 14", "111111111111", 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("GarageBand");