
namespace eAgenda.WindowsForms
{
    partial class FormGeral
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGeral));
            this.bt_tarefa = new System.Windows.Forms.Button();
            this.bt_contatos = new System.Windows.Forms.Button();
            this.bt_compromisso = new System.Windows.Forms.Button();
            this.bt_saida = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_tarefa
            // 
            this.bt_tarefa.BackColor = System.Drawing.Color.DimGray;
            this.bt_tarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_tarefa.Font = new System.Drawing.Font("Veneer", 10F);
            this.bt_tarefa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_tarefa.Location = new System.Drawing.Point(86, 163);
            this.bt_tarefa.Name = "bt_tarefa";
            this.bt_tarefa.Size = new System.Drawing.Size(133, 31);
            this.bt_tarefa.TabIndex = 0;
            this.bt_tarefa.Text = "Minhas Tarefas";
            this.bt_tarefa.UseVisualStyleBackColor = false;
            this.bt_tarefa.Click += new System.EventHandler(this.bt_tarefa_Click);
            // 
            // bt_contatos
            // 
            this.bt_contatos.BackColor = System.Drawing.Color.DimGray;
            this.bt_contatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_contatos.Font = new System.Drawing.Font("Veneer", 10F);
            this.bt_contatos.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_contatos.Location = new System.Drawing.Point(86, 280);
            this.bt_contatos.Name = "bt_contatos";
            this.bt_contatos.Size = new System.Drawing.Size(133, 31);
            this.bt_contatos.TabIndex = 1;
            this.bt_contatos.Text = "Meus Contatos";
            this.bt_contatos.UseVisualStyleBackColor = false;
            this.bt_contatos.Click += new System.EventHandler(this.bt_contatos_Click);
            // 
            // bt_compromisso
            // 
            this.bt_compromisso.BackColor = System.Drawing.Color.DimGray;
            this.bt_compromisso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_compromisso.Font = new System.Drawing.Font("Veneer", 10F);
            this.bt_compromisso.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_compromisso.Location = new System.Drawing.Point(86, 221);
            this.bt_compromisso.Name = "bt_compromisso";
            this.bt_compromisso.Size = new System.Drawing.Size(133, 31);
            this.bt_compromisso.TabIndex = 2;
            this.bt_compromisso.Text = "Meus Compromissos";
            this.bt_compromisso.UseVisualStyleBackColor = false;
            this.bt_compromisso.Click += new System.EventHandler(this.bt_compromisso_Click);
            // 
            // bt_saida
            // 
            this.bt_saida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_saida.Font = new System.Drawing.Font("Veneer", 8F);
            this.bt_saida.Location = new System.Drawing.Point(228, 346);
            this.bt_saida.Name = "bt_saida";
            this.bt_saida.Size = new System.Drawing.Size(75, 23);
            this.bt_saida.TabIndex = 3;
            this.bt_saida.Text = "Sair";
            this.bt_saida.UseVisualStyleBackColor = true;
            this.bt_saida.Click += new System.EventHandler(this.bt_saida_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, -37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(321, 381);
            this.Controls.Add(this.bt_saida);
            this.Controls.Add(this.bt_compromisso);
            this.Controls.Add(this.bt_contatos);
            this.Controls.Add(this.bt_tarefa);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "FormGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_tarefa;
        private System.Windows.Forms.Button bt_contatos;
        private System.Windows.Forms.Button bt_compromisso;
        private System.Windows.Forms.Button bt_saida;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}