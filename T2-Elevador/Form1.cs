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

        private void botao0_Click(object sender, EventArgs e)
        {
            elevador.andarObjetivo = 0;
            elevador.mexerElevador();
        }




        private void botao1_Click(object sender, EventArgs e)
        {
            elevador.andarObjetivo = 1;
            elevador.mexerElevador();
            label1.Text = elevador.andarAtual.ToString();
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            elevador.andarObjetivo = 2;
            elevador.mexerElevador();
            label1.Text = elevador.andarAtual.ToString();
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            elevador.andarObjetivo = 3;
            elevador.mexerElevador();
            label1.Text = elevador.andarAtual.ToString();
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            elevador.andarObjetivo = 4;
            elevador.mexerElevador();
            label1.Text = elevador.andarAtual.ToString();
        }
    }
}
