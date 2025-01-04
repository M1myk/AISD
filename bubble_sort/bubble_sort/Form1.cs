using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
namespace bubble_sort

    
    // dodac counting sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nierozdzielone = textBox1.Text;
            string[] liczby = nierozdzielone.Split(',', ' ');
            int[] lista = new int[liczby.Length];

            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = int.Parse(liczby[i]);
            }
            //bubble_sort(lista);

            // Wywołanie funkcji bubble_sort i otrzymanie posortowanej listy
            bubble_sort(lista);

            // Wyświetlenie wyniku w textBox2
            string wyjscie = string.Join(", ", lista);
            textBox2.Text = wyjscie;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nierozdzielone = textBox1.Text;
            string[] liczby = nierozdzielone.Split(',', ' ');
            int[] lista = new int[liczby.Length];

            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = int.Parse(liczby[i]);
            }
            merge_sort(lista);

            string wyjscie = string.Join(", ", lista);
            textBox2.Text = wyjscie;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nierozdzielone = textBox1.Text;
            string[] liczby = nierozdzielone.Split(',', ' ');
            int[] lista = new int[liczby.Length];

            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = int.Parse(liczby[i]);
            }
            quick_sort(lista, 0, lista.Length - 1);

            string wyjscie = string.Join(", ", lista);
            textBox2.Text = wyjscie;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nierozdzielone = textBox1.Text;
            string[] liczby = nierozdzielone.Split(',', ' ');
            int[] lista = new int[liczby.Length];

            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = int.Parse(liczby[i]);
            }
            selection_sort(lista);

            string wyjscie = string.Join(", ", lista);
            textBox2.Text = wyjscie;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string nierozdzielone = textBox1.Text;
            string[] liczby = nierozdzielone.Split(',', ' ');
            int[] lista = new int[liczby.Length];

            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = int.Parse(liczby[i]);
            }
            List<int> nowa_lista =  insertion_sort(lista);

            string wyjscie = string.Join(", ", nowa_lista);
            textBox2.Text = wyjscie;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string nierozdzielone = textBox1.Text;
            string[] liczby = nierozdzielone.Split(',', ' ');
            int[] lista = new int[liczby.Length];

            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = int.Parse(liczby[i]);
            }
            List<int> new_lista =  counting_sort(lista);

            string wyjscie = string.Join(", ", new_lista);
            textBox2.Text = wyjscie;
        }

        private void bubble_sort(int[] lista)
        {
            Boolean zamienono = true;

            while (zamienono)
            {
                zamienono = false;
                for (int i = 0; i < lista.Length - 1; i++)
                {
                    if (lista[i] > lista[i + 1])
                    {
                        int temp = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = temp;

                        zamienono = true;
                    }


                }
            }
            

        }

        private void merge_sort(int[] lista)
        {
            if(lista.Length > 1)
            {
                int mid = lista.Length / 2;
                int[] left = new int[mid];
                int[] right = new int[lista.Length-mid];

                Array.Copy(lista, 0, left, 0, mid);
                Array.Copy(lista, mid, right, 0, lista.Length-mid);

                merge_sort(left);
                merge_sort(right);


                int i = 0, j = 0, k = 0;

                while(i < left.Length && j < right.Length)
                {
                    if(left[i] < right[j])
                    {
                        lista[k] = left[i];
                        i++;
                    }
                    else
                    {
                        lista[k] = right[j];
                        j++;
                    }
                    k++;
                }

                while(i < left.Length)
                {
                    lista[k] = left[i];
                    i++;
                    k++;
                }
                while (j < right.Length)
                {
                    lista[k] = right[j];
                    j++;
                    k++;
                }
            }
        }


        private void quick_sort(int[] lista, int left, int right)
        {
            if (left < right)
            {
                int pivot = lista[right];
                int i = left - 1;
                for(int j = left; j < right; j++)
                {
                    if(lista[j] < pivot)
                    {
                        i += 1;

                        int temp = lista[i];
                        lista[i] = lista[j];
                        lista[j] = temp;
                    }

                }
                int temp1 = lista[i + 1];
                lista[i + 1] = lista[right];
                lista[right] = temp1;


                int index = i + 1;
                quick_sort(lista, left, index - 1);
                quick_sort(lista, index + 1, right);

            }


        }

        private void selection_sort(int[] lista)
        {
           for(int i = 0; i < lista.Length; i++)
            {
                int min = i;
                for(int j = i + 1; j < lista.Length; j++)
                {
                    if( lista[j] < lista[min] )
                    {
                        min = j;

                        
                       
                    }
                }
                int temp = lista[i];
                lista[i] = lista[min];
                lista[min] = temp;
            }
        }

        private List<int> insertion_sort(int[] lista)
        {
            for(int i = 1;i < lista.Length;i++)
            {
                int key = lista[i];
                int j = i - 1;
                while(j >= 0 && lista[j] > key)
                {
                    lista[j + 1] = lista[j];
                    j--;
                }
                lista[j + 1] = key;
            }

            List<int> insertion_list = new List<int>();

            for(int i = 0;i < lista.Length;i++)
            {
                insertion_list.Add(lista[i]);
            }
            return insertion_list;
        }

        public List<int> counting_sort(int[] lista)
        {
            int maxVal = lista.Max();
            int[] count = new int[maxVal+1];

            foreach(int num in lista)
            {
                count[num]++;
            }

            List<int> list = new List<int>();
            for(int i = 0;  i < count.Length; i++)
            {
                while(count[i] > 0)
                {
                    list.Add(i);
                    count[i]--;
                }
            }
            return list;
               
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int numberOfElements = (int)numericUpDown1.Value;
            int[] numbers = generowanie_liczb(numberOfElements);


            textBox1.Text = string.Join(" ", numbers);
        }

        private int[] generowanie_liczb(int count)
        {
            Random random = new Random();
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(1, 100);
            }

            return numbers;
        }

        
    }
}
