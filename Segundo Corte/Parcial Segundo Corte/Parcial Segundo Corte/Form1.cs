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

namespace Parcial_Segundo_Corte
{
    public partial class Form1 : Form
    {
        String ruta = "Registro.csv";
        List<Registro> listaRegistro = new List<Registro>();
        public Form1()
        {
            InitializeComponent();
        }

        public void Configurar_Tabla()
        {
            dgvRegistro.Columns.Clear();
            dgvRegistro.Columns.Add("id", "ID");
            dgvRegistro.Columns.Add("nombre", "Nombre");
            dgvRegistro.Columns.Add("apellido", "Apelido");
            dgvRegistro.Columns.Add("n*documento", "N*Documento");
            dgvRegistro.Columns.Add("f.ingreso", "F.Ingreso");
            dgvRegistro.Columns.Add("cargo", "Cargo");
            dgvRegistro.Columns.Add("salario", "Salario");


            dgvRegistro.ReadOnly = true;
            dgvRegistro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegistro.MultiSelect = false;
            dgvRegistro.AllowUserToAddRows = false;
        }

        private List<Registro> LeerRegistro()
        {

            var lista = new List<Registro>();

            if (!File.Exists(ruta))
            {
                File.WriteAllText(ruta, "id,nombre,apellido,n*documento,cargo,salario\n");

            }
            var lineas = File.ReadAllLines(ruta);

            for (int i = 1; i < lineas.Length; i++)
            {
                var datos = lineas[i].Split(',');

                lista.Add(new Registro(
                    int.Parse(datos[0]),
                    datos[1],
                    datos[2],
                    int.Parse(datos[3]),
                    datos[4],
                    int.Parse(datos[5])
                    
                ));
            }
            return lista;
        }

        private void CargarTabla()
        {
            dgvRegistro.Rows.Clear();

            var lista = LeerRegistro();

            foreach (var p in lista)
            {
                dgvRegistro.Rows.Add(p.ID,p.Nombre, p.Apellido, p.Ndocumento, p.Cargo, p.Salario);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Configurar_Tabla();
            CargarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Ingrese el Apellido.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtxDocumento.Text))
            {
                MessageBox.Show("Ingrese el Documento.");
                return;
            }

            var lista = LeerRegistro();

            int nuevoId;

            if (lista.Count > 0)
            {
                nuevoId = lista.Max(p => p.ID) + 1;
            }
            else
            {
                nuevoId = 1;
            }

            string nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string NDocumento = txtxDocumento.Text;
            string Cargo = txtCargo.Text;
            int Salario = (int)numSalario.Value;

            string linea = $"{nuevoId},{nombre},{Apellido},{NDocumento},{Cargo},,{Salario}";

            File.AppendAllText(ruta, linea + "\n");

            CargarTabla();

            
        }
    }
}
