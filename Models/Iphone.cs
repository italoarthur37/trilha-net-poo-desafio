namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // CHECK ABAIXO ✅
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        // CHECK ABAIXO ✅
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O aplicativo {nomeApp} está sendo instalado em seu Iphone!");
        }
    }
}