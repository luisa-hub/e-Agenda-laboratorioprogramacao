
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
            this.tb_telefone = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bt_excluirContato = new System.Windows.Forms.Button();
            this.dataGridContatos = new System.Windows.Forms.DataGridView();
            this.tb_visualizacao = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetContatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableContatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetContatosAgrupados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableContatosAgrupados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContatos)).BeginInit();
            this.tb_visualizacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_cargo
            // 
            this.tb_cargo.Location = new System.Drawing.Point(205, 52);
            this.tb_cargo.Name = "tb_cargo";
            this.tb_cargo.Size = new System.Drawing.Size(160, 21);
            this.tb_cargo.TabIndex = 0;
            this.tb_cargo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_telefone
            // 
            this.tb_telefone.Location = new System.Drawing.Point(72, 52);
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(75, 21);
            this.tb_telefone.TabIndex = 1;
            this.tb_telefone.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(72, 24);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(293, 21);
            this.tb_nome.TabIndex = 2;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(72, 83);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(100, 21);
            this.tb_email.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_visualizacao);
            this.panel1.Location = new System.Drawing.Point(22, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 247);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
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
            this.panel3.Controls.Add(this.tb_telefone);
            this.panel3.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.panel3.Location = new System.Drawing.Point(22, 365);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 157);
            this.panel3.TabIndex = 6;
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bt_editar.Font = new System.Drawing.Font("Veneer", 10F);
            this.bt_editar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_editar.Location = new System.Drawing.Point(194, 121);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(84, 29);
            this.bt_editar.TabIndex = 12;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_gravar
            // 
            this.bt_gravar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bt_gravar.Font = new System.Drawing.Font("Veneer", 10F);
            this.bt_gravar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_gravar.Location = new System.Drawing.Point(97, 121);
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.Size = new System.Drawing.Size(84, 29);
            this.bt_gravar.TabIndex = 11;
            this.bt_gravar.Text = "Gravar";
            this.bt_gravar.UseVisualStyleBackColor = false;
            this.bt_gravar.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // tb_empresa
            // 
            this.tb_empresa.Location = new System.Drawing.Point(245, 83);
            this.tb_empresa.Name = "tb_empresa";
            this.tb_empresa.Size = new System.Drawing.Size(120, 21);
            this.tb_empresa.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label4.Location = new System.Drawing.Point(191, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label3.Location = new System.Drawing.Point(159, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label2.Location = new System.Drawing.Point(31, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label1.Location = new System.Drawing.Point(17, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Telefone";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lb_nome.Location = new System.Drawing.Point(31, 32);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(40, 13);
            this.lb_nome.TabIndex = 5;
            this.lb_nome.Text = "Nome";
            // 
            // dataSetContatos
            // 
            this.dataSetContatos.DataSetName = "NewDataSet";
            this.dataSetContatos.Tables.AddRange(new System.Data.DataTable[] {
            this.tableContatos});
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
            this.tableContatosAgrupados});
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
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, -74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 283);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridContatos);
            this.tabPage1.Controls.Add(this.bt_excluirContato);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(385, 218);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contatos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bt_excluirContato
            // 
            this.bt_excluirContato.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_excluirContato.Font = new System.Drawing.Font("Veneer", 10F);
            this.bt_excluirContato.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_excluirContato.Location = new System.Drawing.Point(145, 178);
            this.bt_excluirContato.Name = "bt_excluirContato";
            this.bt_excluirContato.Size = new System.Drawing.Size(84, 29);
            this.bt_excluirContato.TabIndex = 1;
            this.bt_excluirContato.Text = "Excluir";
            this.bt_excluirContato.UseVisualStyleBackColor = false;
            this.bt_excluirContato.Click += new System.EventHandler(this.bt_excluirContato_Click);
            // 
            // dataGridContatos
            // 
            this.dataGridContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContatos.Location = new System.Drawing.Point(0, 6);
            this.dataGridContatos.Name = "dataGridContatos";
            this.dataGridContatos.Size = new System.Drawing.Size(379, 166);
            this.dataGridContatos.TabIndex = 0;
            // 
            // tb_visualizacao
            // 
            this.tb_visualizacao.Controls.Add(this.tabPage1);
            this.tb_visualizacao.Location = new System.Drawing.Point(3, 6);
            this.tb_visualizacao.Multiline = true;
            this.tb_visualizacao.Name = "tb_visualizacao";
            this.tb_visualizacao.SelectedIndex = 0;
            this.tb_visualizacao.Size = new System.Drawing.Size(393, 244);
            this.tb_visualizacao.TabIndex = 0;
            // 
            // ContatoForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(434, 525);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ContatoForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meus contatos";
            this.Load += new System.EventHandler(this.ContatoForms_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetContatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableContatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetContatosAgrupados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableContatosAgrupados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContatos)).EndInit();
            this.tb_visualizacao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_cargo;
        private System.Windows.Forms.TextBox tb_telefone;
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
    }
}