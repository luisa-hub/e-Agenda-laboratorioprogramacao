
namespace eAgenda.WindowsForms
{
    partial class ContatoForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContatoForms));
            this.tb_cargo = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_visualizacao = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_exportarPDFContato = new System.Windows.Forms.Button();
            this.dataGridContatos = new System.Windows.Forms.DataGridView();
            this.bt_excluirContato = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.tb_empresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.dataSetContatos = new System.Data.DataSet();
            this.tableContatos = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataSetContatosAgrupados = new System.Data.DataSet();
            this.tableContatosAgrupados = new System.Data.DataTable();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableContatosen = new System.Data.DataTable();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.tableContatosAgrupadosen = new System.Data.DataTable();
            this.dataColumn19 = new System.Data.DataColumn();
            this.dataColumn20 = new System.Data.DataColumn();
            this.dataColumn21 = new System.Data.DataColumn();
            this.dataColumn22 = new System.Data.DataColumn();
            this.dataColumn23 = new System.Data.DataColumn();
            this.dataColumn24 = new System.Data.DataColumn();
            this.panel1.SuspendLayout();
            this.tb_visualizacao.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContatos)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetContatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableContatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetContatosAgrupados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableContatosAgrupados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableContatosen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableContatosAgrupadosen)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_cargo
            // 
            resources.ApplyResources(this.tb_cargo, "tb_cargo");
            this.tb_cargo.Name = "tb_cargo";
            // 
            // tb_nome
            // 
            resources.ApplyResources(this.tb_nome, "tb_nome");
            this.tb_nome.Name = "tb_nome";
            // 
            // tb_email
            // 
            resources.ApplyResources(this.tb_email, "tb_email");
            this.tb_email.Name = "tb_email";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.tb_visualizacao);
            this.panel1.Name = "panel1";
            // 
            // tb_visualizacao
            // 
            resources.ApplyResources(this.tb_visualizacao, "tb_visualizacao");
            this.tb_visualizacao.Controls.Add(this.tabPage1);
            this.tb_visualizacao.Multiline = true;
            this.tb_visualizacao.Name = "tb_visualizacao";
            this.tb_visualizacao.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.btn_exportarPDFContato);
            this.tabPage1.Controls.Add(this.dataGridContatos);
            this.tabPage1.Controls.Add(this.bt_excluirContato);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_exportarPDFContato
            // 
            resources.ApplyResources(this.btn_exportarPDFContato, "btn_exportarPDFContato");
            this.btn_exportarPDFContato.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_exportarPDFContato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportarPDFContato.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_exportarPDFContato.Name = "btn_exportarPDFContato";
            this.btn_exportarPDFContato.UseVisualStyleBackColor = false;
            this.btn_exportarPDFContato.Click += new System.EventHandler(this.btn_exportarPDFContato_Click);
            // 
            // dataGridContatos
            // 
            resources.ApplyResources(this.dataGridContatos, "dataGridContatos");
            this.dataGridContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContatos.Name = "dataGridContatos";
            this.dataGridContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridContatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridContatos_CellDoubleClick);
            // 
            // bt_excluirContato
            // 
            resources.ApplyResources(this.bt_excluirContato, "bt_excluirContato");
            this.bt_excluirContato.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_excluirContato.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_excluirContato.Name = "bt_excluirContato";
            this.bt_excluirContato.UseVisualStyleBackColor = false;
            this.bt_excluirContato.Click += new System.EventHandler(this.bt_excluirContato_Click);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.tb_telefone);
            this.panel3.Controls.Add(this.bt_editar);
            this.panel3.Controls.Add(this.bt_gravar);
            this.panel3.Controls.Add(this.tb_empresa);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lb_nome);
            this.panel3.Controls.Add(this.tb_nome);
            this.panel3.Controls.Add(this.tb_cargo);
            this.panel3.Controls.Add(this.tb_email);
            this.panel3.Name = "panel3";
            // 
            // tb_telefone
            // 
            resources.ApplyResources(this.tb_telefone, "tb_telefone");
            this.tb_telefone.Name = "tb_telefone";
            // 
            // bt_editar
            // 
            resources.ApplyResources(this.bt_editar, "bt_editar");
            this.bt_editar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bt_editar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_gravar
            // 
            resources.ApplyResources(this.bt_gravar, "bt_gravar");
            this.bt_gravar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bt_gravar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.UseVisualStyleBackColor = false;
            this.bt_gravar.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // tb_empresa
            // 
            resources.ApplyResources(this.tb_empresa, "tb_empresa");
            this.tb_empresa.Name = "tb_empresa";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lb_nome
            // 
            resources.ApplyResources(this.lb_nome, "lb_nome");
            this.lb_nome.Name = "lb_nome";
            // 
            // dataSetContatos
            // 
            this.dataSetContatos.DataSetName = "NewDataSet";
            this.dataSetContatos.Tables.AddRange(new System.Data.DataTable[] {
            this.tableContatos,
            this.tableContatosen});
            // 
            // tableContatos
            // 
            this.tableContatos.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.tableContatos.TableName = "tableContatos";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Nome";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Telefone";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Email";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Cargo";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Empresa";
            // 
            // dataSetContatosAgrupados
            // 
            this.dataSetContatosAgrupados.DataSetName = "NewDataSet";
            this.dataSetContatosAgrupados.Tables.AddRange(new System.Data.DataTable[] {
            this.tableContatosAgrupados,
            this.tableContatosAgrupadosen});
            // 
            // tableContatosAgrupados
            // 
            this.tableContatosAgrupados.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12});
            this.tableContatosAgrupados.TableName = "tableContatosAgrupados";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Id";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "Nome";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "Email";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "Telefone";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "Cargo";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "Empresa";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // tableContatosen
            // 
            this.tableContatosen.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16,
            this.dataColumn17,
            this.dataColumn18});
            this.tableContatosen.Locale = new System.Globalization.CultureInfo("en");
            this.tableContatosen.TableName = "tableContatosen";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "Id";
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "Name";
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "Telephone";
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "Email";
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "Position";
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "Company";
            // 
            // tableContatosAgrupadosen
            // 
            this.tableContatosAgrupadosen.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn19,
            this.dataColumn20,
            this.dataColumn21,
            this.dataColumn22,
            this.dataColumn23,
            this.dataColumn24});
            this.tableContatosAgrupadosen.TableName = "tableContatosAgrupadosen";
            // 
            // dataColumn19
            // 
            this.dataColumn19.ColumnName = "Id";
            // 
            // dataColumn20
            // 
            this.dataColumn20.ColumnName = "Name";
            // 
            // dataColumn21
            // 
            this.dataColumn21.ColumnName = "Telephone";
            // 
            // dataColumn22
            // 
            this.dataColumn22.ColumnName = "Email";
            // 
            // dataColumn23
            // 
            this.dataColumn23.ColumnName = "Position";
            // 
            // dataColumn24
            // 
            this.dataColumn24.ColumnName = "Company";
            // 
            // ContatoForms
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ContatoForms";
            this.Load += new System.EventHandler(this.ContatoForms_Load);
            this.panel1.ResumeLayout(false);
            this.tb_visualizacao.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContatos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetContatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableContatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetContatosAgrupados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableContatosAgrupados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableContatosen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableContatosAgrupadosen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_cargo;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox tb_empresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_gravar;
        private System.Data.DataSet dataSetContatos;
        private System.Data.DataTable tableContatos;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataSet dataSetContatosAgrupados;
        private System.Data.DataTable tableContatosAgrupados;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tb_visualizacao;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridContatos;
        private System.Windows.Forms.Button bt_excluirContato;
        private System.Windows.Forms.Button btn_exportarPDFContato;
        private System.Windows.Forms.MaskedTextBox tb_telefone;
        private System.Data.DataTable tableContatosen;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn18;
        private System.Data.DataTable tableContatosAgrupadosen;
        private System.Data.DataColumn dataColumn19;
        private System.Data.DataColumn dataColumn20;
        private System.Data.DataColumn dataColumn21;
        private System.Data.DataColumn dataColumn22;
        private System.Data.DataColumn dataColumn23;
        private System.Data.DataColumn dataColumn24;
    }
}