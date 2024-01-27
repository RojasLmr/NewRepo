using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
    }
        
        //Frm_Categoria frm1 = new Frm_Categoria();
        //frm1.MdiParent = this;
        //frm1.Show();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Supongamos que tienes un TextBox para el nombre de usuario y otro para la contraseña.
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Realiza la autenticación, por ejemplo, comparando con credenciales válidas.
            if (nombreUsuario == "Luis" && contraseña == "123")
            {
                // Las credenciales son válidas, así que puedes abrir el formulario principal.
                Frm_Principal r1 = new Frm_Principal();
                r1.ShowDialog();

                // Cierra el formulario de inicio de sesión
                this.Close();
            }
            else
            {
                // Las credenciales no son válidas, puedes mostrar un mensaje de error.
                MessageBox.Show("Credenciales incorrectas. Intente nuevamente.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
