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

        public double CalcularDepreciacionLineal(int anioCalcular, int vidaUtil)
        {
            int anUso = (anioCalcular - Modelo);
            double valorActualizado = ValorFrabricacion - (ValorFrabricacion * ( anUso / vidaUtil));

            return valorActualizado;
        }

        public double CalcularDepreciacionAnual(int anioACalcular, double tasaDepreciacion) {
            int anUso = (anioACalcular - Modelo);
            double valorActualizado = ValorFrabricacion * (Math.Pow((1 - tasaDepreciacion),(anUso)));
            return valorActualizado; 
        }

        public string VerDescricion() {
            
            string msj = $"Marca: {Marca}, Modelo: {Modelo}, Valor Fabricacion: ${ValorFrabricacion}"; 
            return msj; 
        }


    }
}
