using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} pela Playstore...");
            Console.WriteLine($"O aplicativo {nomeApp} foi instalado com sucesso no seu Nokia {Modelo}!");
        }
    }
}
