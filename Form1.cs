using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreinosJC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbTipo.SelectedIndex = 2;

        }

        private TreinoJC[] arrayTreinos;
        private int contador = 0;

        public Form1(int tamanho)
        {
            InitializeComponent();
            arrayTreinos = new TreinoJC[tamanho];
        }

        private void btnAdc_Click(object sender, EventArgs e)
        {
            if (contador >= arrayTreinos.Length)
            {
                MessageBox.Show("Número máximo de treinos atingido!", "Limite Atingido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double dist = double.Parse(txtDist.Text);
            int min = int.Parse(txtDur.Text);
            string tipo = cmbTipo.SelectedItem.ToString();

            int segs = min * 60;

            arrayTreinos[contador] = new TreinoJC(dist, segs, tipo);

            contador++;

            MessageBox.Show($"Treino adicionado! ({contador}/{arrayTreinos.Length})", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMst_Click(object sender, EventArgs e)
        {
            lsvInfo.Items.Clear();

            for (int idx = 0; idx < contador; idx++)
            {
                TreinoJC treino = arrayTreinos[idx];
                ListViewItem linha = new ListViewItem(treino.p_TipoTreino);

                linha.SubItems.Add(treino.p_Distancia.ToString("F2") + " km");
                linha.SubItems.Add(treino.p_Duracao.ToString() + " seg");
                linha.SubItems.Add(treino.VelocidadeMedia().ToString("F2") + " km/h");

                lsvInfo.Items.Add(linha);
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int corrida = 0, caminhada = 0, misto = 0;

            for (int idx = 0; idx < contador; idx++)
            {
                if (arrayTreinos[idx].p_TipoTreino == "Corrida")
                {
                    corrida++;
                }
                else if (arrayTreinos[idx].p_TipoTreino == "Caminhada")
                {
                    caminhada++;
                }
                else
                {
                    misto++;
                }
            }

            MessageBox.Show($"Corrida: {corrida}\nCaminhada: {caminhada}\nMisto: {misto}", "Contagem de Treinos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                MessageBox.Show("Não Há Treinos!", "Sem Treinos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int totalSegs = 0;
            for(int idx = 0; idx < contador; idx++)
            {
                totalSegs += arrayTreinos[idx].p_Duracao;
            }

            int mediaSegs = totalSegs / contador;

            int horas = mediaSegs / 3600;
            int minutos = (mediaSegs % 3600) / 60;

            MessageBox.Show($"Duração Média: {horas}h {minutos}m", "Duração Média", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
