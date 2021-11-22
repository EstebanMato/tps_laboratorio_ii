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
    public partial class FrmMenuAlta : Form
    {
        private Club club;

        public FrmMenuAlta(Club club)
        {
            InitializeComponent();
            this.club = club;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            double valorCuota=0;
            EProvincia provincia = GetProvinciaSeleccionada();
            string sexo = " ";
            if(txtNombre.Text != string.Empty && txtApellido.Text != string.Empty && txtDni.Text != string.Empty && cmbProvincia.SelectedItem != null && cmbTipoSocio.SelectedItem != null)
            {
                if(cmbTipoSocio.SelectedIndex == 0)
                {
                    valorCuota = 500;
                }
                else
                {
                    valorCuota = 1500;
                }

                if(rbtnMasculino.Checked)
                {
                    sexo = "M";
                }
                else
                {
                    sexo = "F";
                }

                switch (cmbTipoSocio.SelectedIndex)
                {
                    case 0:
                        Simple socioSimple = new Simple(txtNombre.Text, txtApellido.Text, txtDni.Text, provincia, sexo, (int)Math.Truncate(numupEdad.Value), club.ProximoNumeroSocio(), valorCuota, DateTime.Now, true);
                        club += socioSimple;
                        break;
                    case 1:
                        ETribuna tribuna = GetTribunaSeleccionada();
                        Completo socioCompleto = new Completo(txtNombre.Text, txtApellido.Text, txtDni.Text, provincia, sexo,(int)Math.Truncate(numupEdad.Value), club.ProximoNumeroSocio(), valorCuota, tribuna, (int)numudDescuento.Value, DateTime.Now, true);
                        club += socioCompleto;
                        break;
                    default:
                        break;
                }
                MessageBox.Show("Se generó el alta correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("ERROR. Faltan datos del socio para dar el alta");
            }
        }

        /// <summary>
        /// Retorna la tribuna seleccionda en el ComboBox, en caso de no haber selección
        /// Setea genericamente ETribuna.Centenario
        /// </summary>
        /// <returns></returns>
        private ETribuna GetTribunaSeleccionada()
        {
            foreach(ETribuna tribuna in Enum.GetValues(typeof(ETribuna)))
            {
                if((int)tribuna == cmbTribuna.SelectedIndex)
                {
                    return tribuna;
                }
            }
            return ETribuna.Centenario;
        }


        /// <summary>
        /// Retorna la provincia seleccionda en el ComboBox, en caso de no haber selección
        /// Setea genericamente EProvincia.BuenosAires
        /// </summary>
        /// <returns></returns>
        private EProvincia GetProvinciaSeleccionada()
        {
            foreach (EProvincia provincia in Enum.GetValues(typeof(EProvincia)))
            {
                if ((int)provincia == cmbProvincia.SelectedIndex)
                {
                    return provincia;
                }
            }
            return EProvincia.BuenosAires;
        }

        private void cmbTipoSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoSocio.SelectedIndex == 1)
                grpbSocioCompleto.Enabled = true;
            else
                grpbSocioCompleto.Enabled = false;
        }
    }
}
