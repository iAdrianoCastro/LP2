
namespace CalcPesoIdeal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbPesoIdeal = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbPesoAtual = new System.Windows.Forms.MaskedTextBox();
            this.txtbAltura = new System.Windows.Forms.MaskedTextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.Feminino = new System.Windows.Forms.RadioButton();
            this.Masculino = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso Atual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbPesoIdeal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtbPesoAtual);
            this.groupBox1.Controls.Add(this.txtbAltura);
            this.groupBox1.Controls.Add(this.Calcular);
            this.groupBox1.Controls.Add(this.Feminino);
            this.groupBox1.Controls.Add(this.Masculino);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 399);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculadora de Peso Ideal";
            // 
            // txtbPesoIdeal
            // 
            this.txtbPesoIdeal.Culture = new System.Globalization.CultureInfo("es-US");
            this.txtbPesoIdeal.Location = new System.Drawing.Point(213, 293);
            this.txtbPesoIdeal.Name = "txtbPesoIdeal";
            this.txtbPesoIdeal.Size = new System.Drawing.Size(100, 29);
            this.txtbPesoIdeal.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Peso Ideal";
            // 
            // txtbPesoAtual
            // 
            this.txtbPesoAtual.Culture = new System.Globalization.CultureInfo("es-US");
            this.txtbPesoAtual.Location = new System.Drawing.Point(213, 148);
            this.txtbPesoAtual.Mask = "00,0";
            this.txtbPesoAtual.Name = "txtbPesoAtual";
            this.txtbPesoAtual.Size = new System.Drawing.Size(100, 29);
            this.txtbPesoAtual.TabIndex = 7;
            // 
            // txtbAltura
            // 
            this.txtbAltura.Culture = new System.Globalization.CultureInfo("en-US");
            this.txtbAltura.Location = new System.Drawing.Point(213, 104);
            this.txtbAltura.Mask = "0,00";
            this.txtbAltura.Name = "txtbAltura";
            this.txtbAltura.Size = new System.Drawing.Size(100, 29);
            this.txtbAltura.TabIndex = 6;
            this.txtbAltura.ValidatingType = typeof(int);
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(200, 358);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(141, 41);
            this.Calcular.TabIndex = 5;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Feminino
            // 
            this.Feminino.AutoSize = true;
            this.Feminino.Location = new System.Drawing.Point(331, 211);
            this.Feminino.Name = "Feminino";
            this.Feminino.Size = new System.Drawing.Size(104, 26);
            this.Feminino.TabIndex = 4;
            this.Feminino.TabStop = true;
            this.Feminino.Text = "Feminino";
            this.Feminino.UseVisualStyleBackColor = true;
            // 
            // Masculino
            // 
            this.Masculino.AutoSize = true;
            this.Masculino.Location = new System.Drawing.Point(200, 211);
            this.Masculino.Name = "Masculino";
            this.Masculino.Size = new System.Drawing.Size(113, 26);
            this.Masculino.TabIndex = 3;
            this.Masculino.TabStop = true;
            this.Masculino.Text = "Masculino";
            this.Masculino.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 415);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Atividade 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Feminino;
        private System.Windows.Forms.RadioButton Masculino;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.MaskedTextBox txtbAltura;
        private System.Windows.Forms.MaskedTextBox txtbPesoAtual;
        private System.Windows.Forms.MaskedTextBox txtbPesoIdeal;
        private System.Windows.Forms.Label label4;
    }
}

