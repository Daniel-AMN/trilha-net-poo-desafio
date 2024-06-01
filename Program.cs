using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
namespace DesafioPOO{
    class TestClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone IPhone: ");
            Iphone iphone = new(numero: "99991234", modelo: "X", imei: "123456789", memoria: 64);
            iphone.ReceberLigacao();
            iphone.Ligar();
            iphone.InstalarAplicativo("Whatsapp", 4);
            
            Console.WriteLine("\n");

            Console.WriteLine("Smartphone Nokia: ");
            Nokia nokia = new(numero: "12349999", modelo: "C3", imei: "123456789", memoria: 64);
            nokia.ReceberLigacao();
            nokia.Ligar();
            nokia.InstalarAplicativo("Telegram", 9);
        }
    }
}