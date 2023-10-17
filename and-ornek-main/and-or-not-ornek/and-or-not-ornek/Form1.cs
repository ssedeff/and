using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace and_or_not_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float devamsizlik=Convert.ToSingle(txtDevamsizlik.Text);
            float ortalama=Convert.ToSingle(txtOrtalama.Text);
            if(ortalama>=50 && devamsizlik < 10)
            {
                lblSonuc.Text = "SONUÇ: GEÇTİNİZ";
            }
            else
            {
                lblSonuc.Text = "SONUÇ: KALDINIZ";
            }

        }
    }
}
