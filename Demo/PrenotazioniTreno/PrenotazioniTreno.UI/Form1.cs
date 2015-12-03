using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PrenotazioniTreno.Gestione;

namespace PrenotazioniTreno.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // Usata per formattare i dati del vagone e la loro intestazione 
        const string FORMATO_INFO_VAGONE = "{0,-4} {1,-8} {2,-8} {3}";
        private void Form1_Load(object sender, EventArgs e)
        {
            // Aggiunge dei vagoni predefiniti, in modo 
            Treno.AggiungiVagoniIniziali();

            string s = string.Format(FORMATO_INFO_VAGONE, "N°", "Classe", "Fumatori", "Posti disp.");
            lblIntestazioneTreno.Text = s;
            AggiornaInformazioniTreno();
            AggiornaStatoBottonePrenotazione();
        }
        private void btnPrenota_Click(object sender, EventArgs e)
        {
            //Procedimento:
                // ricava i dati
                // prenota e verifica successo prenotazione
                // aggiorna informazioni sui vagoni

            int numVagone = int.Parse(txtNumeroVagone.Text);
            int postiPrenotati =int.Parse(txtPostiPrenotati.Text);

            bool okPrenotazione = Treno.Prenota(numVagone, postiPrenotati);

            if (!okPrenotazione)
            {
                BoxErrore("Prenotazione non completata\nNumero vagone errato o posti non disponibili", "Prenotazione");
                return;
            }
            MessageBox.Show("Prenotazione effettuata", "Prenotazione");
            txtNumeroVagone.Text = "";
            txtPostiPrenotati.Text = "";
            AggiornaInformazioniTreno();            
        }

        // Abilita/disabilita bottone di prenotazione in base alla validità
        // dei dati inseriti (numero vagone e posti prenotati)
        private void AggiornaStatoBottonePrenotazione()
        {
            int numVagone, postiPrenotati;
            bool okNumVagone = int.TryParse(txtNumeroVagone.Text, out numVagone);
            bool okPostiPrenotati = int.TryParse(txtPostiPrenotati.Text, out postiPrenotati);
            btnPrenota.Enabled = okNumVagone && okPostiPrenotati;
        }

        private void AggiornaInformazioniTreno()
        {
            //Procedimento:
                // elimina vecchie informazioni
                // per ogni vagone 
                    // formatta informazioni e le aggiunge al listbox
            lstTreno.Items.Clear();
            foreach (var vagone in Treno.Vagoni)
            {
                string s = FormattaInfoVagone(vagone);
                lstTreno.Items.Add(s);
            }
        }

        //Formatta i dati di un vagone in una stringa
        string FormattaInfoVagone(Vagone v)
        {
            string fumatoriStr = v.Fumatori ? "SI" : "NO";
            string classeStr = v.Classe.ToString();

            return string.Format(FORMATO_INFO_VAGONE, v.Numero, classeStr, fumatoriStr, v.PostiDisponibili);
        }

        // Semplifica la visualizzazione dei messaggi di errore
        private void BoxErrore(string testo, string titolo)
        {
            MessageBox.Show(testo, titolo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Gestisce le modifiche ai contenuti dei due textbox e aggiorna 
        // lo stato del bottone di prenotazione
        private void txtNumeroVagone_TextChanged(object sender, EventArgs e)
        {
            AggiornaStatoBottonePrenotazione();
        }

        private void txtPostiPrenotati_TextChanged(object sender, EventArgs e)
        {
            AggiornaStatoBottonePrenotazione();
        }

        


    }
}
