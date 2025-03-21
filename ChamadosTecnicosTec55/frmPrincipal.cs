﻿using ChamadosTecnicosTec55.Adicionar;
using ChamadosTecnicosTec55.Alterar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void fecharSoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msgBox = MessageBox.Show("Quer mesmo Fechar?", "Sistema de Chamados", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                
            if (msgBox == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = @"https://youtu.be/cQKGUgOfD8U?si=54Q5REhSVqPa-_z3&t=75",
                UseShellExecute = true,

            });
        }

        private void documentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = @"https://youtu.be/NMRhx71bGo4?si=BSLpUzHErLcMIml-&t=164",
                UseShellExecute = true,

            });
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void técnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var TelaTecnico = new frmTecnicoAdicionar();
            TelaTecnico.MdiParent = this;
            TelaTecnico.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var TelaCliente = new frmAdicionarCliente();
            //define o formulario pai
            TelaCliente.MdiParent = this;
            TelaCliente.Show();
            //mdi deixa ele criar uma tela dentro da tela (mdi = a parte cinza do design) e bem difetende do
            //TelaClinete.ShowDialog.;.

        }

        private void tsmGestorDeChamados_Click(object sender, EventArgs e)
        {
            var TelaGerirTecnico = new frmGerirTecnicos();
            TelaGerirTecnico.MdiParent = this;
            TelaGerirTecnico.Show();
            
        }

        private void tsmGestorDeClientes_Click(object sender, EventArgs e)
        {
            var TelaGerirCliente = new frmGerirClientes();
            TelaGerirCliente.MdiParent = this;
            TelaGerirCliente.Show();
        }
    }
}
