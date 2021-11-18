using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2_Elevador
{
    class Elevador
    {
        public int andarAtual = 0;
        public int andarObjetivo = 0;
        public Label label;
        public Elevador(ref Label label)
        {
            andarAtual = 0;
            this.label = label;
        }

        public void mexerElevador()
        {
            if (andarObjetivo != andarAtual)
            {
                //Subindo
                if (andarAtual < andarObjetivo)
                {
                    do
                    {
                        tempoMovimento();
                        ++andarAtual;
                        Parallel.Invoke(new Action(AtualizarAndar));

                    } while (andarAtual < andarObjetivo);
                }

                //Descendo
                if (andarAtual > andarObjetivo)
                {
                    do
                    {
                        tempoMovimento();
                        --andarAtual;
                        Parallel.Invoke(new Action(AtualizarAndar));

                    } while (andarAtual > andarObjetivo);
                }
            }
        }

        private void AtualizarAndar()
        {
            label.Text = andarAtual.ToString();
        }

        public void tempoMovimento()
        {
            var milliseconds = 1000;
            Thread.Sleep(milliseconds);
        }
    }
}
