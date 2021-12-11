using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2_Elevador
{
    public partial class Form1 : Form
    {
        Elevador elevador;
        bool parar = false;
        public Form1()
        {
            InitializeComponent();
            elevador = new Elevador(ref label1);
            elevador.andarAtual = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            parar = !parar;
        }

        private void testeThread()
        {
            elevador.andarObjetivo = 2;

            elevador.mexerElevador();



        }

        private void botao0_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                elevador.andarObjetivo = 0;
                Limpar();
                botao0.BackColor = Color.BlueViolet;
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
            }
            
        }


        private void Limpar()
        {
            botao0.BackColor = Color.White;
            botao1.BackColor = Color.White;
            botao2.BackColor = Color.White;
            botao3.BackColor = Color.White;
            botao4.BackColor = Color.White;
        }


        private void botao1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                elevador.andarObjetivo = 1;
                Limpar();
                botao1.BackColor = Color.BlueViolet;
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
            }

            
        }
        private void botao0Movimentar()
        {

            elevador.andarObjetivo = 0;
            Limpar();
            botao0.BackColor = Color.BlueViolet;
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();

        }

        private void botao1Movimentar()
        {
            
                elevador.andarObjetivo = 1;
                Limpar();
                botao1.BackColor = Color.BlueViolet;
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
            
        }
        private void botao2Movimentar()
        {

            elevador.andarObjetivo = 2;
            Limpar();
            botao1.BackColor = Color.BlueViolet;
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();

        }
        private void botao3Movimentar()
        {

            elevador.andarObjetivo = 3;
            Limpar();
            botao3.BackColor = Color.BlueViolet;
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();

        }
        private void botao4Movimentar()
        {

            elevador.andarObjetivo = 4;
            Limpar();
            botao4.BackColor = Color.BlueViolet;
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();

        }

        //private void botao2_Click(object sender, EventArgs e)
        //{
        //    Limpar();
        //    botao2.BackColor = Color.BlueViolet;

        //    do
        //    {
        //        Thread trd = new Thread(new ThreadStart(this.testeThread));
        //         trd.Start();
        //        label1.Text = (elevador.andarAtual + 1).ToString();
        //        label1.Invalidate();
        //        label1.Update();
        //        label1.Refresh();
        //    }
        //    while (elevador.andarAtual < elevador.andarObjetivo);


        //}

        private void botao2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                elevador.andarObjetivo = 2;
                Limpar();
                botao2.BackColor = Color.BlueViolet;
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
            }
            
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            
                while (elevador.andarAtual != elevador.andarObjetivo)
                {
                    if (!parar) {
                        elevador.mexerElevador();
                        backgroundWorker1.ReportProgress(0, elevador.andarAtual.ToString());
                        System.Threading.Thread.Sleep(1500);
                    }
                    

                }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            label1.Text = (string)e.UserState;
        }
        private void botao3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                elevador.andarObjetivo = 3;
                Limpar();
                botao3.BackColor = Color.BlueViolet;
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
            }

            
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                elevador.andarObjetivo = 4;
                Limpar();
                botao4.BackColor = Color.BlueViolet;
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
            }
         
        }

        private void backgroundWorker1_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Parada !!");
            }
            else
            {
                MessageBox.Show("Chegada !!");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = true;
            Random randNum = new Random();
            int numero;
            do
            {
                 numero = randNum.Next(4);
                if (numero != elevador.andarAtual)
                    break;
            } while (true);
            elevador.andarObjetivo = numero;

            switch (numero)
            {
                case 0:
                    botao0Movimentar();
                    break;
                case 1:
                    botao1Movimentar();
                    break;
                case 2:
                    botao2Movimentar();
                    break;
                case 3:
                    botao3Movimentar();
                    break;
                case 4:
                    botao4Movimentar();
                    break;


            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = false;
        }
    }
}
