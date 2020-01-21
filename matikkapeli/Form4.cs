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
    public partial class Form4 : Form
    {
        Form1 main;
        int num1, num2;
        double desi, oikea = 0;
        bool des;

        public Form4(bool desimaali, Form1 f1)
        {
            InitializeComponent();
            des = desimaali;
            main = f1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            UusiLasku();
            labelPalkinnot.Text = "Palkinnot: " + main.palkinnot.ToString();
        }

        private void UusiLasku()
        {
            Random numero = new Random();

            if (!des)
            {
                num1 = numero.Next(1, 11);
                num2 = numero.Next(1, 11);
                oikea = num1 * num2;
                labelLasku.Text = num1 + " * " + num2;
            }
            else
            {
                num1 = numero.Next(1, 11);
                desi = Math.Round(numero.NextDouble() * 10, 1);
                oikea = num1 * desi;
                oikea = Math.Round(oikea, 1);
                labelLasku.Text = num1 + " * " + desi;
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
