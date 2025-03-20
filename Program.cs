using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// CHECK ABAIXO ✅

Console.WriteLine("Nokias:");
Smartphone nokia1 = new Nokia(numero: "(84) 98888-8888", modelo: "Tijolão Raiz", imei: "111111111", memoria: 64);
Smartphone nokia2 = new Nokia(numero: "(84) 97777-7777", modelo: "Tijolão Raiz", imei: "333333333", memoria: 64);

nokia1.Ligar();
nokia2.ReceberLigacao();
nokia1.InstalarAplicativo("Jogo da cobrinha");
nokia2.InstalarAplicativo("Jogo da cobrinha 2.0");
Console.WriteLine($"Os números dos Nokias são respectivamente: {nokia1.Numero} e {nokia2.Numero}!");
Console.WriteLine("\n");


Console.WriteLine("iPhones:");
Smartphone iphone1 = new Iphone(numero: "(84) 99999-9999", modelo: "Modelo 20", imei: "222222222", memoria: 128);
Smartphone iphone2 = new Iphone(numero: "(84) 95555-5555", modelo: "Modelo 20", imei: "555555555", memoria: 128);

iphone1.Ligar();
iphone2.ReceberLigacao();
iphone1.InstalarAplicativo("Instagram");
iphone2.InstalarAplicativo("Whatsapp");
Console.WriteLine($"Os números dos Iphones são respectivamente: {iphone1.Numero} e {iphone2.Numero}!");