using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace appMetododeselecciónnuevo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int n;
        public int i;
        Random r = new Random();
        int[] vector = new int[20];
        Stopwatch contador = new Stopwatch();
        public void generarDatos(int a)
        {
            n = int.Parse(txttamaño.Text);

            for (i = 0; i < n; i++)
            {
                vector[i] = r.Next(1,50);
            }
            
        }
        public void ordenamientoseleccion( int [] vector)
        {
            int tamaño = vector.Length;
            int minimo = 0;
            int aux = 0;
            for (int i = 0; i < tamaño; i++)
            {
                minimo = i;
                for (int j = i +1; j < tamaño; j++)
                {
                    if (vector [j]< vector [minimo])
                    {
                        minimo = j;
                    }
                }
                aux = vector[i];
                vector[i] = vector[minimo];
                vector[minimo] = aux;
                
            }
            txtvector.Text += "Vector Ordenado" + Environment.NewLine;
            foreach (int vect in vector)
            {
                txtvector.Text += vect + Environment.NewLine;
            }
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            generarDatos(n);
            txtvector.Text += "Vector Desordenado" + Environment.NewLine;
            foreach (int vect in vector)
            {
                txtvector.Text += vect + Environment.NewLine;

            }
            ordenamientoseleccion(vector);
            contador.Restart();
            contador.Stop();
            lblod.Text = contador.Elapsed.TotalMilliseconds.ToString() + "Millisegundos";
            lblgd.Text = contador.Elapsed.TotalMilliseconds.ToString() + "Millisegundos";
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtvector.Clear();
            txttamaño.Clear();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
          Close();
        }
    }
}
