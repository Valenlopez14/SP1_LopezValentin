﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pry.SP1.LopezValentin
{
    public partial class frmCultivos : Form
    {
        public frmCultivos()
        {
            InitializeComponent();
        }
        

        private void cmdCrear_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Archivo creado con éxito.");
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {

            StreamWriter cultivos = new StreamWriter("./Cultivos.txt", true);
            cultivos.WriteLine(mskCultivos.Text+" " + txtCultivo.Text); 
            MessageBox.Show("Cultivo cargado con éxito.");
            cultivos.Close();
            txtCultivo.Text = "";
            mskCultivos.Text = "";
        }

        private void frmCultivos_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            File.Delete("./Cultivos.txt");
            MessageBox.Show("Archivo borrado con éxito.");
        }
    }
}
