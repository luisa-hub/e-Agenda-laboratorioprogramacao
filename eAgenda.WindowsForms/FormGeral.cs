using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Controladores.TarefaModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsForms
{
    public partial class FormGeral : Form
    {
        ControladorTarefa controladorTarefa;
        ControladorContato controladorContato;
        ControladorCompromisso controladorCompromisso;
        public FormGeral()
        {
            InitializeComponent();
            controladorTarefa = new ControladorTarefa();
            controladorContato = new ControladorContato();
            controladorCompromisso = new ControladorCompromisso();
        }

        private void bt_contatos_Click(object sender, EventArgs e)
        {
            ContatoForms contato = new ContatoForms(controladorContato);
            contato.Show();
        }

        private void bt_tarefa_Click(object sender, EventArgs e)
        {
            TarefaForms tarefa = new TarefaForms(controladorTarefa);
            tarefa.Show();
            
        }

        private void bt_compromisso_Click(object sender, EventArgs e)
        {
            CompromissoForms compromisso = new CompromissoForms(controladorCompromisso, controladorContato);
            compromisso.Show();
            
            
        }

        private void bt_saida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
