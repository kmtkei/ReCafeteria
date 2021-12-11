using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RE_Cafeteria.Modelo;
using RE_Cafeteria.Controlador;

namespace RE_Cafeteria
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingresarUsuario nuevo = new ingresarUsuario();
            nuevo.ShowDialog();
            MostrarUsuarios();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        public void MostrarUsuarios() {
            DataTable DT = new DataTable();
            BDUsuario bdu = new BDUsuario();
            bdu.mostrar(ref DT);
            dataGridView1.DataSource = DT;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1[0, dataGridView1.CurrentRow.Index].Value;
            ESUsuario usuarioeliminar = new ESUsuario();
            usuarioeliminar.eliminarusuario(id);
            MostrarUsuarios();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1[0, dataGridView1.CurrentRow.Index].Value;
            ingresarUsuario modificar = new ingresarUsuario();
            modificar.txtNombre.Text = dataGridView1[1,dataGridView1.CurrentRow.Index].Value.ToString();
            modificar.txtApellidos.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            modificar.txtUsuario.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            modificar.txtPass.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            bool estado = (bool)dataGridView1[5, dataGridView1.CurrentRow.Index].Value;
            if (estado)
            {
                modificar.chkEstado.Checked = true;
            }
            else {
                modificar.chkEstado.Checked = false;
            }
            modificar.id = id;
            modificar.ShowDialog();
            MostrarUsuarios();
        }
    }
}
