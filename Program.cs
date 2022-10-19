using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Smatphone Nokia : ");
Smartphone nokia = new Nokia("45454545", "Modelo1", "2525", 64);
nokia.Ligar();
nokia.InstalarAplicativo("ZAPZAP");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone : ");
Smartphone iphone = new Iphone("55555", "Mdelo2", "5252", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegran");
