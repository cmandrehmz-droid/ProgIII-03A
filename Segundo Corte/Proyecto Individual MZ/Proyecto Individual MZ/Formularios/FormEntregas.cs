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
    public partial class FormEntregas : Form
    {
        string rutaEntregas = "entregas.csv";
        string ruta = "Productos.csv";

        List<Producto> listaProductos = new List<Producto>();
        public FormEntregas()
        {
            InitializeComponent();
        }

        private List<Producto> LeerProductos()
        {
            var lista = new List<Producto>();

            if (!File.Exists(ruta))
            {
                File.WriteAllText(ruta, "id,nombre,precio\n");
            }

            var lineas = File.ReadAllLines(ruta);

            for (int i = 1; i < lineas.Length; i++)
            {
                var datos = lineas[i].Split(',');

                lista.Add(new Producto(
                    int.Parse(datos[0]),
                    datos[1],
                    int.Parse(datos[2])
                ));
            }

            return lista;
        }

        private void CargarProductos()
        {
            listaProductos = LeerProductos();

            cmbEntregas.DataSource = null;
            cmbEntregas.DataSource = listaProductos;
            cmbEntregas.DisplayMember = "Nombre";
        }

        private void ConfigurarTabla()
        {
            dgvEntregas.Columns.Clear();

            dgvEntregas.Columns.Add("Producto", "Producto");
            dgvEntregas.Columns.Add("Cantidad", "Cantidad");

            dgvEntregas.ReadOnly = true;
            dgvEntregas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEntregas.MultiSelect = false;
            dgvEntregas.AllowUserToAddRows = false;
        }

        private List<string[]> LeerEntregas()
        {
            var lista = new List<string[]>();

            if (!File.Exists(rutaEntregas))
            {
                File.WriteAllText(rutaEntregas, "producto,cantidad\n");
            }

            var lineas = File.ReadAllLines(rutaEntregas);

            for (int i = 1; i < lineas.Length; i++)
            {
                lista.Add(lineas[i].Split(','));
            }

            return lista;
        }

        private void CargarEntregas()
        {
            dgvEntregas.Rows.Clear();

            var lista = LeerEntregas();

            foreach (var e in lista)
            {
                dgvEntregas.Rows.Add(e[0], e[1]);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            this.Hide();
            form.Show();
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            if (cmbEntregas.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtEntregas.Text))
            {
                MessageBox.Show("Complete los campos");
                return;
            }

            Producto p = (Producto)cmbEntregas.SelectedItem;
            string producto = p.Nombre;
            string cantidad = txtEntregas.Text;

            string linea = $"{producto},{cantidad}";

            File.AppendAllText(rutaEntregas, linea + "\n");

            CargarEntregas();

            cmbEntregas.SelectedIndex = -1;
            txtEntregas.Clear();
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            if (dgvEntregas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un pedido");
                return;
            }

            string producto = dgvEntregas.CurrentRow.Cells[0].Value.ToString();
            string cantidad = dgvEntregas.CurrentRow.Cells[1].Value.ToString();


            var lista = LeerEntregas();

            lista.RemoveAll(p =>
                p[0] == producto &&
                p[1] == cantidad 
            );

            List<string> lineas = new List<string>();
            lineas.Add("producto,cantidad");

            foreach (var p in lista)
            {
                lineas.Add($"{p[0]},{p[1]}");
            }

            File.WriteAllLines(rutaEntregas, lineas);

            CargarEntregas();
        }
        

        private void FormEntregas_Load(object sender, EventArgs e)
        {
            CargarProductos();
            ConfigurarTabla();
            CargarEntregas();
        }
    }
}
