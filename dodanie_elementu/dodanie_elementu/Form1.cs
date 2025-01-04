using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dodanie_elementu
{
    public partial class Form1 : Form
    {
        private List myList = new();
        private BST myBST = new();

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox1.Text, out int liczba))
            {
                myList.AddLast(liczba);
                myBST.add(liczba);
                MessageBox.Show($"Dodano {liczba} do listy.");
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Proszę wprowadzić poprawną liczbę calkowitą.");
            }



        }


        private void buttonShow_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string lista = myList.GetListAsString();
            textBox2.Text = lista;

            if (lista.Length > 0)
            {
                MessageBox.Show("Twoja lista: " + myList.GetListAsString(), "lubie mame");
            }
            else
            {
                MessageBox.Show("Lista jest pusta.", "Informacja");
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Usunieto ostatni element");
            myList.RemoweLast();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string lista = myList.intToString();
            textBox2.Text = lista;

            if (lista.Length > 0)
            {
                MessageBox.Show("Twoja lista: " + myList.intToString(), "lubie mame");
            }
            else
            {
                MessageBox.Show("Lista jest pusta.", "Informacja");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<int> preorderList = myBST.postOrder();

            string output = string.Join(" ", preorderList);
            textBox3.Text = output;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
