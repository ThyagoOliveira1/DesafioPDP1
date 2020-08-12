using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContadorMoedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConverter0_Click(object sender, EventArgs e)
        {
            double vlr,vlrUSD,vlrEU,vlrY;
            vlr = Convert.ToDouble(txtbReal1.Text);
            vlrUSD = vlr / 5.40;
            txtbUSD1.Text = Convert.ToString(vlrUSD);
            vlrEU = vlr / 6.30;
            txtbEU1.Text = Convert.ToString(vlrEU);
            vlrY = vlr / 0.051;
            txtbY1.Text = Convert.ToString(vlrY);
        }

        private void btnConverter1_Click(object sender, EventArgs e)
        {
            double vlr, vlrReal, vlrEU, vlrY;
            vlr = Convert.ToDouble(txtbUSD2.Text);
            vlrReal = vlr * 5.40;
            txtbReal2.Text = Convert.ToString(vlrReal);
            vlrEU = vlr * 0.85;
            txtbEU2.Text = Convert.ToString(vlrEU);
            vlrY = vlr * 106.57;
            txtbY2.Text = Convert.ToString(vlrY);
        }

        private void btnConverter2_Click(object sender, EventArgs e)
        {
            double vlr, vlrReal, vlrUSD, vlrY;
            vlr = Convert.ToDouble(txtbEU3.Text);
            vlrUSD = vlr * 1.17;
            txtbUSD3.Text = Convert.ToString(vlrUSD);
            vlrReal = vlr * 6.32;
            txtbReal3.Text = Convert.ToString(vlrReal);
            vlrY = vlr * 125.08;
            txtbY3.Text = Convert.ToString(vlrY);
        }

        private void btnConverter3_Click(object sender, EventArgs e)
        {
            double vlr, vlrReal, vlrUSD, vlrEU;
            vlr = Convert.ToDouble(txtbY4.Text);
            vlrUSD = vlr * 0.0094;
            txtbUSD4.Text = Convert.ToString(vlrUSD);
            vlrEU = vlr * 0.0080;
            txtbEU4.Text = Convert.ToString(vlrEU);
            vlrReal = vlr * 0.051;
            txtbReal4.Text = Convert.ToString(vlrReal);
        }
    }
}
