﻿using OperacionesBasicas.Entidades;
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

namespace OperacionesBasicas
{
    public partial class FrmSuma : Form
    {
        public FrmSuma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operaciones operacion = new Operaciones();
            ClsOperaciones negocios = new ClsOperaciones();

            operacion.Dato1 = double.Parse(textDato1.Text);
            operacion.Dato2 = double.Parse(textDato2.Text);

            textResultado.Text = negocios.Suma(operacion).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operaciones operacion = new Operaciones();
            ClsOperaciones negocios = new ClsOperaciones();

            operacion.Dato1 = double.Parse(textDato1.Text);
            operacion.Dato2 = double.Parse(textDato2.Text);

            textResultado.Text = negocios.Resta(operacion).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Operaciones operacion = new Operaciones();
            ClsOperaciones negocios = new ClsOperaciones();

            operacion.Dato1 = double.Parse(textDato1.Text);
            operacion.Dato2 = double.Parse(textDato2.Text);

            textResultado.Text = negocios.Multiplicacion(operacion).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Operaciones operacion = new Operaciones();
            ClsOperaciones negocios = new ClsOperaciones();

            operacion.Dato1 = double.Parse(textDato1.Text);
            operacion.Dato2 = double.Parse(textDato2.Text);

            textResultado.Text = negocios.Division(operacion).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textDato1.Text = "  ";
            textDato2.Text = "  ";
            textResultado.Text = " "; 

        }

        private void FrmSuma_Load(object sender, EventArgs e)
        {

        }
    }
}
