using DesafioPOO.Models;

// Test Nokia class
Smartphone nokia = new Nokia("12345", "Nokia 3310", "111222333444555", 16);
Console.WriteLine("Testing Nokia:");
Console.WriteLine($"Numero: {nokia.Numero}");
Console.WriteLine($"Modelo: {nokia.Modelo}");
Console.WriteLine($"IMEI: {nokia.IMEI}");
Console.WriteLine($"Memoria: {nokia.Memoria}GB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

// Test iPhone class
Smartphone iphone = new Iphone("67890", "iPhone 12", "5554443332211", 64);
Console.WriteLine("Testing iPhone:");
Console.WriteLine($"Numero: {iphone.Numero}");
Console.WriteLine($"Modelo: {iphone.Modelo}");
Console.WriteLine($"IMEI: {iphone.IMEI}");
Console.WriteLine($"Memoria: {iphone.Memoria}GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");