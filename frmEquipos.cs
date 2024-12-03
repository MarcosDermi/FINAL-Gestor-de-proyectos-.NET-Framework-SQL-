using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_2___FInal
{
    public partial class frmEquipos : Form
    {
        public frmEquipos()
        {
            InitializeComponent();
            oBEEquipo = new BEEquipo();
            oBLLEquipo = new BLLEquipo();
        }

        public BEEquipo EquipoSeleccionado { get; private set; }
        BEEquipo oBEEquipo;
        BLLEquipo oBLLEquipo;
        private void frmEquipos_Load(object sender, EventArgs e)
        {
            CargarDGV();
        }

        void CargarDGV()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = oBLLEquipo.ListarTodo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                if(dataGridView1.SelectedRows.Count > 0) 
                {

                EquipoSeleccionado = (BEEquipo)dataGridView1.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un equipo.");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
