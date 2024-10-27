using DesafioPOO.Models;

//  public Nokia(string numero, string modelo, string imei, int memoria)

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia("2799642380", "J7", "272727", 126);
nokia.InstalarAplicativo("WhatsApp");

nokia.Ligar();
nokia.ReceberLigacao();

Smartphone iphone = new Iphone("121121212212", "7", "283736", 256);
nokia.InstalarAplicativo("Twitter");

nokia.Ligar();
nokia.ReceberLigacao();