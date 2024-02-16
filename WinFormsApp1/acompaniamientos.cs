using pedidos.Controlador;
using pedidos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class acompaniamientos : Form
    {
        private Form home;
        private List<ItemMenu> comidas;

        private PedidoController pedidoController = PedidoController.Instancia;

        public acompaniamientos(Form home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void acompaniamientos_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 5; i++)
            {
                comboBox1.Items.Add(i);
                comboBox2.Items.Add(i);
                comboBox3.Items.Add(i);
            }

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;

            comidas = pedidos.Resources.Datos.obtenerItemMenu();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro desea ir atrás? Perderá los cambios no guardados.", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                home.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((int)comboBox1.SelectedItem != 0)
            {
                int num1 = (int)comboBox1.SelectedItem;
                pedidoController.agregarItemMenu(comidas[3], num1);
            }

            if ((int)comboBox2.SelectedItem != 0)
            {
                int num2 = (int)comboBox2.SelectedItem;
                pedidoController.agregarItemMenu(comidas[4], num2);
            }

            if ((int)comboBox3.SelectedItem != 0)
            {
                int num3 = (int)comboBox3.SelectedItem;
                pedidoController.agregarItemMenu(comidas[5], num3);
            }

            home.Show();
            this.Close();
        }
    }
}
