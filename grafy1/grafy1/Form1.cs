using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace grafy1
{
    public partial class Form1 : Form
    {
        private Graf1 graf = new Graf1(); // Tworzymy instancje grafu

        public Form1()
        {
            InitializeComponent();
        }

        // Obsluga dodawania wezla
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int nodeValue))
            {
                var newNode = new NodeG1(nodeValue);
                if (graf.Nodes.Exists(n => n.data == nodeValue))
                {
                    MessageBox.Show($"Wezel {nodeValue} juz istnieje!", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    graf.Nodes.Add(newNode);
                    MessageBox.Show($"Dodano wezel {nodeValue}.");
                }
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Prosze wprowadzic poprawny numer wezla.", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            AktualizujGraf();
        }

        // Obsluga dodawania krawedzi
        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int start) &&
                int.TryParse(textBox2.Text, out int end) &&
                int.TryParse(textBox3.Text, out int weight))
            {
                var startNode = graf.Nodes.Find(n => n.data == start);
                var endNode = graf.Nodes.Find(n => n.data == end);

                if (startNode == null || endNode == null)
                {
                    MessageBox.Show("Nie znaleziono wezlow o podanych wartosciach.", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var edge = new Edge(startNode, endNode, weight);
                    graf.Add(edge);
                    MessageBox.Show($"Dodano krawedz: {start} --({weight})--> {end}");
                }

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Prosze wprowadzic poprawne dane dla krawedzi.", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            AktualizujGraf();
        }

        // Aktualizuje wyswietlenie grafu w textBox4
        private void AktualizujGraf()
        {
            textBox4.Text = graf.ToString();
        }
    }
}
