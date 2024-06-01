namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public sealed class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp, int tamanho)
        {
            int total = Memoria - tamanho;
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no IPhone, espaço restante no aparelho: {total}Gb");
        }
    }
}