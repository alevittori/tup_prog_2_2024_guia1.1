using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace colectivos
{
    internal class Viaje
    {
        //VARIABLES DE ISTANCIAS
        int hInicio, mInicio,transportado;

        //PROPIEDADES
        public int Transportados {
            get { return transportado; }
            private set
            {
                if(value < Asientos)
                {

                }
            }
        }
        public int Asientos { get; private set; }
        public int HDemora { get; private set; }
        public int MDemora { get; private set; }
        public int CantParadas { get; private set; }
        public int HDuracionViaje { get; private set; }
        public int MDuracionViaje { get; private set; }

        //CONSTRUCTOR
        public Viaje(int hInicio, int mInicio, int asientos)
        {
            this.hInicio = hInicio;
            this.mInicio = mInicio;
            Asientos = asientos;
            Transportados = 0;
        }

        //METODOS
        public void RealizarParada(int hLLegadaParada, int  mLLegadaParada, int hSalidaParada , int mSalidaParada, int ascienden, int descienden)
        {
            HDemora = hSalidaParada - hLLegadaParada;
            MDemora = mSalidaParada - mLLegadaParada;
            Transportados += ascienden;
            Transportados -= descienden;

        }


    }
}
