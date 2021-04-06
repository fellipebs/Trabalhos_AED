using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Pratica5 {
    public partial class FormOrdenacao : Form {
        int[] vet = new int[500]; // vetor interno para a animação
        
        public FormOrdenacao() {
            InitializeComponent();
            panel.Paint += new PaintEventHandler(panel_Paint);
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel, new object[] { true });
        }

        private void panel_Paint(object sender, PaintEventArgs e) {
            for (int i = 0; i < vet.Length; i++) {
                e.Graphics.DrawLine(Pens.BlueViolet, i, 299, i, 299 - vet[i]);
            }
        }

        private void bolhaToolStripMenuItem_Click(object sender, EventArgs e) {
            iniciaAnimacao(() => OrdenacaoGrafica.Bolha(vet, panel));
        }

        // TODO: animação e estatísticas dos demais métodos de ordenação

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show(this, 
                "Métodos de Ordenação - 2020/1\n\nDesenvolvido por:\n72000422 - Fellipe Barcelos Saraiva\nProf. Virgílio Borges de Oliveira\n\nAlgoritmos e Estruturas de Dados\nFaculdade COTEMIG\nSomente para fins didáticos.", 
                "Sobre o trabalho...", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void iniciaAnimacao(Action a) {
            if (bgw.IsBusy != true) {
                if (rdbCresc.Checked == true)
                    Preenchimento.Crescente(vet);
                else if(rdbDesc.Checked == true)
                    Preenchimento.Decrescente(vet);
                else
                    Preenchimento.Aleatorio(vet, 299);

                bgw.RunWorkerAsync(a);
            }
            else {
                MessageBox.Show(this,
                   "Aguarde o fim da execução atual...",
                   "Métodos de Ordenação - 2020/1",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
            }
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e) {
            Action a = (Action)e.Argument;
            a();
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            MessageBox.Show(this,
               "Animação concluída!",
               "Métodos de Ordenação - 2020/1",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

        private void bolhaToolStripMenuItem1_Click_1(object sender, EventArgs e) {
            int tamanhovet = Convert.ToInt32(comboBox1.Text);
            int[] vetor = new int[tamanhovet]; // TODO (tamanho deverá ser escolhido pelo usuário)
            string auxPreenchi = "";
            int[] vetReturn = new int[2];
           

            if (rdbCresc.Checked == true) {
                Preenchimento.Crescente(vetor);
                auxPreenchi = "Crescente";
            }
            else if (rdbDesc.Checked == true) {
                Preenchimento.Decrescente(vetor);
                auxPreenchi = "Decrescente";
            }
            else {
                Preenchimento.Aleatorio(vetor, 1000);
                auxPreenchi = "Aleatório";
            }
           
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            vetReturn = OrdenacaoEstatistica.Bolha(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: "+ tamanhovet +
                  "\nOrdenação inicial: " + auxPreenchi +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: "+ vetReturn[0] +
                  "\nNº de trocas: " + vetReturn[1],
                  "Estatísticas do Método Bolha",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void seleçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.selecao(vet, panel));
        }

        private void inserçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.insercao(vet, panel));
        }

        private void shellsortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.shellSort(vet, panel));
        }

        private void quicksortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.quickSort(vet, 0, vet.Length - 1, panel));
        }

        private void heapsortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.heapSort(vet, panel));
        }

        private void mergesortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.mergeSort(vet, 0, vet.Length - 1, panel));
        }


        private void seleçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int tamanhovet = Convert.ToInt32(comboBox1.Text);
            int[] vetor = new int[tamanhovet]; // TODO (tamanho deverá ser escolhido pelo usuário)
            string auxPreenchi = "";
            int[] vetReturn = new int[2];

            if (rdbCresc.Checked == true)
            {
                Preenchimento.Crescente(vetor);
                auxPreenchi = "Crescente";
            }
            else if (rdbDesc.Checked == true)
            {
                Preenchimento.Decrescente(vetor);
                auxPreenchi = "Decrescente";
            }
            else
            {
                Preenchimento.Aleatorio(vetor, 1000);
                auxPreenchi = "Aleatório";
            }

            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            vetReturn = OrdenacaoEstatistica.selecao(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + tamanhovet +
                  "\nOrdenação inicial: " + auxPreenchi +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + vetReturn[0] +
                  "\nNº de trocas: " + vetReturn[1],
                  "Estatísticas do Método Seleção",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void inserçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int tamanhovet = Convert.ToInt32(comboBox1.Text);
            int[] vetor = new int[tamanhovet]; // TODO (tamanho deverá ser escolhido pelo usuário)
            string auxPreenchi = "";
            int[] vetReturn = new int[2];

            if (rdbCresc.Checked == true)
            {
                Preenchimento.Crescente(vetor);
                auxPreenchi = "Crescente";
            }
            else if (rdbDesc.Checked == true)
            {
                Preenchimento.Decrescente(vetor);
                auxPreenchi = "Decrescente";
            }
            else
            {
                Preenchimento.Aleatorio(vetor, 1000);
                auxPreenchi = "Aleatório";
            }

            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            vetReturn = OrdenacaoEstatistica.insercao(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + tamanhovet +
                  "\nOrdenação inicial: " + auxPreenchi +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + vetReturn[0] +
                  "\nNº de trocas: " + vetReturn[1],
                  "Estatísticas do Método Inserção",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);

        }

        private void shellsortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int tamanhovet = Convert.ToInt32(comboBox1.Text);
            int[] vetor = new int[tamanhovet]; // TODO (tamanho deverá ser escolhido pelo usuário)
            string auxPreenchi = "";
            int[] vetReturn = new int[2];

            if (rdbCresc.Checked == true)
            {
                Preenchimento.Crescente(vetor);
                auxPreenchi = "Crescente";
            }
            else if (rdbDesc.Checked == true)
            {
                Preenchimento.Decrescente(vetor);
                auxPreenchi = "Decrescente";
            }
            else
            {
                Preenchimento.Aleatorio(vetor, 1000);
                auxPreenchi = "Aleatório";
            }

            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            vetReturn = OrdenacaoEstatistica.shellSort(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + tamanhovet +
                  "\nOrdenação inicial: " + auxPreenchi +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + vetReturn[0] +
                  "\nNº de trocas: " + vetReturn[1],
                  "Estatísticas do Método Shellsort",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);

        }

        private void quicksortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int tamanhovet = Convert.ToInt32(comboBox1.Text);
            int[] vetor = new int[tamanhovet]; // TODO (tamanho deverá ser escolhido pelo usuário)
            string auxPreenchi = "";
            int[] vetReturn = new int[2];

            if (rdbCresc.Checked == true)
            {
                Preenchimento.Crescente(vetor);
                auxPreenchi = "Crescente";
            }
            else if (rdbDesc.Checked == true)
            {
                Preenchimento.Decrescente(vetor);
                auxPreenchi = "Decrescente";
            }
            else
            {
                Preenchimento.Aleatorio(vetor, 1000);
                auxPreenchi = "Aleatório";
            }

            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            vetReturn = OrdenacaoEstatistica.quickSortAux(vetor, 0, vet.Length - 1);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + tamanhovet +
                  "\nOrdenação inicial: " + auxPreenchi +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + vetReturn[0] +
                  "\nNº de trocas: " + vetReturn[1],
                  "Estatísticas do Método Quicksort",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void heapsortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int tamanhovet = Convert.ToInt32(comboBox1.Text);
            int[] vetor = new int[tamanhovet]; // TODO (tamanho deverá ser escolhido pelo usuário)
            string auxPreenchi = "";
            int[] vetReturn = new int[2];

            if (rdbCresc.Checked == true)
            {
                Preenchimento.Crescente(vetor);
                auxPreenchi = "Crescente";
            }
            else if (rdbDesc.Checked == true)
            {
                Preenchimento.Decrescente(vetor);
                auxPreenchi = "Decrescente";
            }
            else
            {
                Preenchimento.Aleatorio(vetor, 1000);
                auxPreenchi = "Aleatório";
            }

            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            vetReturn = OrdenacaoEstatistica.heapsortAux(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + tamanhovet +
                  "\nOrdenação inicial: " + auxPreenchi +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + vetReturn[0] +
                  "\nNº de trocas: " + vetReturn[1],
                  "Estatísticas do Método Heapsort",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void mergesortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int tamanhovet = Convert.ToInt32(comboBox1.Text);
            int[] vetor = new int[tamanhovet]; // TODO (tamanho deverá ser escolhido pelo usuário)
            string auxPreenchi = "";
            int[] vetReturn = new int[2];

            if (rdbCresc.Checked == true)
            {
                Preenchimento.Crescente(vetor);
                auxPreenchi = "Crescente";
            }
            else if (rdbDesc.Checked == true)
            {
                Preenchimento.Decrescente(vetor);
                auxPreenchi = "Decrescente";
            }
            else
            {
                Preenchimento.Aleatorio(vetor, 1000);
                auxPreenchi = "Aleatório";
            }

            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            vetReturn =  OrdenacaoEstatistica.mergeSortAux(vetor, 0, vetor.Length - 1);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + tamanhovet +
                  "\nOrdenação inicial: " + auxPreenchi +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                    "\nNº de comparações: " + vetReturn[0] +
                  "\nNº de trocas: " + vetReturn[1],
                  "Estatísticas do Método Mergesort",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void FormOrdenacao_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }
    }
}
