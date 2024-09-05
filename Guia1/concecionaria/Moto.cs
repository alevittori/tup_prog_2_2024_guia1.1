using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concecionaria
{
    internal class Moto
    {
        public string Marca {  get; private set; }
        public int Modelo { get; private set; }
        public double ValorFrabricacion {  get; private set; }

        //COnstructor
        public Moto(string marca, int modelo , double valorFabricacion)
        {
            Marca = marca;
            Modelo = modelo;
            ValorFrabricacion = valorFabricacion;
        }
    }
}
