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

        }

        private void testeThread()
        {
            elevador.andarObjetivo = 2;
            elevador.mexerElevador();
            label1.Text = elevador.andarAtual.ToString();
        }

        private void botao0_Click(object sender, EventArgs e)
        {
            Limpar();
            botao0.BackColor = Color.Yellow;
            elevador.andarObjetivo = 0;
            elevador.mexerElevador();
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
            Limpar();
            botao1.BackColor = Color.Yellow;
            elevador.andarObjetivo = 1;
            elevador.mexerElevador();
            label1.Text = elevador.andarAtual.ToString();
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            Limpar();
            botao2.BackColor = Color.BlueViolet;
            Thread trd = new Thread(new ThreadStart(this.testeThread));
            trd.Start();
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            Limpar();
            botao3.BackColor = Color.BlueViolet;
            elevador.andarObjetivo = 3;
            elevador.mexerElevador();
            label1.Text = elevador.andarAtual.ToString();
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            Limpar();
            botao4.BackColor = Color.Yellow;
            elevador.andarObjetivo = 4;
            elevador.mexerElevador();
            label1.Text = elevador.andarAtual.ToString();
        }

    }
}
