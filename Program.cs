using DesafioPOO.Models;

Smartphone iphone = new Iphone(numero:"111111",modelo:"pro",imei:"12121", memoria:10);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("zap");

Smartphone nokia = new Nokia(numero:"111111",modelo:"pro",imei:"12121", memoria:10);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("zap");
