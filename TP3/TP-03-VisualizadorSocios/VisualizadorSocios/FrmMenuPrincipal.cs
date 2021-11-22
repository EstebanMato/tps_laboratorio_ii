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
using Entidades;
using System.IO;

namespace VisualizadorSocios
{
    public partial class FrmMenuPrincipal : Form
    {
        private Club club;
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;
        string archivo;
        string rutaEscritorio;
        string rutaArchivo;
        private FrmMenuAlta frmMenuAlta;
        private FrmMenuEstadistica frmMenuEstadistica;
        private FrmMenuBaja frmMenuBaja;
        private FrmSimulacionCarga frmSimulacionCarga;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            //frmSimulacionCarga = new FrmSimulacionCarga();
            this.club = new Club("River plate");
            rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }


        private void btnAltaSocio_Click(object sender, EventArgs e)
        {
            frmMenuAlta = new FrmMenuAlta(club);
            frmMenuAlta.ShowDialog();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            frmMenuEstadistica = new FrmMenuEstadistica(club);
            frmMenuEstadistica.ShowDialog();
        }
        private void GuardarTxtStripMenuItem_Click(object sender, EventArgs e)
        {
            rutaArchivo = Path.Combine(rutaEscritorio, "Listado socios.txt");
            StringBuilder sb = new StringBuilder();
            sb.Append($"-- {club.Nombre} --");
            sb.Append($"{club.ListadoSociosActivos()}");
            Archivadora.EscribirTxt(rutaArchivo, sb.ToString());
            MessageBox.Show("Se genero el archivo");
        }

        private void GuardarXmlStripMenuItem_Click(object sender, EventArgs e)
        {
            rutaArchivo = Path.Combine(rutaEscritorio, "Listado Socios.xml");
            Archivadora.SerializarXml<List<Socio>>(club.ListadoSocios, rutaArchivo);
            MessageBox.Show("Se genero el archivo");
        }

        private void AbrirTxtStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    archivo = openFileDialog.FileName;
                    MessageBox.Show(Archivadora.LeerTxt(archivo));
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo abrir el archivo o se cancelo la operación");
            }
        }

        private void AbrirXmlStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    archivo = openFileDialog.FileName;
                    club.ListadoSocios = Archivadora.DeserializarXml<List<Socio>>(archivo);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo abrir el archivo o se cancelo la operación");
            }
        }

        private void btnBajaSocio_Click(object sender, EventArgs e)
        {
            frmMenuBaja = new FrmMenuBaja(club);
            frmMenuBaja.ShowDialog();
        }

        private void GuardarDBStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarCargaEnCurso(frmSimulacionCarga);
                frmSimulacionCarga = new FrmSimulacionCarga();
                Task.Run(() => frmSimulacionCarga.ShowDialog());

                foreach (Socio socio in club.ListadoSocios)
                {
                    SocioDAO.Guardar(socio);
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Hay una carga en curso actualmente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void AbrirDBStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarCargaEnCurso(frmSimulacionCarga);
                frmSimulacionCarga = new FrmSimulacionCarga();

                Task.Run(() => frmSimulacionCarga.ShowDialog());
                club.ListadoSocios = SocioDAO.Leer();
            }
            catch(Exception)
            {
                MessageBox.Show($"Hay una carga en curso actualmente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void VerificarCargaEnCurso(FrmSimulacionCarga frmSimulacionCarga)
        {
            if(frmSimulacionCarga is not null)
            {
                if(frmSimulacionCarga.Visible)
                {
                    throw new CargaEnCursoException();
                }
            }
        }
    }
}
