
namespace ProjetoFilaAtendimento {
    partial class FormAtendimento {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Btn_Gerar = new System.Windows.Forms.Button();
            this.Btn_Chamar = new System.Windows.Forms.Button();
            this.Btn_ListarSenhas = new System.Windows.Forms.Button();
            this.Btn_Adicionar = new System.Windows.Forms.Button();
            this.Btn_ListarAtendimentos = new System.Windows.Forms.Button();
            this.label_TituloGuiches = new System.Windows.Forms.Label();
            this.label_Guiche = new System.Windows.Forms.Label();
            this.ListBoxSenhas = new System.Windows.Forms.ListBox();
            this.ListBoxAtendimentos = new System.Windows.Forms.ListBox();
            this.textBoxGuiche = new System.Windows.Forms.TextBox();
            this.labelQuantidadeGuiches = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Gerar
            // 
            this.Btn_Gerar.Location = new System.Drawing.Point(62, 48);
            this.Btn_Gerar.Name = "Btn_Gerar";
            this.Btn_Gerar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Gerar.TabIndex = 0;
            this.Btn_Gerar.Text = "Gerar";
            this.Btn_Gerar.UseVisualStyleBackColor = true;
            this.Btn_Gerar.Click += new System.EventHandler(this.Btn_Gerar_Click);
            // 
            // Btn_Chamar
            // 
            this.Btn_Chamar.Location = new System.Drawing.Point(626, 58);
            this.Btn_Chamar.Name = "Btn_Chamar";
            this.Btn_Chamar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Chamar.TabIndex = 1;
            this.Btn_Chamar.Text = "Chamar";
            this.Btn_Chamar.UseVisualStyleBackColor = true;
            this.Btn_Chamar.Click += new System.EventHandler(this.Btn_Chamar_Click);
            // 
            // Btn_ListarSenhas
            // 
            this.Btn_ListarSenhas.Location = new System.Drawing.Point(35, 325);
            this.Btn_ListarSenhas.Name = "Btn_ListarSenhas";
            this.Btn_ListarSenhas.Size = new System.Drawing.Size(137, 23);
            this.Btn_ListarSenhas.TabIndex = 2;
            this.Btn_ListarSenhas.Text = "Listar senhas";
            this.Btn_ListarSenhas.UseVisualStyleBackColor = true;
            this.Btn_ListarSenhas.Click += new System.EventHandler(this.Btn_ListarSenhas_Click);
            // 
            // Btn_Adicionar
            // 
            this.Btn_Adicionar.Location = new System.Drawing.Point(303, 243);
            this.Btn_Adicionar.Name = "Btn_Adicionar";
            this.Btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Adicionar.TabIndex = 3;
            this.Btn_Adicionar.Text = "Adicionar";
            this.Btn_Adicionar.UseVisualStyleBackColor = true;
            this.Btn_Adicionar.Click += new System.EventHandler(this.Btn_Adicionar_Click);
            // 
            // Btn_ListarAtendimentos
            // 
            this.Btn_ListarAtendimentos.Location = new System.Drawing.Point(501, 325);
            this.Btn_ListarAtendimentos.Name = "Btn_ListarAtendimentos";
            this.Btn_ListarAtendimentos.Size = new System.Drawing.Size(161, 23);
            this.Btn_ListarAtendimentos.TabIndex = 4;
            this.Btn_ListarAtendimentos.Text = "Listar Atendimentos";
            this.Btn_ListarAtendimentos.UseVisualStyleBackColor = true;
            this.Btn_ListarAtendimentos.Click += new System.EventHandler(this.Btn_ListarAtendimentos_Click);
            // 
            // label_TituloGuiches
            // 
            this.label_TituloGuiches.AutoSize = true;
            this.label_TituloGuiches.Location = new System.Drawing.Point(303, 123);
            this.label_TituloGuiches.Name = "label_TituloGuiches";
            this.label_TituloGuiches.Size = new System.Drawing.Size(78, 15);
            this.label_TituloGuiches.TabIndex = 5;
            this.label_TituloGuiches.Text = "Qtde Guichês";
            // 
            // label_Guiche
            // 
            this.label_Guiche.AutoSize = true;
            this.label_Guiche.Location = new System.Drawing.Point(467, 61);
            this.label_Guiche.Name = "label_Guiche";
            this.label_Guiche.Size = new System.Drawing.Size(47, 15);
            this.label_Guiche.TabIndex = 6;
            this.label_Guiche.Text = "Guiche:";
            // 
            // ListBoxSenhas
            // 
            this.ListBoxSenhas.FormattingEnabled = true;
            this.ListBoxSenhas.ItemHeight = 15;
            this.ListBoxSenhas.Location = new System.Drawing.Point(12, 91);
            this.ListBoxSenhas.Name = "ListBoxSenhas";
            this.ListBoxSenhas.Size = new System.Drawing.Size(199, 214);
            this.ListBoxSenhas.TabIndex = 8;
            // 
            // ListBoxAtendimentos
            // 
            this.ListBoxAtendimentos.FormattingEnabled = true;
            this.ListBoxAtendimentos.ItemHeight = 15;
            this.ListBoxAtendimentos.Location = new System.Drawing.Point(467, 106);
            this.ListBoxAtendimentos.Name = "ListBoxAtendimentos";
            this.ListBoxAtendimentos.Size = new System.Drawing.Size(234, 199);
            this.ListBoxAtendimentos.TabIndex = 9;
            // 
            // textBoxGuiche
            // 
            this.textBoxGuiche.Location = new System.Drawing.Point(520, 58);
            this.textBoxGuiche.Name = "textBoxGuiche";
            this.textBoxGuiche.Size = new System.Drawing.Size(100, 23);
            this.textBoxGuiche.TabIndex = 10;
            // 
            // labelQuantidadeGuiches
            // 
            this.labelQuantidadeGuiches.AutoSize = true;
            this.labelQuantidadeGuiches.Location = new System.Drawing.Point(324, 168);
            this.labelQuantidadeGuiches.Name = "labelQuantidadeGuiches";
            this.labelQuantidadeGuiches.Size = new System.Drawing.Size(0, 15);
            this.labelQuantidadeGuiches.TabIndex = 11;
            // 
            // FormAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 451);
            this.Controls.Add(this.labelQuantidadeGuiches);
            this.Controls.Add(this.textBoxGuiche);
            this.Controls.Add(this.ListBoxAtendimentos);
            this.Controls.Add(this.ListBoxSenhas);
            this.Controls.Add(this.label_Guiche);
            this.Controls.Add(this.label_TituloGuiches);
            this.Controls.Add(this.Btn_ListarAtendimentos);
            this.Controls.Add(this.Btn_Adicionar);
            this.Controls.Add(this.Btn_ListarSenhas);
            this.Controls.Add(this.Btn_Chamar);
            this.Controls.Add(this.Btn_Gerar);
            this.Name = "FormAtendimento";
            this.Text = "Atendimento";
            this.Load += new System.EventHandler(this.FormAtendimento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Gerar;
        private System.Windows.Forms.Button Btn_Chamar;
        private System.Windows.Forms.Button Btn_ListarSenhas;
        private System.Windows.Forms.Button Btn_Adicionar;
        private System.Windows.Forms.Button Btn_ListarAtendimentos;
        private System.Windows.Forms.Label label_TituloGuiches;
        private System.Windows.Forms.Label label_Guiche;
        private System.Windows.Forms.ListBox ListBoxSenhas;
        private System.Windows.Forms.ListBox ListBoxAtendimentos;
        private System.Windows.Forms.TextBox textBoxGuiche;
        private System.Windows.Forms.Label labelQuantidadeGuiches;
    }
}

