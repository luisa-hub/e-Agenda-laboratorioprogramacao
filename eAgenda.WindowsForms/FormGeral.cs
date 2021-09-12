using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Controladores.TarefaModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(button1.Text);
            Console.WriteLine(Thread.CurrentThread.CurrentUICulture);
            if (button1.Text == "English")
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
               
            }
            if (button1.Text == "Português")
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("pt");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt");
                
            }
            this.Controls.Clear();
            InitializeComponent();
        }
    }
}
