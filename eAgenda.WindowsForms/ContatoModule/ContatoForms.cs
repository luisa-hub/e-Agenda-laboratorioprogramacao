using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
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
    public partial class ContatoForms : Form
    {
        ControladorContato controlador;
        public ContatoForms(ControladorContato controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
            PreencherTabelaContatos();
            
        }

        private void PreencherTabelaContatos()
        {
            dataGridContatos.Refresh();
            tableContatos.Clear();
            dataGridContatos.DataSource = tableContatos;
                        

            List<Contato> contatos = controlador.SelecionarTodos();

            foreach (var contato in contatos)
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

        
        private void ContatoForms_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void limparCampos()
        {
            tb_nome.Text = "";
            tb_telefone.Text = "";
            tb_cargo.Text = "";
            tb_empresa.Text = "";
            tb_email.Text = "";
        }

        private void bt_gravar_Click(object sender, EventArgs e)
        {
            Contato contato = CriarContato();

            string resultadoValidacao = controlador.InserirNovo(contato);

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                MessageBox.Show("Sucesso!");
                limparCampos();
            }
            else
            {
                MessageBox.Show(resultadoValidacao);

            }

            PreencherTabelaContatos();
            
        }

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
                MessageBox.Show("Sucesso");

            }


            else
            {
                MessageBox.Show("Erro");

            }

            PreencherTabelaContatos();
        }

        

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
                MessageBox.Show("Sucesso!");

            else
            {
                MessageBox.Show(resultadoValidacao);
                return;
            }
            limparCampos();
            PreencherTabelaContatos();
            
        }
    }
}
