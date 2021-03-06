using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using eAgenda.ExportPDF;
using System.Threading;

namespace eAgenda.WindowsForms
{
    /// <summary>
    /// Formulário do Compromisso
    /// </summary>
    public partial class CompromissoForms : Form
    {
        ControladorCompromisso controlador;
        ControladorContato controladorContato;
        bool english;
        
        /// <summary>
        /// Construtor do CompromissoForm
        /// </summary>
        /// <param name="controlador">Controlador do compromisso</param>
        /// <param name="controladorContato">Controlador Contato</param>
        public CompromissoForms(ControladorCompromisso controlador, ControladorContato controladorContato)
        {
            InitializeComponent();
            this.controlador = controlador;
            this.controladorContato = controladorContato;
            english = Thread.CurrentThread.CurrentUICulture.ToString() == "en-US";
            PreencherTabelaCompromissoPassado();
            PreencherTabelaCompromisso();
            PreencherTabelaCompromissoFuturo();
            
            PreencherComboBox();
        }

        /// <summary>
        /// Preenche combobox com os contatos
        /// </summary>
        private void PreencherComboBox()
        {
            List<Contato> contatos = controladorContato.SelecionarTodos();
            foreach (Contato item in contatos)
            {
                cb_contatos.Items.Add(item.Nome);
                
            }

        }

        /// <summary>
        /// Preenche DataGridView com todos os compromissos
        /// </summary>
        private void PreencherTabelaCompromisso() {

            dataGridCompromissos.Refresh();
            table_compromissos.Clear();
            table_compromissosen.Clear();

            List<Compromisso> compromissos = controlador.SelecionarTodos();

            if (english)
                dataGridCompromissos.DataSource = table_compromissosen;
            else
                dataGridCompromissos.DataSource = table_compromissos;

            foreach (var compromisso in compromissos)
            {
                if (english)
                {
                    DataRow linha = table_compromissosen.NewRow();

                    linha["Id"] = compromisso.Id;
                    linha["Subject"] = compromisso.Assunto;
                    linha["Start Hour"] = compromisso.HoraTermino;
                    linha["End Hour"] = compromisso.HoraInicio;
                    linha["Location"] = compromisso.Local;
                    linha["Link"] = compromisso.Link;
                    linha["Date"] = compromisso.Data;

                    if (compromisso.Contato != null)
                        linha["Contact"] = compromisso.Contato.Nome;

                    table_compromissosen.Rows.Add(linha);
                }
                else
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

        }

        /// <summary>
        /// Preenche DataGridView dos compromissos passados
        /// </summary>
        private void PreencherTabelaCompromissoPassado() {

            dataGridPassado.Refresh();
            tablePassado.Clear();
            tablePassadoen.Clear();

            DateTime dataSelecionada = dataPassado.Value;

            List<Compromisso> compromissosPassados = controlador.SelecionarCompromissosPassados(dataSelecionada);


            if (english)
                dataGridPassado.DataSource = tablePassadoen;
            else
                dataGridPassado.DataSource = tablePassado;

            foreach (var compromisso in compromissosPassados)
            {
                if (english)
                {
                    DataRow linha = tablePassadoen.NewRow();

                    linha["Id"] = compromisso.Id;
                    linha["Subject"] = compromisso.Assunto;
                    linha["Start Hour"] = compromisso.HoraTermino;
                    linha["End Hour"] = compromisso.HoraInicio;
                    linha["Location"] = compromisso.Local;
                    linha["Link"] = compromisso.Link;
                    linha["Date"] = compromisso.Data;

                    if (compromisso.Contato != null)
                        linha["Contact"] = compromisso.Contato.Nome;

                    tablePassadoen.Rows.Add(linha);
                }
                else
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

                    tablePassado.Rows.Add(linha);
                }
            }


        }

