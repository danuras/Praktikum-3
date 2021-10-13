using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            lblIsiNim.Text = ": 20.11.3637";
            lblIsiNama.Text = ": Darussalaam Nur Rasyidu";
            lblIsiKelas.Text = ": 20-S1IF-06";
        }

        private void btnKosongkan_Click(object sender, EventArgs e)
        {
            lblIsiNim.Text = ":";
            lblIsiNama.Text = ":";
            lblIsiKelas.Text = ":";
        }
    }
}
