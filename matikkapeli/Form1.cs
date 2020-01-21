using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matikkapeli
{
    public partial class Form1 : Form
    {
        bool nega = false;
        public bool des = false;
        int laskut;
        public int palkinnot;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumma_Click(object sender, EventArgs e)
        {
            labelValittu.Text = "Valittu: Summa";
            checkNegative.Hide();
            laskut = 1;
        }

        private void btnErotus_Click(object sender, EventArgs e)
        {
            labelValittu.Text = "Valittu: Erotus";
            checkNegative.Show();
            laskut = 2;
        }

        private void btnTulo_Click(object sender, EventArgs e)
        {
            labelValittu.Text = "Valittu: Tulo";
            checkNegative.Hide();
            laskut = 3;
        }

        private void btnOsam_Click(object sender, EventArgs e)
        {
            labelValittu.Text = "Valittu: Osamäärä";
            checkNegative.Hide();
            laskut = 4;
        }

        private void checkDesimal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDesimal.Checked == true)
            {
                des = true;
            }
            else if (checkDesimal.Checked == false)
            {
                des = false;
            }
        }

        private void checkNegative_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNegative.Checked == true)
            {
                nega = true;
            }
            else if (checkNegative.Checked == false)
            {
                nega = false;
            }
        }

        private void btnPelaa_Click(object sender, EventArgs e)
        {
            switch (laskut)
            {
                case 1:
                    Form2 summa = new Form2(des, this);
                    summa.ShowDialog();
                    break;
                case 2:
                    Form3 erotus = new Form3(des, nega, this);
                    erotus.ShowDialog();
                    break;
                case 3:
                    Form4 tulo = new Form4(des, this);
                    tulo.ShowDialog();
                    break;
                case 4:
                    Form5 osam = new Form5(des, this);
                    osam.Show();
                    break;
            }
        }

        private void btnSaavutukset_Click(object sender, EventArgs e)
        {
            Form6 saavutukset = new Form6(this);
            saavutukset.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
