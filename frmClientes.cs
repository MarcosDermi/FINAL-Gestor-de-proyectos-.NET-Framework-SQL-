using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BE;
using BLL;

namespace TP_2___FInal
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            oBLLCliente = new BLLCliente();
            oBECliente = new BECliente();
        }

        BECliente oBECliente;
        BLLCliente oBLLCliente;
        private void btnCargarXML_Click(object sender, EventArgs e)
        {
            CargarDGV();
        }

        private void CargarDGV()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = oBLLCliente.LeerXML();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            try {
                string VerificarID = txtid.Text;
                bool respuestaID = Regex.IsMatch(VerificarID, "^([0-9]+$)");

                string VerificarNombre = txtNom.Text;
                bool respuestaNombre = Regex.IsMatch(VerificarNombre, @"^[a-zA-Z]+( [a-zA-Z]+)*$");

                string VerificarEmail = txtEmail.Text;
                bool respuestaEmail = Regex.IsMatch(VerificarEmail, "^([\\w-]+\\.)*?[\\w-]+@[\\w-]+\\.([\\w-]+\\.)*?[\\w]+$");

                string VerificarTell = txtTel.Text;
                bool respuestaTel = Regex.IsMatch(VerificarTell, @"^\+\d{2}\d{10}$");


                if (respuestaID == false)
                {
                    MessageBox.Show("Solo numeros", "ERROR");
                }if (respuestaNombre == false)
                {
                    MessageBox.Show("Ingrese nombre valido", "ERROR");
                }if(respuestaEmail == false)
                {
                    MessageBox.Show("Escriba el mail correctamente", "ERROR");
                }if(respuestaTel == false)
                {
                    MessageBox.Show("Escriba telefono correctamente", "ERROR");
                }
                else {
                    BECliente oCliente = new BECliente();
                    oCliente.ID = Convert.ToInt32(txtid.Text);
                    oCliente.Nombre = txtNom.Text;
                    oCliente.Contacto = txtContacto.Text;
                    oCliente.email = txtEmail.Text;
                    oCliente.telefono = txtTel.Text;

                    frmEquipos ofrmEquipo = new frmEquipos();
                    if (ofrmEquipo.ShowDialog() == DialogResult.OK) 
                        {
                        oCliente.Equipo = ofrmEquipo.EquipoSeleccionado;

                        oBLLCliente.AgregarXML(oCliente);
                    CargarDGV(); 
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        void CambiarIdioma(string Cultura)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Cultura);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Cultura);

            label4.Text = Recursos.Recurso.Nombre;
            label6.Text = Recursos.Recurso.Contacto;
            label8.Text = Recursos.Recurso.e_mail;
            label1.Text = Recursos.Recurso.Telefono;
            label3.Text = Recursos.Recurso.Idioma;
            this.Text = Recursos.Recurso.Titulo;
            groupBox1.Text = Recursos.Recurso.Titulo;
            groupBox2.Text = Recursos.Recurso.Agregar;
            btnAgregar.Text = Recursos.Recurso.Agregar;
            btnCargarXML.Text = Recursos.Recurso.Cargar_XML;

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(comboBox1.SelectedIndex.ToString());

            switch (A)
            {
                case 0:
                    CambiarIdioma("es-ES");
                    break;
                case 1:
                    CambiarIdioma("en-US");
                    break;
                case 2:
                    CambiarIdioma("it-IT");
                    break;
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    oBECliente = (BECliente)dataGridView1.CurrentRow.DataBoundItem;

                    if (oBECliente.ID == Convert.ToInt32(txtid.Text))
                    {
                        string VerificarID = txtid.Text;
                        bool respuestaID = Regex.IsMatch(VerificarID, "^([0-9]+$)");

                        string VerificarNombre = txtNom.Text;
                        bool respuestaNombre = Regex.IsMatch(VerificarNombre, @"^[a-zA-Z]+( [a-zA-Z]+)*$");

                        string VerificarEmail = txtEmail.Text;
                        bool respuestaEmail = Regex.IsMatch(VerificarEmail, "^([\\w-]+\\.)*?[\\w-]+@[\\w-]+\\.([\\w-]+\\.)*?[\\w]+$");

                        string VerificarTell = txtTel.Text;
                        bool respuestaTel = Regex.IsMatch(VerificarTell, @"^\+\d{2}\d{10}$");


                        if (respuestaID == false)
                        {
                            MessageBox.Show("Solo numeros", "ERROR");
                        }
                        if (respuestaNombre == false)
                        {
                            MessageBox.Show("Ingrese nombre valido", "ERROR");
                        }
                        if (respuestaEmail == false)
                        {
                            MessageBox.Show("Escriba el mail correctamente", "ERROR");
                        }
                        if (respuestaTel == false)
                        {
                            MessageBox.Show("Escriba telefono correctamente", "ERROR");
                        }
                        else
                        {

                            oBECliente.ID = Convert.ToInt32(txtid.Text);
                            oBECliente.Nombre = txtNom.Text;
                            oBECliente.Contacto = txtContacto.Text;
                            oBECliente.email = txtEmail.Text;
                            oBECliente.telefono = txtTel.Text;

                            frmEquipos ofrmEquipo = new frmEquipos();
                            if (ofrmEquipo.ShowDialog() == DialogResult.OK)
                            {
                                oBECliente.Equipo = ofrmEquipo.EquipoSeleccionado;

                                oBLLCliente.ModificarXML(oBECliente);
                                CargarDGV();
                            }

                            MessageBox.Show("Cliente modificado exitosamente.");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Ingrese el ID del cliente a modificar.");
                    }
                }
            }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { throw ex; }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    oBECliente = (BECliente)dataGridView1.CurrentRow.DataBoundItem;

                    if (oBECliente.ID == Convert.ToInt32(txtid.Text) && txtid.Text != string.Empty)
                    {


                        oBLLCliente.BajaXML(oBECliente);
                        CargarDGV();

                        MessageBox.Show("Cliente eliminado exitosamente.");
                    }
                    else
                    {
                        throw new ArgumentException("Debe ingresar el codigo correcto para el resumen seleccionado");
                    }
                }
            }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { throw ex; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text == string.Empty)
                {
                    MessageBox.Show("Escriba un numero de ID.");
                }
                else
                {

                    if (oBLLCliente.BuscarXML(txtid.Text) == true) { 
                    MessageBox.Show("Se encontro al cliente", "Buscar");
                    }
                    else
                    {
                     MessageBox.Show("No se encontro al cliente", "Buscar");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
