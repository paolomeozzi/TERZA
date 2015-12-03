using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrenotazioniTreno.Gestione
{
    public static class Treno
    {
        public static  List<Vagone> Vagoni = new List<Vagone>();
        
        // Semplifica l'inserimento di un nuovo vagone, evitando che il codice 
        // nella UI debba utilizzare una variabile di tipo Vagone
        public static void AggiungiVagone(int numero, ClasseVagone classe, bool fumatori, int numeroPosti)
        {
            Vagone v;
            v.Numero = numero;
            v.Classe = classe;
            v.Fumatori = fumatori;
            v.NumeroPosti = numeroPosti;
            v.PostiDisponibili = numeroPosti;
            AggiungiVagone(v);
        }

        // Disponibile per il codice della UI, ma attualmente utilizzato soltanto
        // dall'altro metodo
        public static void AggiungiVagone(Vagone v)
        {
            Vagoni.Add(v);
        }

        // Utilizzato nella prenotazione: ritorna l'indice del vagone dato il suo numero.
        // Ritorna -1 per indicare che non esiste un vagone con quel numero
        public static int PosizioneVagone(int numero)
        {
            for (int i = 0; i < Vagoni.Count; i++)
            {
                if (Vagoni[i].Numero == numero)
                    return i;
            }
            return -1;
        }

        public static bool Prenota(int numeroVagone, int postiPrenotati)
        {
            //Procedimento:
                // trova l'indice del vagone nel treno
                // se vagone non trovato termina
                // ottiene il vagone mediante l'indice
                // verifica posti disponibili
                // se non sono sufficienti termina
                // aggiorna posti disponibili e memorizza nuovamente il vagone nel treno

            int posVagone = PosizioneVagone(numeroVagone);            
            if (posVagone == -1)
                return false;

            Vagone v = Vagoni[posVagone];
            if (v.PostiDisponibili < postiPrenotati)
                return false;

            v.PostiDisponibili -= postiPrenotati;
            Vagoni[posVagone] = v;
            return true;
        }

        // utile per evitare la fase di inserimento e realizzare immediatamente
        // le altre fasi (visualizzazione e prenotazione)
        public static void AggiungiVagoniIniziali()
        {
            AggiungiVagone(1, ClasseVagone.Prima, false, 30);
            AggiungiVagone(2, ClasseVagone.Seconda, false, 30);
            AggiungiVagone(3, ClasseVagone.Terza, true, 40);
        }
    }
}
