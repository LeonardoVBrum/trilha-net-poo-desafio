using DesafioPOO.Models;

Console.WriteLine("SmarPhone Nokia:");
Nokia nokia= new Nokia(numero: "219999956",modelo:"Nokia C01 Plus ",imei:"IMEI4558855",memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("------------------------------------------------------------------------");
Console.WriteLine("\n");

Console.WriteLine("Telefone Iphone:");
Iphone iphone= new Iphone(numero:"219995855", modelo:"Iphone 13 Pro Max",imei:"IMEI3554844",memoria:128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");