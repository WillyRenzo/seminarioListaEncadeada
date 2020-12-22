namespace wfaListaEncadeada
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_lista = new System.Windows.Forms.Label();
            this.txt_lista = new System.Windows.Forms.TextBox();
            this.txt_insereInicio = new System.Windows.Forms.TextBox();
            this.btn_insereInicio = new System.Windows.Forms.Button();
            this.btn_insereFinal = new System.Windows.Forms.Button();
            this.txt_insereFinal = new System.Windows.Forms.TextBox();
            this.btn_removeInicio = new System.Windows.Forms.Button();
            this.btn_removeFinal = new System.Windows.Forms.Button();
            this.btn_exibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_lista
            // 
            this.lbl_lista.AutoSize = true;
            this.lbl_lista.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lista.Location = new System.Drawing.Point(12, 9);
            this.lbl_lista.Name = "lbl_lista";
            this.lbl_lista.Size = new System.Drawing.Size(45, 19);
            this.lbl_lista.TabIndex = 0;
            this.lbl_lista.Text = "Lista:";
            this.lbl_lista.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_lista
            // 
            this.txt_lista.Location = new System.Drawing.Point(77, 12);
            this.txt_lista.Name = "txt_lista";
            this.txt_lista.Size = new System.Drawing.Size(233, 20);
            this.txt_lista.TabIndex = 1;
            this.txt_lista.TextChanged += new System.EventHandler(this.txt_lista_TextChanged);
            // 
            // txt_insereInicio
            // 
            this.txt_insereInicio.Location = new System.Drawing.Point(156, 47);
            this.txt_insereInicio.Name = "txt_insereInicio";
            this.txt_insereInicio.Size = new System.Drawing.Size(154, 20);
            this.txt_insereInicio.TabIndex = 2;
            this.txt_insereInicio.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_insereInicio
            // 
            this.btn_insereInicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insereInicio.Location = new System.Drawing.Point(16, 47);
            this.btn_insereInicio.Name = "btn_insereInicio";
            this.btn_insereInicio.Size = new System.Drawing.Size(124, 23);
            this.btn_insereInicio.TabIndex = 3;
            this.btn_insereInicio.Text = "Inserir no Início";
            this.btn_insereInicio.UseVisualStyleBackColor = true;
            this.btn_insereInicio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_insereInicio_MouseClick);
            // 
            // btn_insereFinal
            // 
            this.btn_insereFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insereFinal.Location = new System.Drawing.Point(16, 76);
            this.btn_insereFinal.Name = "btn_insereFinal";
            this.btn_insereFinal.Size = new System.Drawing.Size(124, 23);
            this.btn_insereFinal.TabIndex = 4;
            this.btn_insereFinal.Text = "Inserir no Final";
            this.btn_insereFinal.UseVisualStyleBackColor = true;
            this.btn_insereFinal.Click += new System.EventHandler(this.btn_insereFinal_Click);
            this.btn_insereFinal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_insereFinal_MouseClick);
            // 
            // txt_insereFinal
            // 
            this.txt_insereFinal.Location = new System.Drawing.Point(157, 79);
            this.txt_insereFinal.Name = "txt_insereFinal";
            this.txt_insereFinal.Size = new System.Drawing.Size(154, 20);
            this.txt_insereFinal.TabIndex = 5;
            // 
            // btn_removeInicio
            // 
            this.btn_removeInicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeInicio.Location = new System.Drawing.Point(16, 105);
            this.btn_removeInicio.Name = "btn_removeInicio";
            this.btn_removeInicio.Size = new System.Drawing.Size(294, 23);
            this.btn_removeInicio.TabIndex = 6;
            this.btn_removeInicio.Text = "Remover do Início";
            this.btn_removeInicio.UseVisualStyleBackColor = true;
            this.btn_removeInicio.Click += new System.EventHandler(this.btn_removeInicio_Click);
            this.btn_removeInicio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_removeInicio_MouseClick);
            // 
            // btn_removeFinal
            // 
            this.btn_removeFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeFinal.Location = new System.Drawing.Point(16, 134);
            this.btn_removeFinal.Name = "btn_removeFinal";
            this.btn_removeFinal.Size = new System.Drawing.Size(295, 23);
            this.btn_removeFinal.TabIndex = 8;
            this.btn_removeFinal.Text = "Remover do Final";
            this.btn_removeFinal.UseVisualStyleBackColor = true;
            this.btn_removeFinal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_removeFinal_MouseClick);
            // 
            // btn_exibir
            // 
            this.btn_exibir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exibir.Location = new System.Drawing.Point(16, 163);
            this.btn_exibir.Name = "btn_exibir";
            this.btn_exibir.Size = new System.Drawing.Size(294, 29);
            this.btn_exibir.TabIndex = 10;
            this.btn_exibir.Text = "Atualizar Lista";
            this.btn_exibir.UseVisualStyleBackColor = true;
            this.btn_exibir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_exibir_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 203);
            this.Controls.Add(this.btn_exibir);
            this.Controls.Add(this.btn_removeFinal);
            this.Controls.Add(this.btn_removeInicio);
            this.Controls.Add(this.txt_insereFinal);
            this.Controls.Add(this.btn_insereFinal);
            this.Controls.Add(this.btn_insereInicio);
            this.Controls.Add(this.txt_insereInicio);
            this.Controls.Add(this.txt_lista);
            this.Controls.Add(this.lbl_lista);
            this.Name = "Form1";
            this.Text = "Lista Duplamente Encadeada";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_lista;
        private System.Windows.Forms.TextBox txt_lista;
        private System.Windows.Forms.TextBox txt_insereInicio;
        private System.Windows.Forms.Button btn_insereInicio;
        private System.Windows.Forms.Button btn_insereFinal;
        private System.Windows.Forms.TextBox txt_insereFinal;
        private System.Windows.Forms.Button btn_removeInicio;
        private System.Windows.Forms.Button btn_removeFinal;
        private System.Windows.Forms.Button btn_exibir;
    }
}

