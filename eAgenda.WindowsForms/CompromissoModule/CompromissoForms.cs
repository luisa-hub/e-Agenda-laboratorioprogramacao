using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
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
    public partial class CompromissoForms : Form
    {
        ControladorCompromisso controlador;
        ControladorContato controladorContato;
        
        
        public CompromissoForms(ControladorCompromisso controlador, ControladorContato controladorContato)
        {
            InitializeComponent();
            this.controlador = controlador;
            this.controladorContato = controladorContato;
            PreencherTabelaCompromissoPassado();
            PreencherTabelaCompromisso();
            PreencherTabelaCompromissoFuturo();
            
            PreencherComboBox();
        }

        private void PreencherComboBox()
        {
            List<Contato> contatos = controladorContato.SelecionarTodos();
            foreach (Contato item in contatos)
            {
                cb_contatos.Items.Add(item.Nome);
                
            }

        }
        private void PreencherTabelaCompromisso() {

            dataGridCompromissos.Refresh();
            table_compromissos.Clear();

            dataGridCompromissos.DataSource = table_compromissos;



            List<Compromisso> compromissos = controlador.SelecionarTodos();

            foreach (var compromisso in compromissos)
            {
                DataRow linha = table_compromissos.NewRow();

                linha["Id"] = compromisso.Id;
                linha["Assunto"] = compromisso.Assunto;
                linha["Hora Término"] = compromisso.HoraTermino;
                linha["Hora Início"] = compromisso.HoraInicio;
                linha["Local"] = compromisso.Local;
                linha["Link"] = compromisso.Link;
                linha["Data"] = compromisso.Data;

                if (compromisso.Contato != null)
                    linha["Contato"] = compromisso.Contato.Nome;

                table_compromissos.Rows.Add(linha);
            }

        }

        private void PreencherTabelaCompromissoPassado() {

            dataGridPassado.Refresh();
            tablePassado.Clear();

            dataGridPassado.DataSource = tablePassado;

            DateTime dataSelecionada = dataPassado.Value;

            List<Compromisso> compromissosPassados = controlador.SelecionarCompromissosPassados(dataSelecionada);

            foreach (var compromisso in compromissosPassados)
            {
                DataRow linha = tablePassado.NewRow();

                linha["Id"] = compromisso.Id;
                linha["Assunto"] = compromisso.Assunto;
                linha["Hora Fim"] = compromisso.HoraTermino;
                linha["Hora Início"] = compromisso.HoraInicio;
                linha["Local"] = compromisso.Local;
                linha["Link"] = compromisso.Link;
                linha["Data"] = compromisso.Data;

                if (compromisso.Contato != null)
                    linha["Contato"] = compromisso.Contato.Nome;
                else
                    linha["Contato"] = "Sem contato";

                tablePassado.Rows.Add(linha);
            }

        }

        private void PreencherTabelaCompromissoFuturo() {

            dataGridFuturo.Refresh();
            tableFuturo.Clear();

            dataGridFuturo.DataSource = tableFuturo;

            DateTime dataInicio = dataFuturoUm.Value;
            DateTime dataFim = dataFuturoDois.Value;

            List<Compromisso> compromissos = controlador.SelecionarCompromissosFuturos(dataInicio, dataFim);

            foreach (var compromisso in compromissos)
            {
                DataRow linha = tableFuturo.NewRow();

                linha["Id"] = compromisso.Id;
                linha["Assunto"] = compromisso.Assunto;
                linha["Hora Término"] = compromisso.HoraTermino;
                linha["Hora Início"] = compromisso.HoraInicio;
                linha["Local"] = compromisso.Local;
                linha["Link"] = compromisso.Link;
                linha["Data"] = compromisso.Data;

                if (compromisso.Contato != null)
                    linha["Contato"] = compromisso.Contato.Nome;

                tableFuturo.Rows.Add(linha);
            }



        }

     

      

        private void btGravar_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = CriarCompromisso();

            string resultadoValidacao = controlador.InserirNovo(compromisso);

            if (resultadoValidacao == "ESTA_VALIDO")
                MessageBox.Show("Sucesso!");
            else
            {
                MessageBox.Show(resultadoValidacao);

            }


            PreencherTabelaCompromisso();
            limparCampos();

        }

        private Compromisso CriarCompromisso()
        {
            string assunto, local, link;
            int contato = 0;
            TimeSpan horaFim, horaInicio;
            DateTime data;

            assunto = tb_assunto.Text;
            local = tb_local.Text;
            link = tb_link.Text;
            horaFim = TimeSpan.Parse(tb_hora.Text);
            horaInicio = TimeSpan.Parse(tb_horai.Text);
            data = dt_data.Value;

            List<Contato> contatoTodos = controladorContato.SelecionarTodos();

            foreach (Contato item in contatoTodos)
            {
                if (item.Nome == cb_contatos.SelectedItem.ToString())
                    contato = item.Id;

            }


            Contato contatoControlador = controladorContato.SelecionarPorId(contato);

            Compromisso compromisso = new Compromisso(assunto, local, link, data, horaInicio, horaFim, contatoControlador);
            return compromisso;
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            if (dataGridCompromissos.RowCount == 0)
                return;


            int id = Convert.ToInt32(dataGridCompromissos.CurrentRow.Cells["Id"].Value);

            bool numeroEncontrado = controlador.Existe(id);

            if (numeroEncontrado == false)
            {

                controlador.Excluir(id);
                return;
            }

            bool conseguiuExcluir = controlador.Excluir(id);

            if (conseguiuExcluir)
            {
                MessageBox.Show("Sucesso");

            }


            else
            {
                MessageBox.Show("Erro");

            }

            PreencherTabelaCompromisso();
        }

        private void dataPassado_ValueChanged(object sender, EventArgs e)
        {
            PreencherTabelaCompromissoPassado();
        }

        private void dataFuturoUm_ValueChanged(object sender, EventArgs e)
        {
            PreencherTabelaCompromissoFuturo();
        }

        private void dataFuturoDois_ValueChanged(object sender, EventArgs e)
        {
            PreencherTabelaCompromissoFuturo();
        }

        private void dataGridCompromissos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_assunto.Text = dataGridCompromissos.CurrentRow.Cells["Assunto"].Value.ToString();
            tb_hora.Text = dataGridCompromissos.CurrentRow.Cells["Hora Término"].Value.ToString();
            tb_horai.Text = dataGridCompromissos.CurrentRow.Cells["Hora Início"].Value.ToString();
            dt_data.Value = Convert.ToDateTime(dataGridCompromissos.CurrentRow.Cells["Data"].Value);
            tb_local.Text = dataGridCompromissos.CurrentRow.Cells["Local"].Value.ToString();
            tb_link.Text = dataGridCompromissos.CurrentRow.Cells["Link"].Value.ToString();
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
           

            if (dataGridCompromissos == null)
                return;

           
            int id = Convert.ToInt32(dataGridCompromissos.CurrentRow.Cells["Id"].Value);

            bool numeroEncontrado = controlador.Existe(id);
            if (numeroEncontrado == false)
            {
                MessageBox.Show("Erro!");
                
                return;
            }

            Compromisso compromisso = CriarCompromisso();


            string resultadoValidacao = controlador.Editar(id, compromisso);

            if (resultadoValidacao == "ESTA_VALIDO")
                MessageBox.Show("Sucesso!");
            else
            {
                MessageBox.Show(resultadoValidacao);
                return;
            }

            PreencherTabelaCompromisso();
            PreencherTabelaCompromissoFuturo();
            PreencherTabelaCompromissoPassado();
            limparCampos();
        }

        private void limparCampos()
        {
            tb_assunto.Text= "";
            tb_hora.Text = "";
            tb_horai.Text = "";
            tb_link.Text = "";
            tb_local.Text = "";
            dt_data.Value = DateTime.Now;

        }
    }
}
