using RE_Cafeteria.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RE_Cafeteria
{
    public partial class ingresarUsuario : Form
    {
        public int id;
        public ingresarUsuario()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (id == 0)
            {
                if ((txtNombre.Text != "") && (txtApellidos.Text != "") && (txtUsuario.Text != "") && (txtPass.Text != ""))
                {
                    try
                    {

                        ESUsuario ESU = new ESUsuario(
                            txtNombre.Text,
                            txtApellidos.Text,
                            txtUsuario.Text,
                            txtPass.Text,
                           chkEstado.Checked
                            );
                        ESU.insertarusuario();

                        MessageBox.Show("Usuario Ingresado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar los campos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if ((txtNombre.Text != "") && (txtApellidos.Text != "") && (txtUsuario.Text != "") && (txtPass.Text != ""))
                {
                    try
                    {

                        ESUsuario ESU = new ESUsuario(
                            id,
                            txtNombre.Text,
                            txtApellidos.Text,
                            txtUsuario.Text,
                            txtPass.Text,
                           chkEstado.Checked
                            );
                        ESU.modificarusuario();

                        MessageBox.Show("Usuario modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {

                    }
                }
                else {
                    MessageBox.Show("Debe ingresar los campos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }



            this.Close();

        }

        private void ingresarUsuario_Load(object sender, EventArgs e)
        {
            if (id == 0)
            {
                button1.Text = "Ingresar";
            }
            else {
                button1.Text = "Modificar";
            }

        }
    }
}
