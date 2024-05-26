using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} pela App Store...");
            Console.WriteLine($"O aplicativo {nomeApp} foi instalado com sucesso no seu Iphone! {Modelo}!");        }
    }
}
