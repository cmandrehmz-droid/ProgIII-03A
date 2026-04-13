using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool IsValid = true;

            if(txtNombre.Text == "")
            {
                txtNombre.Visible = true;
                MessageBox.Show("El correo es obligatorio");
                
            }
            

            if(txtNota.Text == "")
            {
                txtNota.Visible=true;
                MessageBox.Show("La nota es Obligatoria");
                
            }
        }
    }
}
