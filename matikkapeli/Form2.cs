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
    public partial class Form2 : Form
    {
        Form1 main;
        int num1, num2;
        double desi, desi2, oikea = 0;
        bool des;

        public Form2(bool desimaali, Form1 f1)
        {
            InitializeComponent();
            des = desimaali;
            main = f1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UusiLasku();
            labelPalkinnot.Text = "Palkinnot: " + main.palkinnot.ToString();
        }

        private void UusiLasku()
        {
            Random numero = new Random();
            
            if (!des)
            {
                num1 = numero.Next(1, 101);
                num2 = numero.Next(1, 101);
                oikea = num1 + num2;
                labelLasku.Text = num1.ToString() + " + " + num2.ToString();
            }

            else
            {
                desi = Math.Round(numero.NextDouble(), 1 );
                desi2 = Math.Round(numero.NextDouble() * 100, 1);
                oikea = desi + desi2;
                oikea = Math.Round(oikea, 1);
                labelLasku.Text = desi.ToString() + " + " + desi2.ToString();
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
