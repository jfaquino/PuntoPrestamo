using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoPrestamo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (pnlLeft.Width == 280)
            {
                pnlLeft.Width = 55;
                btnSlide.Location = new Point(25, 26);
            }
            else
            {
                pnlLeft.Width = 280;
                btnSlide.Location = new Point(247, 26);
            }
        }
    }
}
