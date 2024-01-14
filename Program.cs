using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // Teste com Iphone
        Iphone iphone = new Iphone("123456789", "iPhone 12", "ABC123", 64);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");

        // Teste com Nokia
        Nokia nokia = new Nokia("987654321", "Nokia 3310", "XYZ456", 16);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");
    }
}
