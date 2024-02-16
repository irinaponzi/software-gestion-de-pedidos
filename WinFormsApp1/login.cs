using pedidos.Entidades;
using pedidos.Logueo;
using System.Drawing;

namespace WinFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.FromArgb(250, 214, 165);
            panel3.BackColor = Color.FromArgb(250, 214, 165);

            textBox2.BackColor = Color.Bisque;
            panel4.BackColor = Color.Bisque;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.FromArgb(250, 214, 165);
            panel4.BackColor = Color.FromArgb(250, 214, 165);

            textBox1.BackColor = Color.Bisque;
            panel3.BackColor = Color.Bisque;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = new LogIn();
            bool validacion = login.validarUsuario(textBox1.Text, textBox2.Text);

            if (validacion)
            {
                MessageBox.Show("¡Bienvenido de nuevo, " + textBox1.Text + "!");
                this.Hide();

                var pedidos = new home(this);
                pedidos.Show();
            }
            else
            {
                MessageBox.Show("El usuario y/o contraseña son incorrectos.");
            }
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
