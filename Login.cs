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
using BE;
using BLL;
using System.Text.RegularExpressions;
using System.Resources;
using System.Globalization;
using System.Threading;
using TP_2___FInal;

namespace TP_2___FInal
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
            oBEUsu = new BEUsuario();
            oBLLseg = new BLLSeguridad();
            oBLLUsuario = new BLLUsuario();
        }


        BEUsuario oBEUsu;
        BLLSeguridad oBLLseg;
        BLLUsuario oBLLUsuario;


        private void btnLogin_Click(object sender, EventArgs e)
        {
            oBEUsu.Usuario = txtUsuario.Text;
            oBEUsu.Pass = oBLLseg.ObtenerMD5(txtContrasena.Text);

            if (txtUsuario.Text.Length > 0)
            {
                bool respuesta = true;
                respuesta = Regex.IsMatch(txtUsuario.Text, "^([a-zA-Z]+$)");
                if (respuesta != true)
                {
                    MessageBox.Show("El nombre usuario solo debe ser texto", "Validacion ERROR");
                }
            }
            if (txtContrasena.Text.Length > 0)
            {
                    bool respuesta2 = true;
                    respuesta2 = Regex.IsMatch(txtContrasena.Text, "^([a-zA-Z0-9]+$)");
                    if (respuesta2 != true)
                    {
                        MessageBox.Show("Password error", "Validacion PASS ERROR");
                    }
            } 
            if (oBLLUsuario.Validar(oBEUsu))
            {
                    MessageBox.Show("bienvenido " + txtUsuario.Text);
                    Form1 form1 = new Form1();
                    form1.Show();

                    this.Hide();
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
    }

