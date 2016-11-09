using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace IndovinaLeFigure
{
    class Program
    {
        const int ORZ     = 1;
        const int VER     = 2;
        const int DIA     = 3;
        const int DIAINV  = 4;
        const int CROCE   = 5;
        const int PIENA   = 6;

        const int TEMPO_VISUALIZZAZIONE = 4000;  //ms

        static Random rnd = new Random();
        static int punteggio = 0;

        const string CELLA = "*";

        static int[] figure = { 1, 2, 3, 4, 5, 6 };
        static char[] tasti = { '1', '2', '3', '4', '5', '6' };
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            VisualizzaFigure(1, 0, figure, true);
            Gioca();
            Console.WriteLine(); 
        }

        static void Gioca()
        {
            int numFigura = 0;
            int numSessione = 0;
            Write(1, 20, "Punteggio = " + punteggio.ToString());
            while(true)
            {
                int[] figure = GeneraFigure();
                CancellaFigure(1, 9);
                VisualizzaFigure(1, 9, figure, false);
                Thread.Sleep(TEMPO_VISUALIZZAZIONE);
                CancellaFigure(1, 9);
                for (int i = 0; i < figure.Length; i++)
                {
                    Console.SetCursorPosition(1+i*10, 9);
                    numFigura = LeggiNumero();
                    if (numFigura == figure[i])
                        punteggio += 10;
                }
                numSessione++;
                string msg = string.Format("N° {0} - Punteggio = {1} -  % = {2:p}",numSessione, punteggio, punteggio / (double)(numSessione*60));
                Write(1, 20, msg); //
                
            }
        }

        static int LeggiNumero()
        {
            char tasto = Console.ReadKey(false).KeyChar;
            for (int i = 0; i < tasti.Length; i++)
            {
                if (tasto == tasti[i])
                    return i + 1;
            }
            return 0;
            
        }

        static void VisualizzaFigure(int x, int y, int[] figure, bool numeroFigura)
        {
            for (int i = 0; i < figure.Length; i++)
            {
                Console.SetCursorPosition(i * 10 + x, y);
                VisualizzaFigura(figure[i], numeroFigura);
            }
        }

        static void CancellaFigure(int x, int y)
        {
            for (int i = 0; i < 3; i++)
            {
                Write(x, y+i, "                                                                       ");
            }
        }

        static void VisualizzaFigura(int figura, bool numeroFigura)
        {
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            if (numeroFigura)
            {
                Write(x + 1, y, figura.ToString());
                y+=2;
            }
            switch (figura)
            {
                case ORZ: Write(x, y + 1, CELLA + CELLA + CELLA); break;
                case VER: 
                    Write(x + 1, y, CELLA);
                    Write(x + 1, y + 1, CELLA);
                    Write(x + 1, y + 2, CELLA);
                    break;
                case DIA: 
                    Write(x, y, CELLA);
                    Write(x + 1, y + 1, CELLA);
                    Write(x + 2, y + 2, CELLA);
                    break;
                case DIAINV: 
                    Write(x, y+2, CELLA);
                    Write(x + 1, y + 1, CELLA);
                    Write(x + 2, y, CELLA);
                    break;
                case CROCE: 
                    Write(x, y + 1, CELLA + CELLA + CELLA);
                    Write(x + 1, y, CELLA);
                    Write(x + 1, y + 1, CELLA);
                    Write(x + 1, y + 2, CELLA); 
                    break;
                case PIENA:
                    Write(x, y, CELLA + CELLA + CELLA); 
                    Write(x, y + 1, CELLA + CELLA + CELLA);
                    Write(x, y + 2, CELLA + CELLA + CELLA); 
                    break;

                default: return;
            }
        }

        static void Write(int x, int y, string s)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }

        static int[] GeneraFigure()
        {
            int[] figure = new int[6];
            for (int i = 0; i < figure.Length; i++)
            {
                figure[i] = rnd.Next(1, 7);
            }
            return figure;
        }
    }



}
