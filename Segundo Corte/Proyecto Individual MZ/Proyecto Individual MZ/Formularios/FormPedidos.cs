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
    public partial class FormPedidos : Form
    {
        string rutaPedidos = "pedidos.csv";
        string ruta = "Productos.csv";

        List<Producto> listaProductos = new List<Producto>();
        public FormPedidos()
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

            cmbProductos.DataSource = null;
            cmbProductos.DataSource = listaProductos;
            cmbProductos.DisplayMember = "Nombre";
        }

        
        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem is Producto p)
            {
                txtPrecio.Text = p.Precio.ToString();
            }
        }

        
        private void ConfigurarTabla()
        {
            dgvPedidos.Columns.Clear();

            dgvPedidos.Columns.Add("Cliente", "Cliente");
            dgvPedidos.Columns.Add("Producto", "Producto");
            dgvPedidos.Columns.Add("Precio", "Precio");
            dgvPedidos.Columns.Add("Cantidad", "Cantidad");

            dgvPedidos.ReadOnly = true;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.MultiSelect = false;
            dgvPedidos.AllowUserToAddRows = false;
        }

        
        private List<string[]> LeerPedidos()
        {
            var lista = new List<string[]>();

            if (!File.Exists(rutaPedidos))
            {
                File.WriteAllText(rutaPedidos, "cliente,producto,precio,cantidad\n");
            }

            var lineas = File.ReadAllLines(rutaPedidos);

            for (int i = 1; i < lineas.Length; i++)
            {
                lista.Add(lineas[i].Split(','));
            }

            return lista;
        }

        
        private void CargarPedidos()
        {
            dgvPedidos.Rows.Clear();

            var lista = LeerPedidos();

            foreach (var p in lista)
            {
                dgvPedidos.Rows.Add(p[0], p[1], p[2], p[3]);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text) || cmbProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            string cliente = txtCliente.Text;
            Producto p = (Producto)cmbProductos.SelectedItem;
            string producto = p.Nombre;
            string precio = txtPrecio.Text;
            int cantidad = (int)numCantidad.Value;

            string linea = $"{cliente},{producto},{precio},{cantidad}";

            File.AppendAllText(rutaPedidos, linea + "\n");

            CargarPedidos();

            txtCliente.Clear();
            cmbProductos.SelectedIndex = -1;
            txtPrecio.Clear();
            numCantidad.Value = 1;
        }

        private void FormPedidos_Load_1(object sender, EventArgs e)
        {
            CargarProductos();
            ConfigurarTabla();
            CargarPedidos();
        }

        private void btndlt_Click(object sender, EventArgs e)
        {

            if (dgvPedidos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un pedido");
                return;
            }

            string cliente = dgvPedidos.CurrentRow.Cells[0].Value.ToString();
            string producto = dgvPedidos.CurrentRow.Cells[1].Value.ToString();
            string precio = dgvPedidos.CurrentRow.Cells[2].Value.ToString();
            string cantidad = dgvPedidos.CurrentRow.Cells[3].Value.ToString();

            var lista = LeerPedidos();

            lista.RemoveAll(p =>
                p[0] == cliente &&
                p[1] == producto &&
                p[2] == precio &&
                p[3] == cantidad
            );

            List<string> lineas = new List<string>();
            lineas.Add("cliente,producto,precio,cantidad");

            foreach (var p in lista)
            {
                lineas.Add($"{p[0]},{p[1]},{p[2]},{p[3]}");
            }

            File.WriteAllLines(rutaPedidos, lineas);

            CargarPedidos();
        }
    }
}
