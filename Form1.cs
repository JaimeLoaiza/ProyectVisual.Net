using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectVisual.Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnanswer_Click(object sender, EventArgs e)
        {
            txtanswer.Text = (Convert.ToInt32(txtnumber1.Text) + Convert.ToInt32(txtnumber2.Text)).ToString();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
