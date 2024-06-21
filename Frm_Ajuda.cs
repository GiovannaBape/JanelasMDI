using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanelasMDI
{
    public partial class Frm_Ajuda : Form
    {
        public Frm_Ajuda()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_Principal Frm_Principal = new Frm_Principal();
            Frm_Principal.Show();
        }
    }
}
