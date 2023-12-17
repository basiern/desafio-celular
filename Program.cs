using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "Modelo 1100", imei: "1234", memoria: 128);
nokia.InstalarAplicativo("Whastapp");
nokia.Ligar();
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "456321", modelo:"Modelo X", imei:"32145", memoria: 256);
iphone.InstalarAplicativo("Telegram");
iphone.Ligar();
iphone.ReceberLigacao();