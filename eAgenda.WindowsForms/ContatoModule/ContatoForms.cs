using eAgenda.Controladores.ContatoModule;

using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;

using System.Data;
using System.Windows.Forms;
using eAgenda.ExportPDF;
using System.Threading;

namespace eAgenda.WindowsForms
{/// <summary>
/// Classe Contato Forms
/// </summary>
    public partial class ContatoForms : Form
    {
        ControladorContato controlador;
        bool english;
        /// <summary>
        /// Construtor do Contato Forms
        /// </summary>
        /// <param name="controlador">Controlador do contato</param>
        public ContatoForms(ControladorContato controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
            english = Thread.CurrentThread.CurrentUICulture.ToString() == "en-US";
            PreencherTabelaContatos();
        }

        /// <summary>
        /// Preenche dataGridView dos contatos
        /// </summary>
        private void PreencherTabelaContatos()
        {
            dataGridContatos.Refresh();
            tableContatos.Clear();
            tableContatosen.Clear();
            if(english)
                dataGridContatos.DataSource = tableContatosen;
            else
                dataGridContatos.DataSource = tableContatos;
            Console.WriteLine(english);
            Console.WriteLine(dataGridContatos.DataSource);
            List<Contato> contatos = controlador.SelecionarTodos();

            foreach (var contato in contatos)
            {
                if (english)
                {
                    DataRow linha = tableContatosen.NewRow();

                    linha["Id"] = contato.Id;
                    linha["Name"] = contato.Nome;
                    linha["Company"] = contato.Empresa;
                    linha["Position"] = contato.Cargo;
                    linha["Email"] = contato.Email;
                    linha["Telephone"] = contato.Telefone;

                    tableContatosen.Rows.Add(linha);
                }
                else
                {
                    DataRow linha = tableContatos.NewRow();

                    linha["Id"] = contato.Id;
                    linha["Nome"] = contato.Nome;
                    linha["Empresa"] = contato.Empresa;
                    linha["Cargo"] = contato.Cargo;
                    linha["Email"] = contato.Email;
                    linha["Telefone"] = contato.Telefone;

                    tableContatos.Rows.Add(linha);
                }
            }



        }

        
        private void ContatoForms_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Limpa os campos de texto
        /// </summary>
        private void limparCampos()
        {
            tb_nome.Text = "";
            tb_telefone.Text = "";
            tb_cargo.Text = "";
            tb_empresa.Text = "";
            tb_email.Text = "";
        }

        /// <summary>
        /// Insere um novo contato depois de validar e mostra mensagem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_gravar_Click(object sender, EventArgs e)
        {
            Contato contato = CriarContato();

            string resultadoValidacao = controlador.InserirNovo(contato);

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                MessageBox.Show("Registrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
            }
            else
            {
                MessageBox.Show(resultadoValidacao, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            PreencherTabelaContatos();
            
        }

        /// <summary>
        /// Cria um novo contato pegando os valores dos campos de texto
        /// </summary>
        /// <returns>Retorna um contato</returns>
        private Contato CriarContato()
        {
            string nome = tb_nome.Text;
            string telefone = tb_telefone.Text;
            string cargo = tb_cargo.Text;
            string empresa = tb_empresa.Text;
            string email = tb_email.Text;

            Contato contato = new Contato(nome, email, telefone, empresa, cargo);
            return contato;
        }


        /// <summary>
        /// Exclui um contato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_excluirContato_Click(object sender, EventArgs e)
        {
            if (dataGridContatos.RowCount == 0)
                return;


            int id = Convert.ToInt32(dataGridContatos.CurrentRow.Cells["Id"].Value);

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

            PreencherTabelaContatos();
        }

        
        /// <summary>
        /// Editar um contato existente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_editar_Click(object sender, EventArgs e)
        {
            if (dataGridContatos == null)
                return;


            int id = Convert.ToInt32(dataGridContatos.CurrentRow.Cells["Id"].Value);

            bool numeroEncontrado = controlador.Existe(id);
            if (numeroEncontrado == false)
            {
                MessageBox.Show("Erro!");

                return;
            }

            Contato contato = CriarContato();


            string resultadoValidacao = controlador.Editar(id, contato);

            if (resultadoValidacao == "ESTA_VALIDO")
                MessageBox.Show("Contato" + contato.Nome + "editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                MessageBox.Show(resultadoValidacao, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            limparCampos();
            PreencherTabelaContatos();
            
        }

        /// <summary>
        /// Chama o método para exportar PDF do contato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_exportarPDFContato_Click(object sender, EventArgs e)
        {
            ExportarPDFContato.ExportarContatosEmPDF();
            MessageBox.Show("PDF criado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Pega os valores no dataGridContatos e preenche nos campos depois do doubleClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridContatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_nome.Text = dataGridContatos.CurrentRow.Cells["Nome"].Value.ToString();
            tb_telefone.Text = dataGridContatos.CurrentRow.Cells["Telefone"].Value.ToString();
            tb_cargo.Text = dataGridContatos.CurrentRow.Cells["Cargo"].Value.ToString();
            tb_email.Text = dataGridContatos.CurrentRow.Cells["Email"].Value.ToString();
            tb_empresa.Text = dataGridContatos.CurrentRow.Cells["Empresa"].Value.ToString();
            
        }
    }
}
