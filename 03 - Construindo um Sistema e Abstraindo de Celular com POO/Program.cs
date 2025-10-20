using _03___Construindo_um_Sistema_e_Abstraindo_de_Celular_com_POO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Nokia: ");
Smartphone iphone = new Nokia(numero: "654321", modelo: "Modelo 2", imei: "222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
