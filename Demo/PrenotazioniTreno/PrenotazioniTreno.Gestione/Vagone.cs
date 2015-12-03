using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrenotazioniTreno.Gestione
{
    public struct Vagone
    {
        public int Numero;
        public ClasseVagone Classe;
        public bool Fumatori;
        public int NumeroPosti;
        public int PostiDisponibili;
    }

    public enum ClasseVagone
    {
        Prima,
        Seconda,
        Terza
    }


}
