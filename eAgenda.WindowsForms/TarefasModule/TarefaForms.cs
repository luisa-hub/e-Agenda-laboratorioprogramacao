using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgenda.ExportPDF;
using System.Threading;

namespace eAgenda.WindowsForms
{
    /// <summary>
    /// Formulário das tarefas concluídas e pendentes
    /// </summary>
    public partial class TarefaForms : Form
    {
        protected ControladorTarefa controlador;
        bool english;
        public TarefaForms(ControladorTarefa controladorTarefa)
        {
            InitializeComponent();
            this.controlador = controladorTarefa;
            english = Thread.CurrentThread.CurrentUICulture.ToString() == "en-US";
            PreencherTabelaPendente();
            PreencherTabelaConcluida();
        }

        /// <summary>
        /// Preenche o DataGrid das Tarefas Pendentes
        /// </summary>
        private void PreencherTabelaPendente()
        {
           dataGridTarefas.Refresh();
            tb_tarefapendenteen.Clear();
            tb_tarefapendente.Clear();
            if (english)
                dataGridTarefas.DataSource = tb_tarefapendenteen;
            else
                dataGridTarefas.DataSource = tb_tarefapendente;

           
            List<Tarefa> tarefas = controlador.SelecionarTodasTarefasPendentes();
            
            foreach (var tarefa in tarefas)
            {
                DataRow linha;
                if (english)
                {
                    linha = AdicionarLinhasEmIngles(tarefa, tb_tarefapendenteen);

                }
                else
                {
                    linha = AdicionarLinhasEmPt(tarefa, tb_tarefapendente);
                }
            }


            
        }

        /// <summary>
        /// Adiciona as linhas na datatable especificada (em PT-BR)
        /// </summary>
        /// <param name="tarefa">Tarefa que deseja mostrar</param>
        /// <param name="tabela">DataTable que deseja preencher</param>
        /// <returns>A linha preenchida com as informações</returns>
        private DataRow AdicionarLinhasEmPt(Tarefa tarefa, DataTable tabela)
        {
            DataRow linha = tabela.NewRow();
            linha["Id"] = tarefa.Id;
            linha["Nome"] = tarefa.Titulo;
            linha["Data Conclusão"] = tarefa.DataConclusao;
            linha["Data Início"] = tarefa.DataCriacao;
            linha["Prioridade"] = tarefa.Prioridade;
            linha["Percentual"] = tarefa.Percentual;
            tabela.Rows.Add(linha);
            return linha;
        }

        /// <summary>
        /// Adiciona as linhas na datatable especificada (em EN-US)
        /// </summary>
        /// <param name="tarefa">Tarefa que deseja mostrar</param>
        /// <param name="tabela">DataTable que deseja preencher</param>
        /// <returns>A linha preenchida com as informações</returns>
        private DataRow AdicionarLinhasEmIngles(Tarefa tarefa, DataTable tabela)
        {
            DataRow linha = tabela.NewRow();
            linha["Id"] = tarefa.Id;
            linha["Title"] = tarefa.Titulo;
            linha["Completion Date"] = tarefa.DataConclusao;
            linha["Start Date"] = tarefa.DataCriacao;
            linha["Priority"] = tarefa.Prioridade;
            linha["Percentage"] = tarefa.Percentual;
            tabela.Rows.Add(linha);
            return linha;
        }

        /// <summary>
        /// Preenche o DataGrid das tarefas concluídas
        /// </summary>
        private void PreencherTabelaConcluida()
        {
            dataGridTarefaConcluidas.Refresh();
            tb_tarefasconcluidas.Clear();
            tb_tarefasconcluidasen.Clear();
            if (english)
                dataGridTarefaConcluidas.DataSource = tb_tarefasconcluidasen;
            else
                dataGridTarefaConcluidas.DataSource = tb_tarefasconcluidas;

            //adicionado as linhas no datagrid

            List<Tarefa> tarefas = controlador.SelecionarTodasTarefasConcluidas();

            foreach (var tarefa in tarefas)
            {
                DataRow linha;
                if (english)
                {
                    linha = AdicionarLinhasEmIngles(tarefa, tb_tarefasconcluidasen);
                }
                else
                {
                    linha = AdicionarLinhasEmPt(tarefa, tb_tarefasconcluidas);

                }
            }

            
        }

        /// <summary>
        /// Registra uma nova tarefa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_gravar_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = CriarTarefa();

            string resultadoValidacao = controlador.InserirNovo(tarefa);

            if (resultadoValidacao == "ESTA_VALIDO")
                MessageBox.Show("Registrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show(resultadoValidacao, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }


            PreencherTabelaPendente();
            limparCampos();
        }

        /// <summary>
        /// Pega os parâmetros dos campos para criar tarefa
        /// </summary>
        /// <returns>Retorna uma Tarefa</returns>
        private Tarefa CriarTarefa()
        {
            string titulo = tb_name.Text;

            int prioridade = cb_prioridadeTarefa.SelectedIndex;

            Dominio.TarefaModule.Tarefa tarefa = new Dominio.TarefaModule.Tarefa(titulo, DateTime.Now.Date, (PrioridadeEnum)prioridade);
            return tarefa;
        }


