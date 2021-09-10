
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
            this.dataSetConcluidas = new System.Data.DataSet();
            this.tb_tarefasconcluidas = new System.Data.DataTable();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
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
            this.bt_editarPendente = new System.Windows.Forms.Button();
            this.bt_excluirPendente = new System.Windows.Forms.Button();
            this.dataGridTarefas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bt_editarConcluida = new System.Windows.Forms.Button();
            this.bt_excluirConcluida = new System.Windows.Forms.Button();
            this.dataGridTarefaConcluidas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPendentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tarefapendente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConcluidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tarefasconcluidas)).BeginInit();
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
            this.tb_tarefapendente});
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
            // dataSetConcluidas
            // 
            this.dataSetConcluidas.DataSetName = "NewDataSet";
            this.dataSetConcluidas.Tables.AddRange(new System.Data.DataTable[] {
            this.tb_tarefasconcluidas});
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
            // bt_atualizar
            // 
            this.bt_atualizar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bt_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_atualizar.Font = new System.Drawing.Font("Veneer", 10F);
            this.bt_atualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_atualizar.Location = new System.Drawing.Point(17, 76);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(153, 29);
            this.bt_atualizar.TabIndex = 5;
            this.bt_atualizar.Text = "Atualizar Porcentagem";
            this.bt_atualizar.UseVisualStyleBackColor = false;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.cb_prioridadeTarefa);
            this.panel3.Controls.Add(this.tb_name);
            this.panel3.Location = new System.Drawing.Point(12, 410);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 114);
            this.panel3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label5.Location = new System.Drawing.Point(46, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Prioridade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nome da Tarefa";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Veneer", 10F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(118, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Gravar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // cb_prioridadeTarefa
            // 
            this.cb_prioridadeTarefa.FormattingEnabled = true;
            this.cb_prioridadeTarefa.Items.AddRange(new object[] {
            "Baixa",
            "Normal",
            "Alta"});
            this.cb_prioridadeTarefa.Location = new System.Drawing.Point(118, 46);
            this.cb_prioridadeTarefa.Name = "cb_prioridadeTarefa";
            this.cb_prioridadeTarefa.Size = new System.Drawing.Size(178, 21);
            this.cb_prioridadeTarefa.TabIndex = 3;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(118, 20);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(178, 20);
            this.tb_name.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label4.Location = new System.Drawing.Point(60, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Percentual";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tb_porcentagem);
            this.panel4.Controls.Add(this.bt_atualizar);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(345, 410);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(182, 114);
            this.panel4.TabIndex = 3;
            // 
            // tb_porcentagem
            // 
            this.tb_porcentagem.Location = new System.Drawing.Point(66, 42);
            this.tb_porcentagem.Mask = "000%";
            this.tb_porcentagem.Name = "tb_porcentagem";
            this.tb_porcentagem.Size = new System.Drawing.Size(55, 20);
            this.tb_porcentagem.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-22, -65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // tb_tarefas
            // 
            this.tb_tarefas.Controls.Add(this.tabPage1);
            this.tb_tarefas.Controls.Add(this.tabPage2);
            this.tb_tarefas.Location = new System.Drawing.Point(17, 14);
            this.tb_tarefas.Name = "tb_tarefas";
            this.tb_tarefas.SelectedIndex = 0;
            this.tb_tarefas.Size = new System.Drawing.Size(502, 252);
            this.tb_tarefas.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bt_editarPendente);
            this.tabPage1.Controls.Add(this.bt_excluirPendente);
            this.tabPage1.Controls.Add(this.dataGridTarefas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(494, 226);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pendentes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bt_editarPendente
            // 
            this.bt_editarPendente.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bt_editarPendente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_editarPendente.Font = new System.Drawing.Font("Veneer", 10F);
            this.bt_editarPendente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_editarPendente.Location = new System.Drawing.Point(269, 190);
            this.bt_editarPendente.Name = "bt_editarPendente";
            this.bt_editarPendente.Size = new System.Drawing.Size(84, 29);
            this.bt_editarPendente.TabIndex = 4;
            this.bt_editarPendente.Text = "Editar";
            this.bt_editarPendente.UseVisualStyleBackColor = false;
            this.bt_editarPendente.Click += new System.EventHandler(this.bt_editarPendente_Click);
            // 
            // bt_excluirPendente
            // 
            this.bt_excluirPendente.BackColor = System.Drawing.Color.Black;
            this.bt_excluirPendente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_excluirPendente.Font = new System.Drawing.Font("Veneer", 10F);
            this.bt_excluirPendente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_excluirPendente.Location = new System.Drawing.Point(130, 190);
            this.bt_excluirPendente.Name = "bt_excluirPendente";
            this.bt_excluirPendente.Size = new System.Drawing.Size(84, 29);
            this.bt_excluirPendente.TabIndex = 3;
            this.bt_excluirPendente.Text = "Excluir";
            this.bt_excluirPendente.UseVisualStyleBackColor = false;
            this.bt_excluirPendente.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // dataGridTarefas
            // 
            this.dataGridTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTarefas.Location = new System.Drawing.Point(10, 6);
            this.dataGridTarefas.Name = "dataGridTarefas";
            this.dataGridTarefas.Size = new System.Drawing.Size(478, 174);
            this.dataGridTarefas.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bt_editarConcluida);
            this.tabPage2.Controls.Add(this.bt_excluirConcluida);
            this.tabPage2.Controls.Add(this.dataGridTarefaConcluidas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(494, 226);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Concluídas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bt_editarConcluida
            // 
            this.bt_editarConcluida.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bt_editarConcluida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_editarConcluida.Font = new System.Drawing.Font("Veneer", 10F);
            this.bt_editarConcluida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_editarConcluida.Location = new System.Drawing.Point(272, 191);
            this.bt_editarConcluida.Name = "bt_editarConcluida";
            this.bt_editarConcluida.Size = new System.Drawing.Size(84, 29);
            this.bt_editarConcluida.TabIndex = 2;
            this.bt_editarConcluida.Text = "Editar";
            this.bt_editarConcluida.UseVisualStyleBackColor = false;
            this.bt_editarConcluida.Click += new System.EventHandler(this.bt_editarConcluida_Click);
            // 
            // bt_excluirConcluida
            // 
            this.bt_excluirConcluida.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_excluirConcluida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_excluirConcluida.Font = new System.Drawing.Font("Veneer", 10F);
            this.bt_excluirConcluida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_excluirConcluida.Location = new System.Drawing.Point(129, 191);
            this.bt_excluirConcluida.Name = "bt_excluirConcluida";
            this.bt_excluirConcluida.Size = new System.Drawing.Size(84, 29);
            this.bt_excluirConcluida.TabIndex = 1;
            this.bt_excluirConcluida.Text = "Excluir";
            this.bt_excluirConcluida.UseVisualStyleBackColor = false;
            this.bt_excluirConcluida.Click += new System.EventHandler(this.bt_excluirConcluida_Click);
            // 
            // dataGridTarefaConcluidas
            // 
            this.dataGridTarefaConcluidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTarefaConcluidas.Location = new System.Drawing.Point(6, 6);
            this.dataGridTarefaConcluidas.Name = "dataGridTarefaConcluidas";
            this.dataGridTarefaConcluidas.Size = new System.Drawing.Size(478, 174);
            this.dataGridTarefaConcluidas.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.tb_tarefas);
            this.panel1.Location = new System.Drawing.Point(8, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 280);
            this.panel1.TabIndex = 1;
            // 
            // TarefaForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(561, 530);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TarefaForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minhas Tarefas";
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPendentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tarefapendente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConcluidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tarefasconcluidas)).EndInit();
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
    }
}

