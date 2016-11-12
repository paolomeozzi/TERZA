using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace MuoviOggetto
{
    class Program
    {
        // Sono costanti simboliche (in pratica uguali alle variabili, ma non possono essere modificate)
        // sono utili quando un certo valore viene utilizzato più volte nel programma.
        // Infatti, se si vuole cambiare il valore, basta effettuare la modifica nella definizione
        // della costante simbolica.
        const int ALTEZZA_OGGETTO = 3;
        const int LARGHEZZA_OGGETTO = 4;

        // Posizione dell'oggetto nello schermo.
        static int oggettoX;
        static int oggettoY;

        // Direzione di movimento dell'oggetto (1 -> avanti/in basso) (-1 -> indietro/in alto).
        // (Servono due variabili perché l'oggetto si muove in due dimensioni.)
        static int oggettoDX;
        static int oggettoDY;

        static int durataFrame;  // Tempo di sospensione del ciclo (in millisecondi).
        static void Main(string[] args)
        {
            // Imposta dimensioni iniziali della finestra (minori delle massime dimensioni possibili)
            Console.WindowWidth = Console.LargestWindowWidth - 25;
            Console.WindowHeight = Console.LargestWindowHeight - 15;

            PosizionaOggetto();

            // Inizialmente ogni "frame" (schermata) dura 35 ms. (Corrisponde a circa 40 frame al secondo.)
            // Mediante i tasti "+" e "-" questa variabile viene aumentata/decrementata per 
            // rallentare/aumentare la velocità dell'oggetto.
            durataFrame = 25;  

            DisegnaOggetto();

            //********************************** CICLO DI GIOCO ********************************************
            // (La maggior parte dei giochi sono implementati in questo modo.)
            while (true)
            {
                Thread.Sleep(durataFrame);

                CancellaOggetto();
                if (Console.KeyAvailable == true)  // (solo) Se l'utente ha premuto un tasto
                {                                  // legge il testo ed esegue le azioni appropriate.
                    GestisciComandiUtente();
                }
                MuoviOggetto();
                DisegnaOggetto();
            }
            // **********************************************************************************************
        }

        static void GestisciComandiUtente()
        {
            ConsoleKeyInfo ki = Console.ReadKey(true);
            switch (ki.Key)
            {
                // Gestisce il cambio di direzione.
                case ConsoleKey.DownArrow:
                    oggettoDX = 0;
                    oggettoDY = 1;
                    break;
                case ConsoleKey.UpArrow:
                    oggettoDX = 0;
                    oggettoDY = -1;
                    break;
                case ConsoleKey.RightArrow:
                    oggettoDX = 1;
                    oggettoDY = 0;
                    break;
                case ConsoleKey.LeftArrow:
                    oggettoDX = -1;
                    oggettoDY = 0;
                    break;

                case ConsoleKey.Home:
                    oggettoDX = -1;
                    oggettoDY = -1;
                    break;
                case ConsoleKey.End:
                    oggettoDX = -1;
                    oggettoDY = +1;
                    break;

                case ConsoleKey.PageUp:
                    oggettoDX = 1;
                    oggettoDY = -1;
                    break;
                case ConsoleKey.PageDown:
                    oggettoDX = 1;
                    oggettoDY = +1;
                    break;
                
                // gestisce l'incremente/decremento del framerate
                case ConsoleKey.Add:
                    durataFrame -= 3;
                    break;
                case ConsoleKey.Subtract:
                    durataFrame += 3;
                    break;
            }
        }

        static void PosizionaOggetto()
        {
            // Posiziona l'oggetto all'incirca in mezzo allo schermo.
            oggettoX = Console.WindowWidth / 2 - LARGHEZZA_OGGETTO / 2;
            oggettoY = Console.WindowHeight / 2 - ALTEZZA_OGGETTO / 2; ;

            // Imposta la direzione iniziale: avanti orizzontalmente.
            oggettoDX = 1;
            oggettoDY = 0;
        }

        static void MuoviOggetto()
        {
            // Muove l'oggetto.
            oggettoX += oggettoDX;
            oggettoY += oggettoDY;

            // Dopo aver cambiato la sua posizione (ma prima di visualizzarlo)
            // verifica la correttezza delle coordinate e stabilisce se applicare
            // l'effetto "rimbalzo", invertendo le variabili oggettoX e/o oggettoY.
            if (oggettoY <= 0)
            {
                oggettoY = 0;      
                oggettoDY *= -1;  // Equivale a: oggettoDY = oggettoDy * -1
            }
            else if (oggettoY >= Console.WindowHeight - ALTEZZA_OGGETTO)
            {
                oggettoDY *= -1;
                oggettoY = Console.WindowHeight - ALTEZZA_OGGETTO;  // Si assicura che la coordinata non "esca" dallo schermo.
            }

            if (oggettoX <= 0)
            {
                oggettoX = 0;
                oggettoDX *= -1;
            }
            else if (oggettoX >= Console.WindowWidth - LARGHEZZA_OGGETTO)
            {
                oggettoDX *= -1;
                oggettoX = Console.WindowWidth - LARGHEZZA_OGGETTO; // Si assicura che la coordinata non "esca" dallo schermo.
            }
        }

        static void DisegnaOggetto()
        {
            Write(oggettoX, oggettoY, "████");            
            Write(oggettoX, oggettoY + 1, "████");
            Write(oggettoX, oggettoY + 2, "████");
        }

        static void CancellaOggetto()
        {
            // Si può scegliere di cancellare tutto lo schermo o soltanto
            // l'area occupata dall'oggetto (prima che questo sia spostato).
            //Console.Clear();

            Write(oggettoX, oggettoY,     "    ");
            Write(oggettoX, oggettoY + 1, "    ");
            Write(oggettoX, oggettoY + 2, "    ");
        }

        // Metodo di utilità che consente, in una sola istruzione, 
        // di visualizzare un testo a certe coordinate dello schermo.
        static void Write(int x, int y, string text)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(text);
        }
    }
}
