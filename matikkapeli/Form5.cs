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
    public partial class Form5 : Form
    {
        Form1 main;
        double desi, desi2, oikea = 0;
        bool des;

        public Form5(bool desimaali, Form1 f1)
        {
            InitializeComponent();
            des = desimaali;
            main = f1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            UusiLasku();
            labelPalkinnot.Text = "Palkinnot: " + main.palkinnot.ToString();
        }

        private void UusiLasku()
        {
            Random numero = new Random();

            float num1 = 0;
            float num2 = 0;

            if (!des)
            {
                while (num1 % num2 != 0)
                {
                    num1 = numero.Next(2, 101);
                    num2 = numero.Next(2, 11);
                    oikea = num1 / num2;
                }
                labelLasku.Text = num1 + " / " + num2;
            }

            else
            {
                desi = Math.Round(numero.NextDouble() * 100, 1);
                desi2 = numero.Next(1, 11);
                oikea = desi / desi2;
                oikea = Math.Round(oikea, 1);
                labelLasku.Text = desi + " / " + desi2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(tbVastaus.Text, out double vastaus);

            if (vastaus == oikea)
            {
                labelOV.Text = "Oikea vastaus!";
                main.palkinnot++;
                labelPalkinnot.Text = "Palkinnot: " + main.palkinnot.ToString();
            }
            else
            {
                labelOV.Text = "Väärä vastaus!";
            }

            tbVastaus.Clear();
            UusiLasku();
        }
    }
}
