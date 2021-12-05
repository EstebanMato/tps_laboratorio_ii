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

namespace VisualizadorSocios
{
    public partial class FrmSimulacionCarga : Form
    {
        public delegate void FinalizarCarga();
        public event FinalizarCarga finalizarCarga;
        public FrmSimulacionCarga()
        {
            InitializeComponent();
            
        }

        private void FrmSimulacionCarga_Load(object sender, EventArgs e)
        {
            finalizarCarga += FinDeCarga;
            progressBarCargando.Value = 0;
            Task hilo = Task.Run(() => IniciarCarga(progressBarCargando));
        }

        /// <summary>
        /// Se inicia la carga del ProgessBar
        /// </summary>
        /// <param name="barra"></param>
        private void IniciarCarga(ProgressBar barra)
        {
            try
            {
                while (progressBarCargando.Value < progressBarCargando.Maximum)
                {
                    IncrementarCarga(barra);
                }
                finalizarCarga.Invoke();
            }
            catch (Exception)
            {
                MessageBox.Show($"Se forzo el cierra de la carga. \nCorroborar inforamción cargada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        /// <summary>
        /// Aumenta el ProgressBar en 20 unidades, durmiendo el hilo 1 segundo
        /// </summary>
        /// <param name="barra"></param>
        private void IncrementarCarga(ProgressBar barra)
        {
            try
            {
                if (InvokeRequired)
                {
                    Action<ProgressBar> delegado = IncrementarCarga;
                    Thread.Sleep(1000);
                    Invoke(delegado, barra);
                }
                else
                {
                    progressBarCargando.Increment(20);
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }


        /// <summary>
        /// Informa la finalización de la carga
        /// </summary>
        private void FinDeCarga()
        {
            if (InvokeRequired)
            {
                Action delegado = FinDeCarga;
                Invoke(delegado);
            }
            else
            {
                MessageBox.Show("Se finalizo la carga");
                this.Close();
            }
        }
    }
}
