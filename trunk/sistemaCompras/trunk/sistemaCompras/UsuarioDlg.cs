﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Beans;
using Gestores;

namespace sistemaCompras
{
    public partial class UsuarioDlg : Form
    {
        private List<Usuario> lusuario;
        private GestorUsuario gestorUsuario;
        private Usuario seleccionado = null;
        public UsuarioDlg()
        {
            InitializeComponent();
            actualizarTabla();
        }
        public void actualizarTabla()
        {
            for (int i = 1; i < tablaUsuario.Rows.Count; i++)
                tablaUsuario.Rows.RemoveAt(i);

            gestorUsuario = GestorUsuario.Instancia();
            lusuario = gestorUsuario.seleccionarUsuarios();
            String[] fila;
            Usuario u;
            for (int i = 0; i < lusuario.Count; i++)
            {
                u = lusuario[i];
                fila = new String[] {""+u.getId(),u.getNombre(),u.getEmail(),
                    ""+u.getTelefono(),""+u.getSueldo(),u.getTipoUsuario().getDescripcion() };
                tablaUsuario.Rows.Add(fila);
            }
        }
        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarUsuarioDlg ventana = new RegistrarUsuarioDlg();
            ventana.Show();            
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea eliminar el Usuario?\n", 
                "Eliminar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                //gestorUsuario.eliminarUsuario();
                
            }
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            ModificarUsuarioDlg ventana = new ModificarUsuarioDlg();
            ventana.Show();
        }

        private void tablaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tablaUsuario.SelectedRows.
        }


    }
}
