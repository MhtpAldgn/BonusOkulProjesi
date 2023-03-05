using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeBonus
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void FrmOgretmen_Load(object sender, EventArgs e)
        {

        }

        private void btnKulup_Click(object sender, EventArgs e)
        {
            FrmKulup frklp = new FrmKulup();
            frklp.Show();
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            FrmDersler frd = new FrmDersler();
            frd.Show();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            FrmOgrenci frogrnc = new FrmOgrenci();
            frogrnc.Show();
        }

        private void btnSınav_Click(object sender, EventArgs e)
        {
            FrmNotlar frm = new FrmNotlar();
            frm.Show();
        }
    }
}