        /// <summary>
        /// Preenche DataGridView dos Compromissos do Futuro
        /// </summary>
        private void PreencherTabelaCompromissoFuturo() {

            dataGridFuturo.Refresh();
            tableFuturo.Clear();
            tableFuturoen.Clear();

            DateTime dataInicio = dataFuturoUm.Value;
            DateTime dataFim = dataFuturoDois.Value;

            List<Compromisso> compromissos = controlador.SelecionarCompromissosFuturos(dataInicio, dataFim);

            if (english)
                dataGridFuturo.DataSource = tableFuturoen;
            else
                dataGridFuturo.DataSource = tableFuturo;

            foreach (var compromisso in compromissos)
            {
                if (english)
                {
                    DataRow linha = tableFuturoen.NewRow();

                    linha["Id"] = compromisso.Id;
                    linha["Subject"] = compromisso.Assunto;
                    linha["Start Hour"] = compromisso.HoraTermino;
                    linha["End Hour"] = compromisso.HoraInicio;
                    linha["Location"] = compromisso.Local;
                    linha["Link"] = compromisso.Link;
                    linha["Date"] = compromisso.Data;

                    if (compromisso.Contato != null)
                        linha["Contact"] = compromisso.Contato.Nome;

                    tableFuturoen.Rows.Add(linha);
                }
                else
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



        }




        /// <summary>
        /// Gravar compromisso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGravar_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = CriarCompromisso();

            string resultadoValidacao = controlador.InserirNovo(compromisso);

            if (resultadoValidacao == "ESTA_VALIDO")
                MessageBox.Show("Registrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show(resultadoValidacao, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            PreencherTabelaCompromisso();
            limparCampos();

        }


        /// <summary>
        /// Cria um compromisso com base no que foi selecionado nos campos
        /// </summary>
        /// <returns>Retorna Compromisso</returns>
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

        /// <summary>
        /// Excluir compromisso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_excluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
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
                    MessageBox.Show("Registro excluído com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


                else
                {
                    MessageBox.Show("Erro ao apagar o resgistro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            PreencherTabelaCompromisso();
        }

        /// <summary>
        /// Quando alterado a data, preenche tabela de compromissos do passado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataPassado_ValueChanged(object sender, EventArgs e)
        {
            PreencherTabelaCompromissoPassado();
        }

        /// <summary>
        /// Quando alterada data início, preenche tabela dos compromissos do futuro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataFuturoUm_ValueChanged(object sender, EventArgs e)
        {
            PreencherTabelaCompromissoFuturo();
        }

        /// <summary>
        /// Quando alterada data final, preenche tabela dos compromissos do futuro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataFuturoDois_ValueChanged(object sender, EventArgs e)
        {
            PreencherTabelaCompromissoFuturo();
        }

        /// <summary>
        /// Clique duplo na linha, pega os parâmetros e adiciona nos campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridCompromissos_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_assunto.Text = dataGridCompromissos.CurrentRow.Cells["Assunto"].Value.ToString();
            tb_hora.Text = dataGridCompromissos.CurrentRow.Cells["Hora Término"].Value.ToString();
            tb_horai.Text = dataGridCompromissos.CurrentRow.Cells["Hora Início"].Value.ToString();
            dt_data.Value = Convert.ToDateTime(dataGridCompromissos.CurrentRow.Cells["Data"].Value);
            tb_local.Text = dataGridCompromissos.CurrentRow.Cells["Local"].Value.ToString();
            tb_link.Text = dataGridCompromissos.CurrentRow.Cells["Link"].Value.ToString();
        }


        /// <summary>
        /// Pega os parâmetros dos campos para editar compromisso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                MessageBox.Show("Compromisso" + compromisso.Assunto + "editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show(resultadoValidacao, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PreencherTabelaCompromisso();
            PreencherTabelaCompromissoFuturo();
            PreencherTabelaCompromissoPassado();
            limparCampos();
        }

        /// <summary>
        /// Limpar campos de Texto
        /// </summary>
        private void limparCampos()
        {
            tb_assunto.Text= "";
            tb_hora.Text = "";
            tb_horai.Text = "";
            tb_link.Text = "";
            tb_local.Text = "";
            dt_data.Value = DateTime.Now;

        }

        /// <summary>
        /// Chama o método para Exportar em PDF Todos os Compromissos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_exportarCompromissos_Click(object sender, EventArgs e)
        {
            ExportarPDFCompromisso.ExportarCompromissosPDF();
            MessageBox.Show("PDF criado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Chama o método para exportar em PDF Compromissos do Passado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_exportarCompromissoPassado_Click(object sender, EventArgs e)
        {
            ExportarPDFCompromisso.ExportarCompromissosPassadosPDF(dataPassado.Value);
            MessageBox.Show("PDF criado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// Chama o método para exportar em PDF os compromissos do futuro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_exportarPDFCompromissoFuturo_Click(object sender, EventArgs e)
        {
            ExportarPDFCompromisso.ExportarCompromissosFuturosPDF(dataFuturoUm.Value, dataFuturoDois.Value);
            MessageBox.Show("PDF criado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
