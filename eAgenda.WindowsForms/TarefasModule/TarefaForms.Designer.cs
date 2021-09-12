
namespace eAgenda.WindowsForms
{
    partial class TarefaForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarefaForms));
            this.dataSetPendentes = new System.Data.DataSet();
            this.tb_tarefapendente = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.tb_tarefapendenteen = new System.Data.DataTable();
            this.dataColumn19 = new System.Data.DataColumn();
            this.dataColumn20 = new System.Data.DataColumn();
            this.dataColumn21 = new System.Data.DataColumn();
            this.dataColumn22 = new System.Data.DataColumn();
            this.dataColumn23 = new System.Data.DataColumn();
            this.dataColumn24 = new System.Data.DataColumn();
            this.dataSetConcluidas = new System.Data.DataSet();
            this.tb_tarefasconcluidas = new System.Data.DataTable();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.tb_tarefasconcluidasen = new System.Data.DataTable();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_prioridadeTarefa = new System.Windows.Forms.ComboBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_porcentagem = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_tarefas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_exportarPDFPendente = new System.Windows.Forms.Button();
            this.bt_editarPendente = new System.Windows.Forms.Button();
            this.bt_excluirPendente = new System.Windows.Forms.Button();
            this.dataGridTarefas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_exportarPDFConcluida = new System.Windows.Forms.Button();
            this.bt_editarConcluida = new System.Windows.Forms.Button();
            this.bt_excluirConcluida = new System.Windows.Forms.Button();
            this.dataGridTarefaConcluidas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPendentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tarefapendente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tarefapendenteen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConcluidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tarefasconcluidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tarefasconcluidasen)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tb_tarefas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTarefas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTarefaConcluidas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSetPendentes
            // 
            this.dataSetPendentes.DataSetName = "NewDataSet";
            this.dataSetPendentes.Tables.AddRange(new System.Data.DataTable[] {
            this.tb_tarefapendente,
            this.tb_tarefapendenteen});
            // 
            // tb_tarefapendente
            // 
            this.tb_tarefapendente.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn4});
            this.tb_tarefapendente.TableName = "tb_tarefapendente";
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
            this.dataColumn3.ColumnName = "Data Conclusão";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Data Início";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Percentual";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Prioridade";
            // 
            // tb_tarefapendenteen
            // 
            this.tb_tarefapendenteen.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn19,
            this.dataColumn20,
            this.dataColumn21,
            this.dataColumn22,
            this.dataColumn23,
            this.dataColumn24});
            this.tb_tarefapendenteen.Locale = new System.Globalization.CultureInfo("en");
            this.tb_tarefapendenteen.TableName = "tb_tarefapendenteen";
            // 
            // dataColumn19
            // 
            this.dataColumn19.ColumnName = "Id";
            // 
            // dataColumn20
            // 
            this.dataColumn20.ColumnName = "Title";
            // 
            // dataColumn21
            // 
            this.dataColumn21.ColumnName = "Completion Date";
            // 
            // dataColumn22
            // 
            this.dataColumn22.ColumnName = "Start Date";
            // 
            // dataColumn23
            // 
            this.dataColumn23.ColumnName = "Priority";
            // 
            // dataColumn24
            // 
            this.dataColumn24.ColumnName = "Percentage";
            // 
            // dataSetConcluidas
            // 
            this.dataSetConcluidas.DataSetName = "NewDataSet";
            this.dataSetConcluidas.Tables.AddRange(new System.Data.DataTable[] {
            this.tb_tarefasconcluidas,
            this.tb_tarefasconcluidasen});
            // 
            // tb_tarefasconcluidas
            // 
            this.tb_tarefasconcluidas.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12});
            this.tb_tarefasconcluidas.TableName = "tb_tarefasconcluidas";
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
            this.dataColumn9.ColumnName = "Data Conclusão";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "Data Início";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "Percentual";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "Prioridade";
            // 
            // tb_tarefasconcluidasen
            // 
            this.tb_tarefasconcluidasen.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16,
            this.dataColumn17,
            this.dataColumn18});
            this.tb_tarefasconcluidasen.Locale = new System.Globalization.CultureInfo("en");
            this.tb_tarefasconcluidasen.TableName = "tb_tarefasconcluidasen";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "Id";
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "Title";
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "Completion Date";
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "Start Date";
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "Priority";
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "Percentage";
            // 
            // bt_atualizar
            // 
            resources.ApplyResources(this.bt_atualizar, "bt_atualizar");
            this.bt_atualizar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bt_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_atualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.UseVisualStyleBackColor = false;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.cb_prioridadeTarefa);
            this.panel3.Controls.Add(this.tb_name);
            this.panel3.Name = "panel3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // cb_prioridadeTarefa
            // 
            resources.ApplyResources(this.cb_prioridadeTarefa, "cb_prioridadeTarefa");
            this.cb_prioridadeTarefa.FormattingEnabled = true;
            this.cb_prioridadeTarefa.Items.AddRange(new object[] {
            resources.GetString("cb_prioridadeTarefa.Items"),
            resources.GetString("cb_prioridadeTarefa.Items1"),
            resources.GetString("cb_prioridadeTarefa.Items2")});
            this.cb_prioridadeTarefa.Name = "cb_prioridadeTarefa";
            // 
            // tb_name
            // 
            resources.ApplyResources(this.tb_name, "tb_name");
            this.tb_name.Name = "tb_name";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tb_porcentagem);
            this.panel4.Controls.Add(this.bt_atualizar);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Name = "panel4";
            // 
            // tb_porcentagem
            // 
            resources.ApplyResources(this.tb_porcentagem, "tb_porcentagem");
            this.tb_porcentagem.Name = "tb_porcentagem";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // tb_tarefas
            // 
            resources.ApplyResources(this.tb_tarefas, "tb_tarefas");
            this.tb_tarefas.Controls.Add(this.tabPage1);
            this.tb_tarefas.Controls.Add(this.tabPage2);
            this.tb_tarefas.Name = "tb_tarefas";
            this.tb_tarefas.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.btn_exportarPDFPendente);
            this.tabPage1.Controls.Add(this.bt_editarPendente);
            this.tabPage1.Controls.Add(this.bt_excluirPendente);
            this.tabPage1.Controls.Add(this.dataGridTarefas);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_exportarPDFPendente
            // 
            resources.ApplyResources(this.btn_exportarPDFPendente, "btn_exportarPDFPendente");
            this.btn_exportarPDFPendente.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_exportarPDFPendente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportarPDFPendente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_exportarPDFPendente.Name = "btn_exportarPDFPendente";
            this.btn_exportarPDFPendente.UseVisualStyleBackColor = false;
            this.btn_exportarPDFPendente.Click += new System.EventHandler(this.btn_exportarPDFPendente_Click);
            // 
            // bt_editarPendente
            // 
            resources.ApplyResources(this.bt_editarPendente, "bt_editarPendente");
            this.bt_editarPendente.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bt_editarPendente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_editarPendente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_editarPendente.Name = "bt_editarPendente";
            this.bt_editarPendente.UseVisualStyleBackColor = false;
            this.bt_editarPendente.Click += new System.EventHandler(this.bt_editarPendente_Click);
            // 
            // bt_excluirPendente
            // 
            resources.ApplyResources(this.bt_excluirPendente, "bt_excluirPendente");
            this.bt_excluirPendente.BackColor = System.Drawing.Color.Black;
            this.bt_excluirPendente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_excluirPendente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_excluirPendente.Name = "bt_excluirPendente";
            this.bt_excluirPendente.UseVisualStyleBackColor = false;
            this.bt_excluirPendente.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // dataGridTarefas
            // 
            resources.ApplyResources(this.dataGridTarefas, "dataGridTarefas");
            this.dataGridTarefas.AllowUserToAddRows = false;
            this.dataGridTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTarefas.Name = "dataGridTarefas";
            this.dataGridTarefas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTarefas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTarefas_CellDoubleClick);
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.btn_exportarPDFConcluida);
            this.tabPage2.Controls.Add(this.bt_editarConcluida);
            this.tabPage2.Controls.Add(this.bt_excluirConcluida);
            this.tabPage2.Controls.Add(this.dataGridTarefaConcluidas);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_exportarPDFConcluida
            // 
            resources.ApplyResources(this.btn_exportarPDFConcluida, "btn_exportarPDFConcluida");
            this.btn_exportarPDFConcluida.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_exportarPDFConcluida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportarPDFConcluida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_exportarPDFConcluida.Name = "btn_exportarPDFConcluida";
            this.btn_exportarPDFConcluida.UseVisualStyleBackColor = false;
            this.btn_exportarPDFConcluida.Click += new System.EventHandler(this.btn_exportarPDFConcluida_Click);
            // 
            // bt_editarConcluida
            // 
            resources.ApplyResources(this.bt_editarConcluida, "bt_editarConcluida");
            this.bt_editarConcluida.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bt_editarConcluida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_editarConcluida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_editarConcluida.Name = "bt_editarConcluida";
            this.bt_editarConcluida.UseVisualStyleBackColor = false;
            this.bt_editarConcluida.Click += new System.EventHandler(this.bt_editarConcluida_Click);
            // 
            // bt_excluirConcluida
            // 
            resources.ApplyResources(this.bt_excluirConcluida, "bt_excluirConcluida");
            this.bt_excluirConcluida.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_excluirConcluida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_excluirConcluida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_excluirConcluida.Name = "bt_excluirConcluida";
            this.bt_excluirConcluida.UseVisualStyleBackColor = false;
            this.bt_excluirConcluida.Click += new System.EventHandler(this.bt_excluirConcluida_Click);
            // 
            // dataGridTarefaConcluidas
            // 
            resources.ApplyResources(this.dataGridTarefaConcluidas, "dataGridTarefaConcluidas");
            this.dataGridTarefaConcluidas.AllowUserToAddRows = false;
            this.dataGridTarefaConcluidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTarefaConcluidas.MultiSelect = false;
            this.dataGridTarefaConcluidas.Name = "dataGridTarefaConcluidas";
            this.dataGridTarefaConcluidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTarefaConcluidas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTarefasConcluidas_CellDoubleClick);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.tb_tarefas);
            this.panel1.Name = "panel1";
            // 
            // TarefaForms
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "TarefaForms";
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPendentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tarefapendente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tarefapendenteen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConcluidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tarefasconcluidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tarefasconcluidasen)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tb_tarefas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTarefas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTarefaConcluidas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.DataSet dataSetPendentes;
        private System.Data.DataTable tb_tarefapendente;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataSet dataSetConcluidas;
        private System.Data.DataTable tb_tarefasconcluidas;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_prioridadeTarefa;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tb_tarefas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bt_editarPendente;
        private System.Windows.Forms.Button bt_excluirPendente;
        private System.Windows.Forms.DataGridView dataGridTarefas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bt_editarConcluida;
        private System.Windows.Forms.Button bt_excluirConcluida;
        private System.Windows.Forms.DataGridView dataGridTarefaConcluidas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox tb_porcentagem;
        private System.Windows.Forms.Button btn_exportarPDFPendente;
        private System.Windows.Forms.Button btn_exportarPDFConcluida;
        private System.Data.DataTable tb_tarefapendenteen;
        private System.Data.DataColumn dataColumn19;
        private System.Data.DataColumn dataColumn20;
        private System.Data.DataColumn dataColumn21;
        private System.Data.DataColumn dataColumn22;
        private System.Data.DataColumn dataColumn23;
        private System.Data.DataColumn dataColumn24;
        private System.Data.DataTable tb_tarefasconcluidasen;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn18;
    }
}

