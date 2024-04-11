using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone,
Console.WriteLine("Smartphone Nokia: ");
Nokia smartphoneNokia = new Nokia("123456798", "Modelo 1", "1111111111", 64);
smartphoneNokia.Ligar();
smartphoneNokia.InstalarAplicativo("Instagram");

Console.WriteLine("Smartphone IPhone: ");
Iphone smartphoneIphone = new Iphone("987654321", "Modelo 2", "222222222", 64);
smartphoneIphone.ReceberLigacao();
smartphoneIphone.InstalarAplicativo("Telegram");