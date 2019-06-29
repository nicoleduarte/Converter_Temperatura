using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrenheit
{
    class Conversor
    {
        private double temperaturaF;
        private double temperaturaC;

        public double TemperaturaC { get => temperaturaC; set => temperaturaC = value; }
        public double TemperaturaF { get => temperaturaF; set => temperaturaF = value; }
         
        public double converterParaCelsius()
        {
            double celsius = (temperaturaF - 32)/ 1.8;
            return (celsius);
        }

        public double converterParaFahrenheit()
        {
            double Fahrenheit = 1.8 * temperaturaC + 32;
            return (Fahrenheit);
        }

    }
}
