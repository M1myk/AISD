using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace grafy
{
    public partial class Form1 : Form
    {
        private Graf graf = new Graf();
        private Dictionary<int, NodeG> wezly = new Dictionary<int, NodeG>();

        public Form1()
        {
            InitializeComponent();


            InicjalizujGraf();
        }

        private void InicjalizujGraf()
        {

            var w1 = new NodeG(1);
            var w2 = new NodeG(2);
            var w3 = new NodeG(3);
            var w4 = new NodeG(4);
            var w5 = new NodeG(5);
            var w6 = new NodeG(6);
            var w7 = new NodeG(7);


            w1.sasiedzi.Add(w2);
            w1.sasiedzi.Add(w3);
            w2.sasiedzi.Add(w4);
            w2.sasiedzi.Add(w6);
            w3.sasiedzi.Add(w7);
            w5.sasiedzi.Add(w7);
            w5.sasiedzi.Add(w1);
            w6.sasiedzi.Add(w2);
            w4.sasiedzi.Add(w2);
            w4.sasiedzi.Add(w5);
            w5.sasiedzi.Add(w1);
            w7.sasiedzi.Add(w3);


            wezly[1] = w1;
            wezly[2] = w2;
            wezly[3] = w3;
            wezly[4] = w4;
            wezly[5] = w5;
            wezly[6] = w6;
            wezly[7] = w7;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox1.Text, out int startValue) && wezly.ContainsKey(startValue))
            {
                NodeG startNode = wezly[startValue];


                List<NodeG> odwiedzone = graf.Wezel(startNode);


                string wynik = string.Join(", ", odwiedzone);


                textBox2.Text = wynik;
            }
            else
            {
                MessageBox.Show("Blad");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
