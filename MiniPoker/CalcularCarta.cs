using System;
using System.Linq;
namespace MiniPoker
{
    public class CalcularCarta
    {
        private int[] _cartas;
        public CalcularCarta(int[] cartas)
        {
            if(cartas == null)
            {
                throw new ArgumentNullException();
            }
            _cartas = Ordenar(cartas);
        }

        public bool CalcularSequencia() {
            
            for (int i = 0; i < _cartas.Length - 1; i++) {
                if (_cartas[i]+1 != _cartas[i + 1]) {
                    return false;
                } 
            }
            return true;
        }

        public bool CalcularQuadra()
        {
            int[] newCartas = _cartas.Distinct().ToArray();

            if(newCartas.Length==2) //dupla

            if (newCartas.Length == 3) //trinca
                
            if (newCartas.Length == 4) //quadra

        }

        public int[] Ordenar(int[] cartas)
        {
            return cartas.OrderBy(x=> x).ToArray();
        }

    }
}