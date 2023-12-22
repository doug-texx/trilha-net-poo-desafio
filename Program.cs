using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("11960755195", "S23", "12345678900", 256);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iPhone = new Iphone("11960755195", "Iphone 14 Pro", "96385274100", 512);
iPhone.Ligar();
iPhone.InstalarAplicativo("Telegram");