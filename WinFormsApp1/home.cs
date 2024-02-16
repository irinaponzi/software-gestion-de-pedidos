using pedidos.Controlador;
using pedidos.Entidades;
using pedidos.Logueo;
using pedidos.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class home : Form
    {

        private Form formularioPadre;

        private PedidoController pedidoController = PedidoController.Instancia;

        public home(Form formularioPadre)
        {
            InitializeComponent();
            this.formularioPadre = formularioPadre;
        }
        private void backtologinbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro desea ir atrás? Deberá iniciar sesión nuevamente.", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                formularioPadre.Show();
                this.Close();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

            var hamburguesas = new hamburguesas(this);
            hamburguesas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pedidoController.finalizarPedido();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();

            var acompaniamientos = new acompaniamientos(this);
            acompaniamientos.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();

            var bebidas = new bebidas(this);
            bebidas.Show();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar por completo el programa?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
