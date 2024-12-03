using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using DAL;

namespace TP_2___FInal
{
    public partial class ADODesconectadoEmpleado : Form
    {
        public ADODesconectadoEmpleado()
        {
            InitializeComponent(); 
            
            oDatos = new DAL.Datos();
        }

        DataSet Ds = new DataSet();
        BE.BEEmpleado oEmpleado = new BE.BEEmpleado();
        BLL.BLLEmpleado oBLLEmpleado = new BLL.BLLEmpleado();
        DAL.Datos oDatos;

        public void CargarDGV()
        {
            Ds = oBLLEmpleado.Listar();
            DGV.DataSource = null;
            DGV.DataSource = Ds.Tables[0];
        }
        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            CargarDGV();
        }

        void Limpiar()
        {
            txtId.Text = null;
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtIDTarea.Text = null;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if ((txtNombre.Text == string.Empty) || (txtId.Text == string.Empty) || (txtApellido.Text == string.Empty))
            {
                MessageBox.Show("Debe completar los campos");
            }
            else
            {
                DataRow mDr2;
                mDr2 = Ds.Tables[0].NewRow();
                mDr2["Codigo"] = Convert.ToInt32(txtId.Text);
                mDr2["Nombre"] = txtNombre.Text.ToString();
                mDr2["Apellido"] = txtApellido.Text.ToString();
                if(txtIDTarea.Text != string.Empty) { 
                mDr2["CODTarea"] = Convert.ToInt32(txtIDTarea.Text);
                }
                else
                {
                    mDr2["CODTarea"] = DBNull.Value;
                }
                oDatos.AgregarEmpleado(Ds,mDr2);
                Limpiar();
            }
        }

        DataRow Dr;

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.DGV.SelectedCells.Count == 1) 
            {
                MessageBox.Show("Seleccione la fila que desea modificar");
            }
            else
            {
                Dr = ((DataRowView)this.DGV.SelectedRows[0].DataBoundItem).Row;
                Dr["Codigo"] = Convert.ToInt32(txtId.Text);
                Dr["Nombre"] = txtNombre.Text.ToString();
                Dr["Apellido"] = txtApellido.Text.ToString();
                Dr["CODTarea"] = Convert.ToInt32(txtIDTarea.Text);
            }

            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0)
            {
                MessageBox.Show("Seguro desea eliminar a " + DGV.SelectedRows[0].Cells[1].Value + " " + DGV.SelectedRows[0].Cells[2].Value + "?", "Eliminacion", MessageBoxButtons.YesNo);
                {
                    
                    DataRow Dr = ((DataRowView)this.DGV.SelectedRows[0].DataBoundItem).Row;
                    oDatos.EliminarEmpleado(Ds,Dr);

                }
            }
            Limpiar();
        }

        
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                oDatos.GuardarCambios(Ds);
            }catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            Ds.RejectChanges();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Ds.Tables[0].Rows.Clear();
            CargarDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable TablaTemp = Ds.Tables[0];
                DataView Dv = new DataView(TablaTemp);

                if (txtApeFiltro.Text != string.Empty)
                {
                    Dv.RowFilter = "Apellido = '" + txtApeFiltro.Text.Trim() + "'";

                    Dv.Sort = "Codigo";

                    DGVFiltrada.DataSource = null;
                    DGVFiltrada.DataSource = Dv;
                }
                else
                {
                    MessageBox.Show("Complete el campo con el apellido");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
