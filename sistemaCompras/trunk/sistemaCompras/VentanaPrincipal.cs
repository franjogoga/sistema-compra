﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sistemaCompras
{
    public partial class VentanaPrincipal : Form
    {
        
        public VentanaPrincipal()
        {
            InitializeComponent();
        }
        
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioDlg ventanaUsuarioDlg = new UsuarioDlg();
            ventanaUsuarioDlg.Show();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Console.Out.WriteLine("Hola mundo");
            //RegistrarProducto ap = new RegistrarProducto();
            //ap.Show();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistrarProyecto regProyecto = new RegistrarProyecto();
            regProyecto.ShowDialog();
            this.Hide();
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //EliminarProducto ep = new EliminarProducto();
            //ep.Show();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RegistrarProveedor regProveedor = new RegistrarProveedor();
            regProveedor.ShowDialog(this);
            regProveedor.referenciarVPrincipal(this);            
        }

        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ModificarProveedor modProveedor = new ModificarProveedor();
            modProveedor.ShowDialog(this);
            modProveedor.referenciarVPrincipal(this);
        }


    }
}
