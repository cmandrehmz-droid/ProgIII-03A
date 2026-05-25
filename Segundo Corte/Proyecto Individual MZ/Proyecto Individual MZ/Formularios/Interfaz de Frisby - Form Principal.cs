using Proyecto_Individual_MZ.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Individual_MZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProductos  formProductos = new FormProductos();
            formProductos.Show();
            this.Hide();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            var formPedidos = new FormPedidos();
            formPedidos.Show();
            this.Hide();
        }

        private void btnEntregas_Click(object sender, EventArgs e)
        {
            var formEntregas = new FormEntregas();
            formEntregas.Show();
            this.Hide();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            var formInformes = new FormInformes();
            formInformes.Show();
            this.Hide();
        }
    }
}
