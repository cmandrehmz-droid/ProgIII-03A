using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Individual_MZ.Formularios
{
    public partial class FormInformes : Form
    {
        string rutaPedidos = "pedidos.csv";
        string rutaEntregas = "entregas.csv";
        public FormInformes()
        {
            InitializeComponent();
        }

        private void FormInformes_Load(object sender, EventArgs e)
        {
            ConfigurarTabla();
            CargarInforme();
        }

        private void ConfigurarTabla()
        {
            dgvInformes.Columns.Clear();

            dgvInformes.Columns.Add("Producto", "Producto");
            dgvInformes.Columns.Add("Pedidos", "Pedidos");
            dgvInformes.Columns.Add("Entregas", "Entregas");
            dgvInformes.Columns.Add("Pendiente", "Pendiente");

            dgvInformes.ReadOnly = true;
            dgvInformes.AllowUserToAddRows = false;
        }

        private List<string[]> LeerPedidos()
        {
            var lista = new List<string[]>();

            if (!File.Exists(rutaPedidos))
                return lista;

            var lineas = File.ReadAllLines(rutaPedidos);

            for (int i = 1; i < lineas.Length; i++)
            {
                var d = lineas[i].Split(',');
                lista.Add(new string[] { d[1], d[3] }); 
            }

            return lista;
        }

        private List<string[]> LeerEntregas()
        {
            var lista = new List<string[]>();

            if (!File.Exists(rutaEntregas))
                return lista;

            var lineas = File.ReadAllLines(rutaEntregas);

            for (int i = 1; i < lineas.Length; i++)
            {
                lista.Add(lineas[i].Split(','));
            }

            return lista;
        }

        private void CargarInforme()
        {
            dgvInformes.Rows.Clear();

            var pedidos = LeerPedidos();
            var entregas = LeerEntregas();

            var productos = pedidos.Select(p => p[0]).Distinct();

            foreach (var prod in productos)
            {
                int totalPedidos = pedidos
                    .Where(p => p[0] == prod)
                    .Sum(p => int.Parse(p[1]));

                int totalEntregas = entregas
                    .Where(e => e[0] == prod)
                    .Sum(e => int.Parse(e[1]));

                int pendiente = totalPedidos - totalEntregas;

                dgvInformes.Rows.Add(prod, totalPedidos, totalEntregas, pendiente);
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
