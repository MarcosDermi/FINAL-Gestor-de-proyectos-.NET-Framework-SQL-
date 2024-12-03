using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BE;
using BLL;
using TP_2___FInal.Clases.clsTareas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TP_2___FInal
{
    public partial class Informes : Form
    {
        public Informes()
        {
            InitializeComponent();
            oBEEquipo = new BEEquipo();
            oBLLEquipo = new BLLEquipo();
            oBEPrueba = new BEPrueba();
            oBLLPrueba = new BLLPrueba();
            oBEDesa = new BEDesarrollo(String.Empty);
            oBLLDesa = new BLLDesarrollo();
            
            oBEProyecto = new BEProyecto();
            oBLLProyecto = new BLLProyecto();
        }

        BEEquipo oBEEquipo;
        BLLEquipo oBLLEquipo;
        BEPrueba oBEPrueba;
        BLLPrueba oBLLPrueba;
        BEDesarrollo oBEDesa;
        BLLDesarrollo oBLLDesa;
        BETarea oBETarea;
        BLLTarea oBLLTarea;
        BEProyecto oBEProyecto;
        BLLProyecto oBLLProyecto;

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            try
            {
                List<BEEquipo> ListaEquipo = new List<BEEquipo>();
                ListaEquipo = oBLLEquipo.ListarTodo();
                
                lblTotal.Text = ListaEquipo.Count.ToString();

                CargarChartConListEquipo(ListaEquipo);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            try
            {
                
    

                List<BEPrueba> ListaPrueba = new List<BEPrueba>();
                ListaPrueba = oBLLPrueba.ListarTodo();

                List<BEDesarrollo> ListaDesa = new List<BEDesarrollo>();
                ListaDesa = oBLLDesa.ListarTodo();

                lblTotal.Text = "Pruebas: " + ListaPrueba.Count.ToString() + " Desarrollo: " + ListaDesa.Count.ToString();

                CargarChartConListasTareas(ListaPrueba, ListaDesa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<BEProyecto>ListaProyecto = new List<BEProyecto>();
                ListaProyecto = oBLLProyecto.ListarTodo();
                lblTotal.Text = ListaProyecto.Count.ToString();

                CargarChartConListProyecto(ListaProyecto);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void CargarChartConListEquipo(List<BEEquipo>ListaEquipo)
        {
            
            Dictionary<string, string> ListaDatos = new Dictionary<string, string>();
            
            foreach(BEEquipo oEquipo in ListaEquipo)
            {
                BEEquipo oEqui = new BEEquipo();
                oEqui = oEquipo;
                ListaDatos.Add(oEqui.Nombre, oEqui.Estado);
            }

            chart1.Titles.Clear();
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();

            Title Titulo = new Title("Reporte equipos total");
            Titulo.Font = new Font("Tahoma", 15, FontStyle.Bold);
            chart1.Titles.Add(Titulo);

            ChartArea Area = new ChartArea();
            Area.Area3DStyle.Enable3D = true;
            chart1.ChartAreas.Add(Area);

            Series serie = new Series("Equipo");
            serie.ChartType = SeriesChartType.Bubble;
            serie.Points.DataBindXY(ListaDatos.Keys, ListaDatos.Values);

            chart1.Series.Add(serie);
        }

        void CargarChartConListProyecto(List<BEProyecto> ListaProyecto)
        {

            Dictionary<string, string> ListaDatos = new Dictionary<string, string>();

            foreach (BEProyecto oProyecto in ListaProyecto)
            {
                BEProyecto oProy = new BEProyecto();
                oProy = oProyecto;
                ListaDatos.Add(oProy.Nombre, oProy.Equipo.Nombre);
            }

            chart1.Titles.Clear();
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();

            Title Titulo = new Title("Reporte proyectos total");
            Titulo.Font = new Font("Tahoma", 15, FontStyle.Bold);
            chart1.Titles.Add(Titulo);

            ChartArea Area = new ChartArea();
            Area.Area3DStyle.Enable3D = true;
            chart1.ChartAreas.Add(Area);
            Area.BackColor = Color.BlanchedAlmond;

            Series serie = new Series("Proyectos");
            serie.ChartType = SeriesChartType.Radar;
            serie.Points.DataBindXY(ListaDatos.Keys, ListaDatos.Values);

            chart1.Series.Add(serie);
        }

        void CargarChartConListasTareas(List<BEPrueba> ListaPrueba, List<BEDesarrollo> ListaDesa)
        {
            
            Dictionary<string, int> DatosPruebas = new Dictionary<string, int>();
            Dictionary<string, int> DatosDesarrollos = new Dictionary<string, int>();

            // Llenado de datos para Pruebas
            foreach (BEPrueba prueba in ListaPrueba)
            {
                string nombre = prueba.nombre;
                if (DatosPruebas.ContainsKey(nombre))
                    DatosPruebas[nombre]++;
                else
                    DatosPruebas[nombre] = 1;
            }

            // Llenado de datos para Desarrollo
            foreach (BEDesarrollo desarrollo in ListaDesa)
            {
                string nombre = desarrollo.nombre;
                if (DatosDesarrollos.ContainsKey(nombre))
                    DatosDesarrollos[nombre]++;
                else
                    DatosDesarrollos[nombre] = 1;
            }

            
            chart1.Titles.Clear();
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();

            Title titulo = new Title("Reporte de Tareas de Desarrollo y Pruebas");
            titulo.Font = new Font("Tahoma", 15, FontStyle.Bold);
            chart1.Titles.Add(titulo);

            ChartArea area = new ChartArea();
            area.Area3DStyle.Enable3D = true;
            area.AxisX.Title = "Tareas";
            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Enabled = false;
            area.AxisY.Enabled = AxisEnabled.False;
            chart1.ChartAreas.Add(area);

            //Pruebas
            Series seriePruebas = new Series("Pruebas");
            seriePruebas.ChartType = SeriesChartType.Column;
            seriePruebas.Points.DataBindXY(DatosPruebas.Keys, DatosPruebas.Values);
            seriePruebas.Color = Color.Blue;

            //Desarrollo
            Series serieDesarrollo = new Series("Desarrollo");
            serieDesarrollo.ChartType = SeriesChartType.Column;
            serieDesarrollo.Points.DataBindXY(DatosDesarrollos.Keys, DatosDesarrollos.Values);
            serieDesarrollo.Color = Color.Red;

           
            chart1.Series.Add(seriePruebas);
            chart1.Series.Add(serieDesarrollo);
        }
        private void Informes_Load(object sender, EventArgs e)
        {

        }

        void CambiarIdioma(string Cultura)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Cultura);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Cultura);

            label3.Text = Recursos.Recurso.Idioma;
            btnEquipos.Text = Recursos.Recurso.Equipos;
            btnTareas.Text = Recursos.Recurso.Tareas;
            button1.Text = Recursos.Recurso.Proyectos;
            this.Text = Recursos.Recurso.Informes;
            groupBox1.Text = Recursos.Recurso.Totales;
            

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
    }
}