        /// <summary>
        /// Limpa os campos de texto e prioridade
        /// </summary>
        private void limparCampos()
        {

            tb_name.Text = "";
            cb_prioridadeTarefa.SelectedItem = null;
        }

        /// <summary>
        /// Exclui uma tarefa pendente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_excluir_Click(object sender, EventArgs e)
        {
            Excluir(dataGridTarefas);
            

            PreencherTabelaPendente();
        }

        /// <summary>
        /// Exclui a tarefa desejada
        /// </summary>
        /// <param name="dataGridTarefas"></param>
        private void Excluir(DataGridView dataGridTarefas)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                if (dataGridTarefas.RowCount == 0)
                    return;


                int id = Convert.ToInt32(dataGridTarefas.CurrentRow.Cells["Id"].Value);

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

        }

        /// <summary>
        /// Exclui uma tabela concluída
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_excluirConcluida_Click(object sender, EventArgs e)
        {
            Excluir(dataGridTarefaConcluidas);

            PreencherTabelaConcluida();
        }

        /// <summary>
        /// Atualiza a porcentagem das Tarefas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_atualizar_Click(object sender, EventArgs e)
        {
         int id;
         if (dataGridTarefas.SelectedRows.Count == 1)
                id = Convert.ToInt32(dataGridTarefas.CurrentRow.Cells["Id"].Value);

        else {

                MessageBox.Show("Nenhuma tarefa selecionada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                

            bool numeroEncontrado = controlador.Existe(id);

            if (numeroEncontrado == false)
            {
                MessageBox.Show("Erro!");

                return;
            }

            
            int novoPercentual = Convert.ToInt32(tb_porcentagem.Text);
            
            string validarPorcentagem = controlador.AtualizarPercentual(id, novoPercentual);

            if(String.IsNullOrEmpty(validarPorcentagem))
                MessageBox.Show("Porcentagem atualizada com sucesso!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(validarPorcentagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            PreencherTabelaPendente();
            PreencherTabelaConcluida();
        }


        /// <summary>
        /// Edita a Tarefa Pendente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_editarPendente_Click(object sender, EventArgs e)
        {
            if (dataGridTarefas == null)
                return;


            int id = Convert.ToInt32(dataGridTarefas.CurrentRow.Cells["Id"].Value);

            bool numeroEncontrado = controlador.Existe(id);
            if (numeroEncontrado == false)
            {
                MessageBox.Show("Erro!");

                return;
            }

            Tarefa tarefa = CriarTarefa();


            string resultadoValidacao = controlador.Editar(id, tarefa);

            if (resultadoValidacao == "ESTA_VALIDO")
                MessageBox.Show("Tarefa" + tarefa.Titulo + "editada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                MessageBox.Show(resultadoValidacao, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            PreencherTabelaPendente();
            limparCampos();
        }

       
        /// <summary>
        /// Edita a Tarefa Concluída
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_editarConcluida_Click(object sender, EventArgs e)
        {
            if (dataGridTarefaConcluidas == null)
                return;


            int id = Convert.ToInt32(dataGridTarefaConcluidas.CurrentRow.Cells["Id"].Value);

            bool numeroEncontrado = controlador.Existe(id);
            if (numeroEncontrado == false)
            {
                MessageBox.Show("Erro!");

                return;
            }

            Tarefa tarefa = CriarTarefa();


            string resultadoValidacao = controlador.Editar(id, tarefa);

            if (resultadoValidacao == "ESTA_VALIDO")
                MessageBox.Show("Tarefa" + tarefa.Titulo + "editada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                MessageBox.Show(resultadoValidacao);
                return;
            }

            PreencherTabelaConcluida();
            limparCampos();
        }

        /// <summary>
        /// Chama o método para exportar o PDF das Tarefas concluídas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_exportarPDFConcluida_Click(object sender, EventArgs e)
        {
            ExportarPDFTarefa.ExportarTarefaEmPDF();

            MessageBox.Show("PDF criado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Chama o método para exportar para PDF as tarefas pendentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_exportarPDFPendente_Click(object sender, EventArgs e)
        {
            ExportarPDFTarefa.ExportarTarefaPendenteEmPDF();

            MessageBox.Show("PDF criado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// <summary>
        /// Adiciona os parâmetros das tarefas pendentes nos campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridTarefas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_name.Text = dataGridTarefas.CurrentRow.Cells["Nome"].Value.ToString();
            cb_prioridadeTarefa.Text = dataGridTarefas.CurrentRow.Cells["Prioridade"].Value.ToString();
            
        }

        /// <summary>
        /// Adiciona os parâmetros das tarefas concluídas nos campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridTarefasConcluidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_name.Text = dataGridTarefaConcluidas.CurrentRow.Cells["Nome"].Value.ToString();
            cb_prioridadeTarefa.Text = dataGridTarefaConcluidas.CurrentRow.Cells["Prioridade"].Value.ToString();

        }
    }
}
