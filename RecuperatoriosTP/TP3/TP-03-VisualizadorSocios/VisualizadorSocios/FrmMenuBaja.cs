using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VisualizadorSocios
{
    public partial class FrmMenuBaja : Form
    {
        private Club club;
        public FrmMenuBaja(Club club)
        {
            InitializeComponent();
            this.club = club;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Socio socio = club.BuscarSocio((int)numNumeroSocio.Value);
            try
            {
                if (socio != null)
                {
                    socio.Activo = false;
                    MessageBox.Show($"Se dio de baja el socio {socio.Mostrar()}");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se encontro socio con el número de id indicado");
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show($"No se pudo realizar la conexión con la Base de Datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void FrmMenuBaja_Load(object sender, EventArgs e)
        {
            rtbSocios.Text = club.ListadoSociosActivos();
        }
    }
}
