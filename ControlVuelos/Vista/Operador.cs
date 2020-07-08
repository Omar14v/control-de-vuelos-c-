using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejemplo.BO;
using Ejemplo.DAO;

namespace Ejemplo.Interfaz
{
    public partial class Operador : UserControl
    {
        UsuarioBO objeus = new UsuarioBO();
        UsuarioDAO BD = new UsuarioDAO();

        public Operador()
        {
            InitializeComponent();
        }

        private void Operador_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        public void actualizar()
        {
            dgvAgregar.DataSource = BD.MostrarDatos().Tables[0];
        }


        private void dgvAgregar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int filas = e.RowIndex;
            txtCodigo.Text = dgvAgregar.Rows[filas].Cells[0].Value.ToString();
            txtOrigen.Text = dgvAgregar.Rows[filas].Cells[1].Value.ToString();
            txtDestino.Text = dgvAgregar.Rows[filas].Cells[2].Value.ToString();
            txtTipo.Text = dgvAgregar.Rows[filas].Cells[3].Value.ToString();
            dtDespegue.Text = dgvAgregar.Rows[filas].Cells[4].Value.ToString();
            dtAterrizaje.Text = dgvAgregar.Rows[filas].Cells[5].Value.ToString();
            txtEstado.Text = dgvAgregar.Rows[filas].Cells[6].Value.ToString();
            txtHoraDespegue.Text = dgvAgregar.Rows[filas].Cells[7].Value.ToString();
            txtHoraAterrizaje.Text = dgvAgregar.Rows[filas].Cells[8].Value.ToString();

        }

        public void limpiar()
        {
            txtCodigo.Text = "";
            txtOrigen.Text = "";
            txtDestino.Text = "";
            txtTipo.Text = "";
            //txtDespegue.Text = "";
            dtAterrizaje.Text = "";
            txtEstado.Text = "";
            txtHoraDespegue.Text = "";
            txtHoraAterrizaje.Text = "";
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            objeus.ciudad1 = txtOrigen.Text;
            objeus.ciudad2 = txtDestino.Text;
            objeus.tipo = txtTipo.Text;
            objeus.fecha1 = dtDespegue.Text;
            objeus.fecha2 = dtAterrizaje.Text;
            objeus.estado = txtEstado.Text;
            objeus.hora1 = txtHoraDespegue.Text;
            objeus.hora2 = txtHoraAterrizaje.Text;

            BD.Agregar(objeus);
            actualizar();
            MessageBox.Show("Datos Agregados Correctamente");
            limpiar();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            objeus.codigo = Convert.ToInt32(txtCodigo.Text);
            objeus.ciudad1 = txtOrigen.Text;
            objeus.ciudad2 = txtDestino.Text;
            objeus.tipo = txtTipo.Text;
            objeus.fecha1 = dtDespegue.Text;
            objeus.fecha2 = dtAterrizaje.Text;
            objeus.estado = txtEstado.Text;
            objeus.hora1 = txtHoraDespegue.Text;
            objeus.hora2 = txtHoraAterrizaje.Text;
            BD.Modificar(objeus);
            actualizar();
            limpiar();
            MessageBox.Show("Los Datos Fueron Actualizados Correctamente");
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            objeus.codigo = Convert.ToInt32(txtCodigo.Text);
            BD.Eliminar(objeus);
            actualizar();
            limpiar();
            MessageBox.Show("Los Datos Fueron Eliminados Correctamente");
        }

        private void Control_Load(object sender, EventArgs e)
        {

        }
    }
}
