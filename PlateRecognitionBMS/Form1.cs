using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlateRecognitionBMS  
{
    public partial class Form1 : Form
    {
        public static int valores = 256;
        public static Bitmap bmpimg;
        public static int[] histograma = new int[valores];
        public static int[] histogramaR = new int[valores];
        public static int[] histogramaG = new int[valores];
        public static int[] histogramaB = new int[valores];
        public static int tamanio;
        public int valor;
        public int valorR;
        public int valorG;
        public int valorB;
        public int posiciony = 123;
        int T = 0;

        public Form1()
        {
            InitializeComponent();
        }
        public void abrir()
        {
            OpenFileDialog filechooser = new OpenFileDialog();
            filechooser.RestoreDirectory = true;

            if (filechooser.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = new Bitmap(new Bitmap(filechooser.FileName), 300, 300);
            }

            bmpimg = new Bitmap(this.pictureBox1.Image);

            tamanio = bmpimg.Width + bmpimg.Height;

            for (int i = 0; i < valores; i++)
            {
                histograma[i] = 0;
                histogramaR[i] = 0;
                histogramaG[i] = 0;
                histogramaB[i] = 0;
            }
           // panel1.CreateGraphics().Clear(Color.White);

            //pictureBox2.CreateGraphics().Clear(Color.LightGray);
            
            //pictureBox2.Refresh();


        }


    }
}