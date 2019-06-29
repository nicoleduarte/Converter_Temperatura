using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrenheit
{
    class Conversor
    {
        private double TemperaturaC;
        private double TemperaturaF;

        public double TemperaturaC { get => TemperaturaC; set => TemperaturaC = value; }
        public double TemperaturaF { get => TemperaturaF; set => TemperaturaF = value; }
    }

    public double CoverteC()
    {
        double fah = ((Temperaturaf - 32) / 1.8);
        return (fah);
        
    }

    public double CoverteF()
    {
        double cel = (Temperaturac * 1.8 + 32);
        return (cel);
    }

}
