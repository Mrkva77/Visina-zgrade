using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visina_Zgrade
{
    internal class Neboder
    {
        // Definiramo varijable u int
        int visina = 3, brojKatova;

        // geteri i seteri
        public int Visina1 { get => visina; set => visina = value; }
        public int BrojKatova { get => brojKatova; set => brojKatova = value; }

        // Kada se pritisne gumb onda se izračunava visina
        public int IzracunajVisinu(int BrojKatova)
        {
            visina = BrojKatova * visina;
            return visina; // vrača varijablu visina
        }
    }
}
