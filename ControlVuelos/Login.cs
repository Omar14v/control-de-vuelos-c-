using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejemplo.Interfaz;

namespace Ejemplo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtContraseña.Text == "123")
            {
                MessageBox.Show("Inicio Exitoso");

                this.Hide();
                ControlVuelos nuevabase = new ControlVuelos();
                nuevabase.Show();
            }
            else
            {
                MessageBox.Show("Error al iniciar sesion, intente nuevamente");

                txtUser.Text = "";
                txtContraseña.Text = "";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
