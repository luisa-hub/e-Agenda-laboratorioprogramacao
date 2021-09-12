
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_tarefa
            // 
            resources.ApplyResources(this.bt_tarefa, "bt_tarefa");
            this.bt_tarefa.BackColor = System.Drawing.Color.DimGray;
            this.bt_tarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_tarefa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_tarefa.Name = "bt_tarefa";
            this.bt_tarefa.UseVisualStyleBackColor = false;
            this.bt_tarefa.Click += new System.EventHandler(this.bt_tarefa_Click);
            // 
            // bt_contatos
            // 
            resources.ApplyResources(this.bt_contatos, "bt_contatos");
            this.bt_contatos.BackColor = System.Drawing.Color.DimGray;
            this.bt_contatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_contatos.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_contatos.Name = "bt_contatos";
            this.bt_contatos.UseVisualStyleBackColor = false;
            this.bt_contatos.Click += new System.EventHandler(this.bt_contatos_Click);
            // 
            // bt_compromisso
            // 
            resources.ApplyResources(this.bt_compromisso, "bt_compromisso");
            this.bt_compromisso.BackColor = System.Drawing.Color.DimGray;
            this.bt_compromisso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_compromisso.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_compromisso.Name = "bt_compromisso";
            this.bt_compromisso.UseVisualStyleBackColor = false;
            this.bt_compromisso.Click += new System.EventHandler(this.bt_compromisso_Click);
            // 
            // bt_saida
            // 
            resources.ApplyResources(this.bt_saida, "bt_saida");
            this.bt_saida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_saida.Name = "bt_saida";
            this.bt_saida.UseVisualStyleBackColor = true;
            this.bt_saida.Click += new System.EventHandler(this.bt_saida_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageList1, "imageList1");
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGeral
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_saida);
            this.Controls.Add(this.bt_compromisso);
            this.Controls.Add(this.bt_contatos);
            this.Controls.Add(this.bt_tarefa);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FormGeral";
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
        private System.Windows.Forms.Button button1;
    }
}