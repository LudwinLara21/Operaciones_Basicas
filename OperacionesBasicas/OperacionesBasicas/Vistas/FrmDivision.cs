using OperacionesBasicas.Entidades;
using OperacionesBasicas.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperacionesBasicas.Vistas
{
    public partial class FrmDivision : Form
    {
        public FrmDivision()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Operaciones operacion = new Operaciones();
            ClsOperaciones negocios = new ClsOperaciones();

            operacion.Dato1 = double.Parse(textDato1.Text);
            operacion.Dato2 = double.Parse(textDato2.Text);

            textResultado.Text = negocios.Division(operacion).ToString();
        }
    }
}
