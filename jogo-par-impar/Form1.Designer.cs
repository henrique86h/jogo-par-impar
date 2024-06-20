namespace jogo_par_impar
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxJogador = new System.Windows.Forms.TextBox();
            this.radioButtonPar = new System.Windows.Forms.RadioButton();
            this.radioButtonImpar = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Jogador:";
            // 
            // textBoxJogador
            // 
            this.textBoxJogador.Location = new System.Drawing.Point(34, 52);
            this.textBoxJogador.Name = "textBoxJogador";
            this.textBoxJogador.Size = new System.Drawing.Size(250, 20);
            this.textBoxJogador.TabIndex = 1;
            // 
            // radioButtonPar
            // 
            this.radioButtonPar.AutoSize = true;
            this.radioButtonPar.Location = new System.Drawing.Point(34, 116);
            this.radioButtonPar.Name = "radioButtonPar";
            this.radioButtonPar.Size = new System.Drawing.Size(41, 17);
            this.radioButtonPar.TabIndex = 4;
            this.radioButtonPar.TabStop = true;
            this.radioButtonPar.Text = "Par";
            this.radioButtonPar.UseVisualStyleBackColor = true;
            // 
            // radioButtonImpar
            // 
            this.radioButtonImpar.AutoSize = true;
            this.radioButtonImpar.Location = new System.Drawing.Point(81, 116);
            this.radioButtonImpar.Name = "radioButtonImpar";
            this.radioButtonImpar.Size = new System.Drawing.Size(51, 17);
            this.radioButtonImpar.TabIndex = 5;
            this.radioButtonImpar.TabStop = true;
            this.radioButtonImpar.Text = "Ímpar";
            this.radioButtonImpar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Escolha";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(173, 116);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(126, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Jogar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 213);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonImpar);
            this.Controls.Add(this.radioButtonPar);
            this.Controls.Add(this.textBoxJogador);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxJogador;
        private System.Windows.Forms.RadioButton radioButtonPar;
        private System.Windows.Forms.RadioButton radioButtonImpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

