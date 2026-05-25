using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Individual_MZ.Formularios
{
    public partial class FormProductos : Form
    {
        string ruta = "Productos.csv";
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            ConfigurarTabla();
            CargarTabla();
        }
        private void ConfigurarTabla() 
        {
            dgvProductos.Columns.Clear();
            dgvProductos.Columns.Add("id", "ID");
            dgvProductos.Columns.Add("nombre", "Nombre");
            dgvProductos.Columns.Add("precio", "Precio");

            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.MultiSelect = false;
            dgvProductos.AllowUserToAddRows = false;
        }

        private List<Producto> LeerProductos(){ 
            
            var lista = new List<Producto>();

            if (!File.Exists(ruta)){
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

        private void CargarTabla()
        {
            dgvProductos.Rows.Clear();

            var lista = LeerProductos();

            foreach (var p in lista)
            {
                dgvProductos.Rows.Add(p.id, p.Nombre, p.Precio);
            }
        }

        private void btnAggPS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text)) {
                MessageBox.Show("Ingrese el nombre del producto.");
                return;
            }

            var lista = LeerProductos();

            int nuevoId;

            if (lista.Count > 0)
            {
                nuevoId = lista.Max(p => p.id) + 1;
            }
            else
            {
                nuevoId = 1;
            }

            string nombre = txtnombre.Text;
            int precio = (int)numprecio.Value;

            string linea = $"{nuevoId},{nombre},{precio}";

            File.AppendAllText(ruta, linea + "\n");

            CargarTabla();

            txtnombre.Clear();
            numprecio.Value = 1;
        }

        private void btnDltPS_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            int id = int.Parse(dgvProductos.CurrentRow.Cells[0].Value.ToString());

            var lista = LeerProductos();

            lista.RemoveAll(p => p.id == id);

            var lineas = new List<string>();
            lineas.Add("id,nombre,precio");

            foreach (var p in lista)
            {
                lineas.Add($"{p.id},{p.Nombre},{p.Precio}");
            }

            File.WriteAllLines(ruta, lineas);

            CargarTabla();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
