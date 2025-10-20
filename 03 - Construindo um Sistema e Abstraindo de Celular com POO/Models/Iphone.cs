using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03___Construindo_um_Sistema_e_Abstraindo_de_Celular_com_POO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp}...");
        }
    }
}