using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;

namespace VisualizadorSocios
{
    public partial class FrmMenuEstadistica : Form
    {
        private Club club;
        private string rutaEscritorio;
        private string rutaArchivo;
        public FrmMenuEstadistica(Club club)
        {
            InitializeComponent();
            this.club = club;
            rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void btnGuardarInfo_Click(object sender, EventArgs e)
        {
            try
            {
                Archivadora.EscribirTxt(rutaArchivo, rtbInforme.Text);
                MessageBox.Show("Se genero el archivo");
            }
            catch (Exception)
            {
                MessageBox.Show("Se debe seleccionar anteriormente el informe a guardar");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            rtbInforme.Clear();

            if(club.ListadoSocios.Count != 0)
            {
                if (club.SociosActivos().Count != 0)
                {
                    switch (cmbListaEstadisticas.SelectedIndex)
                    {
                        case 0:
                            rtbInforme.Text = club.ListadoSociosTotales();
                            rutaArchivo = Path.Combine(rutaEscritorio, "Socios Totales.txt");
                            break;

                        case 1:
                            rtbInforme.Text = club.ListadoSociosActivos();
                            rutaArchivo = Path.Combine(rutaEscritorio, "Socios Activos.txt");
                            break;

                        case 2:
                            rtbInforme.Text = club.ListadoSociosSimples();
                            rutaArchivo = Path.Combine(rutaEscritorio, "Socios Simples.txt");
                            break;

                        case 3:
                            rtbInforme.Text = club.ListadoSociosCompletos();
                            rutaArchivo = Path.Combine(rutaEscritorio, "Socios Completos.txt");
                            break;

                        case 4:
                            rtbInforme.Text = club.ProvinciaMasSocios();
                            rutaArchivo = Path.Combine(rutaEscritorio, "Provincia con más socios.txt");
                            break;

                        case 5:
                            rtbInforme.Text = club.TribunaMasSocios();
                            rutaArchivo = Path.Combine(rutaEscritorio, "Tribuna con más socios.txt");
                            break;

                        case 6:
                            rtbInforme.Text = club.IngresosPorMes();
                            rutaArchivo = Path.Combine(rutaEscritorio, "Total de ingresos.txt");
                            break;
                    }
                }
                else
                {
                    rtbInforme.Text += "--Sin socios activos--";
                }
            }
            else
            {
                rtbInforme.Text += "--Sin socios registrados--";

            }

        }
    }
}
