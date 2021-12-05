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
using System.Text.Json;
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
            try
            {
                VerificarCargaEnCurso(frmSimulacionCarga);
                if (club.CantSociosTotales() != 0)
                {
                    rutaArchivo = Path.Combine(rutaEscritorio, "Listado Socios.xml");
                    Archivadora.SerializarXml<List<Socio>>(club.ListadoSocios, rutaArchivo);
                    frmSimulacionCarga = new FrmSimulacionCarga();
                    Task.Run(() => frmSimulacionCarga.ShowDialog());
                }
                else
                {
                    throw new SinSociosException();
                }

            }
            catch (CargaEnCursoException)
            {
                MessageBox.Show($"Hay una carga en curso actualmente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SinSociosException)
            {
                MessageBox.Show($"Sin socios para guardar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void GuardarJsonStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarCargaEnCurso(frmSimulacionCarga);
                if (club.CantSociosTotales() != 0)
                {
                    rutaArchivo = Path.Combine(rutaEscritorio, "Listado Socios.json");
                    
                    Archivadora.SerializarJson<List<Socio>>(club.ListadoSocios, rutaArchivo);

                    frmSimulacionCarga = new FrmSimulacionCarga();
                    Task.Run(() => frmSimulacionCarga.ShowDialog());
                }
                else
                {
                    throw new SinSociosException();
                }

            }
            catch (CargaEnCursoException)
            {
                MessageBox.Show($"Hay una carga en curso actualmente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SinSociosException)
            {
                MessageBox.Show($"Sin socios para guardar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                throw;
            }
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
                    VerificarCargaEnCurso(frmSimulacionCarga);
                    archivo = openFileDialog.FileName;
                    frmSimulacionCarga = new FrmSimulacionCarga();
                    List<Socio> socioAux = Archivadora.DeserializarXml<List<Socio>>(archivo);
                    foreach(Socio socio in socioAux)
                    {
                        club+=socio;
                        SocioDAO.Guardar(socio);
                    }
                    if(club.ListadoSocios == default)
                    {
                        MessageBox.Show("Formato incorrecto de archivo para carga");
                    }
                    else
                    {
                        Task.Run(() => frmSimulacionCarga.ShowDialog());
                    }
                }
                catch (CargaEnCursoException)
                {
                    MessageBox.Show($"Hay una carga en curso actualmente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void AbrirJsonStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    VerificarCargaEnCurso(frmSimulacionCarga);
                    archivo = openFileDialog.FileName;
                    
                    List<Socio> socioAux = Archivadora.DeserializarJson<List<Socio>>(archivo);
                    
                    foreach (Socio socio in socioAux)
                    {
                        club.ListadoSocios.Add(socio);
                        SocioDAO.Guardar(socio);
                    }
                    frmSimulacionCarga = new FrmSimulacionCarga();
                    Task.Run(() => frmSimulacionCarga.ShowDialog());
                    
                }
                catch (CargaEnCursoException)
                {
                    MessageBox.Show($"Hay una carga en curso actualmente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.Text.Json.JsonException)
                {
                    MessageBox.Show($"Error en la carga del archivo, formato invalido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception)
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

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                club.ListadoSocios = SocioDAO.Leer();
            }

            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show($"No se pudo realizar la conexión con la Base de Datos.", "ERROR - SIN ACCESO A LA BASE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

       
    }
}
