﻿using DataGridView.Adicao;
using DataGridView.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.querysInnerJoinDataSet1.Usuarios);
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuSelect = ((System.Data.DataRowView)this.dataGridView1.Rows
            [e.RowIndex]
            .DataBoundItem).Row as DataGridView.QuerysInnerJoinDataSet1.UsuariosRow;
            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.usuariosTableAdapter.DeleteQuery(usuSelect.Id);

                    }
                    break;
                case 1:
                    {
                        frmEdicaoUsuarios editUsuarios = new frmEdicaoUsuarios();

                        editUsuarios.UsuariosRow = usuSelect;
                        editUsuarios.ShowDialog();
                        this.usuariosTableAdapter.Update(editUsuarios.UsuariosRow);
                    }
                    break;

            }
            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Usuarios);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuarios formAddUsu = new frmAdicionarUsuarios();
            formAddUsu.ShowDialog();
            if (!string.IsNullOrEmpty(formAddUsu.usuarioRow?.Usuario))

                this.usuariosTableAdapter.Insert(
                formAddUsu.usuarioRow.Usuario,
                true, 1, 1, DateTime.Now, DateTime.Now
                );
            this.usuariosTableAdapter.Fill(this.querysInnerJoinDataSet1.Usuarios);
        }
    }
}
