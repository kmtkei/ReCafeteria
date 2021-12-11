using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RE_Cafeteria
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                Principal pri = new Principal();
                MessageBox.Show("Bienvenido "+textBox2.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pri.ShowDialog();
            }
            else {
                MessageBox.Show("Debe ingresar ambos campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
