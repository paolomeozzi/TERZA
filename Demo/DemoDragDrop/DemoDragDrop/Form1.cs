using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDragDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picGiallo.Image = Properties.Resources.Giallo;
            picRosso.Image = Properties.Resources.Rosso;

            //NOTA BENE: associo manualmente i gestori di eventi 
            //avrei potuto farlo anche dal property editor
            //le due picturebox condividono gli stessi gestori di evento
            picGiallo.MouseDown += pic_MouseDown;
            picGiallo.MouseUp += pic_MouseUp;
            picGiallo.MouseMove += pic_MouseMove;

            picRosso.MouseDown += pic_MouseDown;
            picRosso.MouseUp += pic_MouseUp;
            picRosso.MouseMove += pic_MouseMove;
        }


        bool dragInCorso = false;
        Point posDrag;
        PictureBox picSelezionata; // memorizza la picturebox sulla quale viene eseguito il drag&drop
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            dragInCorso = true;
            posDrag = e.Location;
            picSelezionata = sender as PictureBox; //->"mi segno" la picturebox selezionata
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (!dragInCorso)
                return;
            //sposto la picturebox selezionata di una distanza equivalente
            //allo postamento del mouse
            picSelezionata.Left += e.X - posDrag.X;
            picSelezionata.Top += e.Y - posDrag.Y;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            dragInCorso = false;
        }
    }
}
