using System.Text;

namespace najduzszy_ciag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tekstA = textBox1.Text;
            string tekstB = textBox2.Text;

            string wynik =  tab(tekstA, tekstB);

           
            label1.Text = wynik;
            


            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private string tab(string A, string B)
        {
           

            int[,] tab = new int[A.Length + 1, B.Length + 1]; 
            for (int i = 1; i <= A.Length; i++)
            {
                tab[i, 0] = A[i - 1]; 
            }

            
            for (int j = 1; j <= B.Length; j++)
            {
                tab[0, j] = B[j - 1]; 
            }

            
            for (int i = 1; i <= A.Length; i++)
            {
                for (int j = 1; j <= B.Length; j++)
                {
                    tab[i, j] = 0; 
                }
            }


            




            StringBuilder wynik = new StringBuilder();
            for (int i = 0; i <= A.Length; i++)
            {
                for (int j = 0; j <= B.Length; j++)
                {

                    
                    if (i == 0 && j > 0)
                        wynik.Append((char)tab[i, j] + " ");
                    else if (j == 0 && i > 0)
                        wynik.Append((char)tab[i, j] + " ");
                    else
                        wynik.Append(tab[i, j] + " ");
                }
                wynik.AppendLine(); 
            }

            return wynik.ToString();

        }
    }
}