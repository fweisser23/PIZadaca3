using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIZadatak3
{
    public partial class ZaposlenikForma : Form
    {
        public ZaposlenikForma()
        {
            InitializeComponent();
        }

        private void btnListaMenija_Click(object sender, EventArgs e)
        {
            FrmListaMenija frmListaMenija = new FrmListaMenija();
            Hide();
            frmListaMenija.ShowDialog();
            Close();
        }
    }
}
