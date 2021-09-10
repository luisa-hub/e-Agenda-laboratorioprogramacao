
namespace eAgenda.WindowsForms
{
    partial class CompromissoForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompromissoForms));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Compromissos = new System.Windows.Forms.TabPage();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.dataGridCompromissos = new System.Windows.Forms.DataGridView();
            this.Passados = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dataPassado = new System.Windows.Forms.DateTimePicker();
            this.dataGridPassado = new System.Windows.Forms.DataGridView();
            this.Futuro = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataFuturoDois = new System.Windows.Forms.DateTimePicker();
            this.dataFuturoUm = new System.Windows.Forms.DateTimePicker();
            this.dataGridFuturo = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_editar = new System.Windows.Forms.Button();
            this.dt_data = new System.Windows.Forms.DateTimePicker();
            this.btGravar = new System.Windows.Forms.Button();
            this.tb_hora = new System.Windows.Forms.MaskedTextBox();
            this.tb_horai = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_contatos = new System.Windows.Forms.ComboBox();
            this.tb_link = new System.Windows.Forms.TextBox();
            this.tb_local = new System.Windows.Forms.TextBox();
            this.tb_assunto = new System.Windows.Forms.TextBox();
            this.dataSetCompromissos = new System.Data.DataSet();
            this.table_compromissos = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataSetPassado = new System.Data.DataSet();
            this.tablePassado = new System.Data.DataTable();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataSetFuturo = new System.Data.DataSet();
            this.tableFuturo = new System.Data.DataTable();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.dataColumn19 = new System.Data.DataColumn();
            this.dataColumn20 = new System.Data.DataColumn();
            this.dataColumn21 = new System.Data.DataColumn();
            this.dataColumn22 = new System.Data.DataColumn();
            this.dataColumn23 = new System.Data.DataColumn();
            this.dataColumn24 = new System.Data.DataColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Compromissos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompromissos)).BeginInit();
            this.Passados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPassado)).BeginInit();
            this.Futuro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuturo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCompromissos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_compromissos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPassado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePassado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFuturo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableFuturo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(32, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 270);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Compromissos);
            this.tabControl1.Controls.Add(this.Passados);
            this.tabControl1.Controls.Add(this.Futuro);
            this.tabControl1.Location = new System.Drawing.Point(0, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 260);
            this.tabControl1.TabIndex = 0;
            // 
            // Compromissos
            // 
            this.Compromissos.Controls.Add(this.bt_excluir);
            this.Compromissos.Controls.Add(this.dataGridCompromissos);
            this.Compromissos.Location = new System.Drawing.Point(4, 22);
            this.Compromissos.Name = "Compromissos";
            this.Compromissos.Padding = new System.Windows.Forms.Padding(3);
            this.Compromissos.Size = new System.Drawing.Size(452, 234);
            this.Compromissos.TabIndex = 0;
            this.Compromissos.Text = "Compromissos";
            this.Compromissos.UseVisualStyleBackColor = true;
            // 
            // bt_excluir
            // 
            this.bt_excluir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_excluir.Font = new System.Drawing.Font("Veneer", 10F);
            this.bt_excluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_excluir.Location = new System.Drawing.Point(185, 194);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(84, 29);
            this.bt_excluir.TabIndex = 3;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = false;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // dataGridCompromissos
            // 
            this.dataGridCompromissos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompromissos.Location = new System.Drawing.Point(10, 26);
            this.dataGridCompromissos.Name = "dataGridCompromissos";
            this.dataGridCompromissos.Size = new System.Drawing.Size(436, 150);
            this.dataGridCompromissos.TabIndex = 2;
            this.dataGridCompromissos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCompromissos_CellContentClick);
            // 
            // Passados
            // 
            this.Passados.Controls.Add(this.label2);
            this.Passados.Controls.Add(this.dataPassado);
            this.Passados.Controls.Add(this.dataGridPassado);
            this.Passados.Location = new System.Drawing.Point(4, 22);
            this.Passados.Name = "Passados";
            this.Passados.Padding = new System.Windows.Forms.Padding(3);
            this.Passados.Size = new System.Drawing.Size(452, 234);
            this.Passados.TabIndex = 1;
            this.Passados.Text = "Passados";
            this.Passados.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label2.Location = new System.Drawing.Point(109, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Data";
            // 
            // dataPassado
            // 
            this.dataPassado.Location = new System.Drawing.Point(145, 198);
            this.dataPassado.Name = "dataPassado";
            this.dataPassado.Size = new System.Drawing.Size(133, 20);
            this.dataPassado.TabIndex = 19;
            this.dataPassado.ValueChanged += new System.EventHandler(this.dataPassado_ValueChanged);
            // 
            // dataGridPassado
            // 
            this.dataGridPassado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPassado.Location = new System.Drawing.Point(10, 28);
            this.dataGridPassado.Name = "dataGridPassado";
            this.dataGridPassado.Size = new System.Drawing.Size(436, 150);
            this.dataGridPassado.TabIndex = 2;
            this.dataGridPassado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCompromissos_CellContentClick);
            // 
            // Futuro
            // 
            this.Futuro.Controls.Add(this.label10);
            this.Futuro.Controls.Add(this.label9);
            this.Futuro.Controls.Add(this.dataFuturoDois);
            this.Futuro.Controls.Add(this.dataFuturoUm);
            this.Futuro.Controls.Add(this.dataGridFuturo);
            this.Futuro.Location = new System.Drawing.Point(4, 22);
            this.Futuro.Name = "Futuro";
            this.Futuro.Size = new System.Drawing.Size(452, 234);
            this.Futuro.TabIndex = 2;
            this.Futuro.Text = "Futuros";
            this.Futuro.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label10.Location = new System.Drawing.Point(132, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Fim";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label9.Location = new System.Drawing.Point(126, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Início";
            // 
            // dataFuturoDois
            // 
            this.dataFuturoDois.Location = new System.Drawing.Point(165, 206);
            this.dataFuturoDois.Name = "dataFuturoDois";
            this.dataFuturoDois.Size = new System.Drawing.Size(133, 20);
            this.dataFuturoDois.TabIndex = 20;
            this.dataFuturoDois.ValueChanged += new System.EventHandler(this.dataFuturoDois_ValueChanged);
            // 
            // dataFuturoUm
            // 
            this.dataFuturoUm.Location = new System.Drawing.Point(165, 180);
            this.dataFuturoUm.Name = "dataFuturoUm";
            this.dataFuturoUm.Size = new System.Drawing.Size(133, 20);
            this.dataFuturoUm.TabIndex = 19;
            this.dataFuturoUm.ValueChanged += new System.EventHandler(this.dataFuturoUm_ValueChanged);
            // 
            // dataGridFuturo
            // 
            this.dataGridFuturo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFuturo.Location = new System.Drawing.Point(13, 24);
            this.dataGridFuturo.Name = "dataGridFuturo";
            this.dataGridFuturo.Size = new System.Drawing.Size(436, 150);
            this.dataGridFuturo.TabIndex = 1;
            this.dataGridFuturo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCompromissos_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_editar);
            this.panel2.Controls.Add(this.dt_data);
            this.panel2.Controls.Add(this.btGravar);
            this.panel2.Controls.Add(this.tb_hora);
            this.panel2.Controls.Add(this.tb_horai);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cb_contatos);
            this.panel2.Controls.Add(this.tb_link);
            this.panel2.Controls.Add(this.tb_local);
            this.panel2.Controls.Add(this.tb_assunto);
            this.panel2.Location = new System.Drawing.Point(32, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 186);
            this.panel2.TabIndex = 1;
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bt_editar.Font = new System.Drawing.Font("Veneer", 10F);
            this.bt_editar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_editar.Location = new System.Drawing.Point(238, 145);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(84, 29);
            this.bt_editar.TabIndex = 19;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // dt_data
            // 
            this.dt_data.Location = new System.Drawing.Point(68, 109);
            this.dt_data.Name = "dt_data";
            this.dt_data.Size = new System.Drawing.Size(133, 20);
            this.dt_data.TabIndex = 18;
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btGravar.Font = new System.Drawing.Font("Veneer", 10F);
            this.btGravar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btGravar.Location = new System.Drawing.Point(140, 145);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(84, 29);
            this.btGravar.TabIndex = 17;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = false;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // tb_hora
            // 
            this.tb_hora.Location = new System.Drawing.Point(192, 72);
            this.tb_hora.Mask = "00:00";
            this.tb_hora.Name = "tb_hora";
            this.tb_hora.Size = new System.Drawing.Size(38, 20);
            this.tb_hora.TabIndex = 15;
            this.tb_hora.ValidatingType = typeof(System.DateTime);
            // 
            // tb_horai
            // 
            this.tb_horai.Location = new System.Drawing.Point(83, 72);
            this.tb_horai.Mask = "00:00";
            this.tb_horai.Name = "tb_horai";
            this.tb_horai.Size = new System.Drawing.Size(38, 20);
            this.tb_horai.TabIndex = 14;
            this.tb_horai.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label8.Location = new System.Drawing.Point(32, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label7.Location = new System.Drawing.Point(138, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Término";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label6.Location = new System.Drawing.Point(17, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hora Início";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label5.Location = new System.Drawing.Point(274, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Link";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label4.Location = new System.Drawing.Point(224, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contatos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label3.Location = new System.Drawing.Point(295, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Local";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Assunto";
            // 
            // cb_contatos
            // 
            this.cb_contatos.DisplayMember = "Id";
            this.cb_contatos.FormattingEnabled = true;
            this.cb_contatos.Location = new System.Drawing.Point(285, 108);
            this.cb_contatos.Name = "cb_contatos";
            this.cb_contatos.Size = new System.Drawing.Size(149, 21);
            this.cb_contatos.TabIndex = 5;
            this.cb_contatos.ValueMember = "Id";
            // 
            // tb_link
            // 
            this.tb_link.Location = new System.Drawing.Point(307, 72);
            this.tb_link.Name = "tb_link";
            this.tb_link.Size = new System.Drawing.Size(127, 20);
            this.tb_link.TabIndex = 4;
            // 
            // tb_local
            // 
            this.tb_local.AcceptsReturn = true;
            this.tb_local.Location = new System.Drawing.Point(334, 34);
            this.tb_local.Name = "tb_local";
            this.tb_local.Size = new System.Drawing.Size(100, 20);
            this.tb_local.TabIndex = 1;
            // 
            // tb_assunto
            // 
            this.tb_assunto.Location = new System.Drawing.Point(68, 34);
            this.tb_assunto.Name = "tb_assunto";
            this.tb_assunto.Size = new System.Drawing.Size(196, 20);
            this.tb_assunto.TabIndex = 0;
            // 
            // dataSetCompromissos
            // 
            this.dataSetCompromissos.DataSetName = "NewDataSet";
            this.dataSetCompromissos.Tables.AddRange(new System.Data.DataTable[] {
            this.table_compromissos});
            // 
            // table_compromissos
            // 
            this.table_compromissos.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.table_compromissos.TableName = "table_compromissos";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Assunto";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Hora Início";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Hora Término";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Data";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Contato";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Local";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "Link";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, -95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataSetPassado
            // 
            this.dataSetPassado.DataSetName = "NewDataSet";
            this.dataSetPassado.Tables.AddRange(new System.Data.DataTable[] {
            this.tablePassado});
            // 
            // tablePassado
            // 
            this.tablePassado.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16});
            this.tablePassado.TableName = "tablePassado";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "Id";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "Assunto";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "Link";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "Local";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "Hora Início";
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "Hora Fim";
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "Contato";
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "Data";
            // 
            // dataSetFuturo
            // 
            this.dataSetFuturo.DataSetName = "NewDataSet";
            this.dataSetFuturo.Tables.AddRange(new System.Data.DataTable[] {
            this.tableFuturo});
            // 
            // tableFuturo
            // 
            this.tableFuturo.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn17,
            this.dataColumn18,
            this.dataColumn19,
            this.dataColumn20,
            this.dataColumn21,
            this.dataColumn22,
            this.dataColumn23,
            this.dataColumn24});
            this.tableFuturo.TableName = "tableFuturo";
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "Id";
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "Hora Término";
            // 
            // dataColumn19
            // 
            this.dataColumn19.ColumnName = "Hora Início";
            // 
            // dataColumn20
            // 
            this.dataColumn20.ColumnName = "Data";
            // 
            // dataColumn21
            // 
            this.dataColumn21.ColumnName = "Local";
            // 
            // dataColumn22
            // 
            this.dataColumn22.ColumnName = "Link";
            // 
            // dataColumn23
            // 
            this.dataColumn23.ColumnName = "Contato";
            // 
            // dataColumn24
            // 
            this.dataColumn24.ColumnName = "Assunto";
            // 
            // CompromissoForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(530, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CompromissoForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meus compromissos";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Compromissos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompromissos)).EndInit();
            this.Passados.ResumeLayout(false);
            this.Passados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPassado)).EndInit();
            this.Futuro.ResumeLayout(false);
            this.Futuro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuturo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCompromissos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_compromissos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPassado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePassado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFuturo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableFuturo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_contatos;
        private System.Windows.Forms.TextBox tb_link;
        private System.Windows.Forms.TextBox tb_local;
        private System.Windows.Forms.TextBox tb_assunto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Compromissos;
        private System.Windows.Forms.TabPage Passados;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.MaskedTextBox tb_hora;
        private System.Windows.Forms.MaskedTextBox tb_horai;
        private System.Windows.Forms.TabPage Futuro;
        private System.Data.DataSet dataSetCompromissos;
        private System.Data.DataTable table_compromissos;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.DataGridView dataGridFuturo;
        private System.Windows.Forms.DateTimePicker dt_data;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Data.DataSet dataSetPassado;
        private System.Data.DataTable tablePassado;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Windows.Forms.DataGridView dataGridPassado;
        private System.Windows.Forms.DataGridView dataGridCompromissos;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataPassado;
        private System.Data.DataSet dataSetFuturo;
        private System.Data.DataTable tableFuturo;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn18;
        private System.Data.DataColumn dataColumn19;
        private System.Data.DataColumn dataColumn20;
        private System.Data.DataColumn dataColumn21;
        private System.Data.DataColumn dataColumn22;
        private System.Data.DataColumn dataColumn23;
        private System.Data.DataColumn dataColumn24;
        private System.Windows.Forms.DateTimePicker dataFuturoDois;
        private System.Windows.Forms.DateTimePicker dataFuturoUm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_editar;
    }
}