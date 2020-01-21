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
    public partial class Form6 : Form
    {
        Form1 main;
        public Form6(Form1 f1)
        {
            InitializeComponent();
            main = f1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            if (main.palkinnot >= 10)
            {
                labelSaavutus1.BackColor = Color.FromArgb(128, 255, 128);
            }
            if (main.palkinnot >= 20)
            {
                labelSaavutus2.BackColor = Color.FromArgb(128, 255, 128);
            }
            if (main.palkinnot >= 30)
            {
                labelSaavutus3.BackColor = Color.FromArgb(128, 255, 128);
            }
            if (main.palkinnot >= 40)
            {
                labelSaavutus4.BackColor = Color.FromArgb(128, 255, 128);
            }
            if (main.palkinnot >= 50)
            {
                labelSaavutus5.BackColor = Color.FromArgb(128, 255, 128);
            }
            if (main.palkinnot >= 60)
            {
                labelSaavutus6.BackColor = Color.FromArgb(128, 255, 128);
            }
            if (main.palkinnot >= 70)
            {
                labelSaavutus7.BackColor = Color.FromArgb(128, 255, 128);
            }
            if (main.palkinnot >= 80)
            {
                labelSaavutus8.BackColor = Color.FromArgb(128, 255, 128);
            }
            if (main.palkinnot >= 90)
            {
                labelSaavutus9.BackColor = Color.FromArgb(128, 255, 128);
            }
            if (main.palkinnot >= 100)
            {
                labelSaavutus10.BackColor = Color.FromArgb(128, 255, 128);
            }
            if (main.palkinnot >= 1000)
            {
                labelSaavutus11.BackColor = Color.FromArgb(128, 255, 128);
            }
        }
    }
}
