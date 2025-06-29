﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaVista
{
    public partial class FrmNuevaCate : Form
    {
        CL_Metodos metodos = new CL_Metodos();
        public FrmNuevaCate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre de la nueva categoria");
                return;
            }
            try
            {
                MessageBox.Show(metodos.InsertarCate(textBox2.Text));
                textBox2.Text = "";
                textBox2.Focus();
            }
            catch
            {
                MessageBox.Show("Error al contactar con la Base de Datos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
