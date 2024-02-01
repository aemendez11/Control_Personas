using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Personas
{
    public partial class s : Form
    {


        Personas persona = new Personas();
        public s()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            persona.Dpi = textBoxDpi.Text;
            persona.Nombre = textBoxNombre.Text;
            persona.Apellido = textBoxApellido.Text;
            persona.FecNac1 = dateTimePicker1.Value;

        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            labelDpi.Text = persona.Dpi;
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;
            labelfecNAc.Text = persona.FecNac1.ToShortDateString();

            labelDpi.Visible = true;
            labelNombre.Visible = true;
            labelApellido.Visible = true;
            labelfecNAc.Visible = true;

        }

       
        private void buttonprimeraMayus_Click(object sender, EventArgs e)
        {
            persona.PrimeraMayuscula();
            int edad = persona.edad();
            persona.normalizar();
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;
            Edad.Visible = true;
            Edad.Text = edad.ToString();
        }
    }
}
