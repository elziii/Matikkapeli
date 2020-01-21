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
    public partial class Form3 : Form
    {
        Form1 main;
        int num1, num2;
        double desi, desi2, oikea = 0;
        bool des, nega;

        public Form3(bool desimaali, bool negatiivinen, Form1 f1)
        {
            InitializeComponent();
            des = desimaali;
            nega = negatiivinen;
            main = f1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
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
                if (!nega)
                {
                    if (num2 > num1)
                    {
                        int t = num1;
                        num1 = num2;
                        num2 = t;
                    }
                }
                oikea = num1 - num2;
                labelLasku.Text = num1 + " - " + num2;
            }

            else
            {
                desi = Math.Round(numero.NextDouble() * 100, 1);
                desi2 = Math.Round(numero.NextDouble() * 100, 1);
                if (!nega)
                {
                    if (desi2 > desi)
                    {
                        double temp = desi;
                        desi = desi2;
                        desi2 = temp;
                    }
                }
                oikea = desi - desi2;
                oikea = Math.Round(oikea, 1);
                labelLasku.Text = desi + " - " + desi2;
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

