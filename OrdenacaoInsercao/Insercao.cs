using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrdenacaoInsercao
{
    public partial class Insercao : Form
    {
        Random random = new Random();

        int[] numerosInteiros = new int[50];
        int[] numerosOrdenados = new int[50];
        string[] stringSeparators = new string[] { "\r\n" };
        Boolean insereManual = true;

        public Insercao()
        {
            InitializeComponent();
        }

        private int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }


        static int[] OrdenarVetor(int[] vetor)
        {
            int i, aux, index;

            for (i = 1; i < vetor.Length; i++)
            {
                index = vetor[i];
                aux = i;
                while ((aux > 0) && (vetor[aux - 1] > index))
                {
                    vetor[aux] = vetor[aux - 1]; 
                    aux = aux - 1;  
                }
                vetor[aux] = index;
            }
            return vetor;
        }
        private void TempoExecucao(int[] vetor)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            OrdenarVetor(vetor);
            stopwatch.Stop();
            label3.Text = $"Tempo passado: {stopwatch.Elapsed.ToString()} ms";
            stopwatch.Restart();
            for (var i = 0; i < 1000; i++) OrdenarVetor(vetor);
            label3.Text = $"Tempo passado: {stopwatch.ElapsedTicks.ToString()} ms";
            stopwatch.Stop();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {

            btnOrdenar.Enabled = true;
            button1.Enabled = true;
            txtInteiros.Enabled = true;
            insereManual = false;
            for (int i = 1; i < numerosInteiros.Count() - 1; i++)
            {
                int returnValue = RandomNumber(1, 499);
                numerosInteiros[i] = returnValue;
                txtInteiros.AppendText(numerosInteiros[i].ToString() + "\r\n");
            }
            


        }

        private void LimparVetores()
        {
            int cont = 0;
            if (numerosInteiros.Length != 0)
            {
                for (int i = 2; i < numerosInteiros.Length; i++)
                    cont++;
                numerosInteiros[cont] = 0;
                numerosOrdenados[cont] = 0;
            }
            txtInteiros.Text = "";
            txtOrdenados.Text = "";
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string[] numerosTexto = new string[numerosInteiros.Count()];
            Boolean isRunning = true;
            if (txtInteiros.Text != "")
            {
                if (insereManual == true)
                {
                    for (int i = 2; i < numerosInteiros.Count() - 1; i++)
                    {
                        numerosTexto = txtInteiros.Text.Split(stringSeparators, StringSplitOptions.None);

                    }
                    try
                    {
                        numerosInteiros = numerosTexto.Select(int.Parse).ToArray();
                        isRunning = true;
                    }
                    catch
                    {
                        MessageBox.Show("Insira somente números inteiros. Um número por linha!");
                        isRunning = false;
                        txtInteiros.Text = "";
                    }
                }
                if (isRunning == true)
                {
                    TempoExecucao(numerosInteiros);
                    numerosOrdenados = OrdenarVetor(numerosInteiros);

                    for (int i = 2; i < numerosOrdenados.Length; i++)
                    {
                        txtOrdenados.AppendText($"{numerosOrdenados[i].ToString()}\r\n");
                    }
                    lblContadorRand.Text = numerosInteiros.Count().ToString();
                    lblContadorOrd.Text = numerosOrdenados.Count().ToString();

                }
            }
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            //LimparVetores();
            insereManual = true;
            txtInteiros.Enabled = true;
            btnOrdenar.Enabled=true;
            button1.Enabled = true;

        }

        private void Insercao_Load(object sender, EventArgs e)
        {
            txtInteiros.Enabled = false;
            btnOrdenar.Enabled = false;
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparVetores();
        }
    }
}
