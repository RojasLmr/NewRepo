using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.BLL;
using Ventas.Entities;

namespace Ventas.UI
{
    public partial class Frm_Roles : Form
    {
        public Frm_Roles()
        {
            InitializeComponent();
        }

        RolesBLL bll = new RolesBLL();
        Roles objRol = new Roles();

        private void Frm_Roles_Load(object sender, EventArgs e)
        {
            dataRoles.DataSource = bll.ListarRoles();
            this.dataRoles.Columns[0].Width = 30;
            this.dataRoles.Columns[1].Width = 80;
            this.dataRoles.Columns[2].Width = 150;
            this.dataRoles.Columns[3].Width = 30;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty)
            {
                dataRoles.DataSource = bll.ListarRoles();
            }
            else
            {
                dataRoles.DataSource = bll.FiltroNombre(txtBuscar.Text);
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Panel_Agregar.Visible = true;
            this.btn_Actualizar.Enabled = false;
            this.btn_Nuevo.Enabled = false;
            Limpiar();
        }
        void Limpiar()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            checkBox1.Checked = false;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Panel_Agregar.Visible = false;
            this.btn_Actualizar.Enabled = true;
            this.btn_Nuevo.Enabled = true;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (btn_Guardar.Text == "Guardar")
            {
                objRol.Nombre = txtNombre.Text;
                objRol.descripcion = txtDescripcion.Text;
                objRol.condicion = (this.checkBox1.Checked == true) ? true : false;

                try
                {
                    bll.Agregar(objRol);
                    MessageBox.Show("Se ha registrado un Nuevo Rol");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (btn_Guardar.Text == "Actualizar")
            {
                Roles rol = bll.Buscar(Convert.ToInt32(txtId.Text));
                rol.Nombre = txtNombre.Text;
                rol.descripcion = txtDescripcion.Text;
                rol.condicion = (this.checkBox1.Checked == true) ? true : false;

                try
                {
                    bll.Actualizar(rol);
                    MessageBox.Show("Se ha Actualizado la Categoria");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            Panel_Agregar.Visible = false;
            dataRoles.DataSource = bll.ListarRoles();
            this.btn_Actualizar.Enabled = true;
            this.btn_Nuevo.Enabled = true;

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            Panel_Agregar.Visible = true;
            btn_Guardar.Text = "Actualizar";
            txtId.Text = dataRoles.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dataRoles.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dataRoles.CurrentRow.Cells[2].Value.ToString();
            if (dataRoles.CurrentRow.Cells[3].Value is true)
            {
                this.checkBox1.Checked = true;
            }
            else
            {
                this.checkBox1.Checked = false;
            }

            this.btn_Actualizar.Enabled = false;
            this.btn_Nuevo.Enabled = false;
        }

       
    }
    }

