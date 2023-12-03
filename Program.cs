using DesafioPOO.Models;

Console.WriteLine("--------------- Iphone ---------------\n");
Smartphone iphoneX = new Iphone(numero: "123456789", modelo: "iphone x", imei: "354224789123456", memoria: 64);
iphoneX.Ligar();
iphoneX.ReceberLigacao();
iphoneX.InstalarAplicativo("Instagram");

Console.WriteLine("\n\n--------------- Nokia ---------------\n");
Smartphone lumia = new Nokia(numero: "987654321", modelo: "Nokia Lumia 520", imei: "865309876543210", memoria: 8);
lumia.Ligar();
lumia.ReceberLigacao();
lumia.InstalarAplicativo("WhatsApp");
