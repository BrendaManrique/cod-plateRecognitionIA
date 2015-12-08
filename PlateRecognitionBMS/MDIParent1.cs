using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlateRecognitionBMS
{
    public partial class MDIParent1 : Form
    {

        Form1 imgFrm = new Form1();
        public MDIParent1()
        {
            InitializeComponent();
        }


        private void OpenFile(object sender, EventArgs e)
        {

            imgFrm.abrir();
        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void histogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //imgFrm.CalcularHistograma();
        }

        private void abrirProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            imgFrm.MdiParent = this;
            imgFrm.Show();
        }
    }
}
