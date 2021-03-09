
namespace Verif.Triângulo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btVerif = new System.Windows.Forms.Button();
            this.tbTipo = new System.Windows.Forms.MaskedTextBox();
            this.tbC = new System.Windows.Forms.MaskedTextBox();
            this.tbB = new System.Windows.Forms.MaskedTextBox();
            this.tbA = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btVerif);
            this.groupBox1.Controls.Add(this.tbTipo);
            this.groupBox1.Controls.Add(this.tbC);
            this.groupBox1.Controls.Add(this.tbB);
            this.groupBox1.Controls.Add(this.tbA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Triângulos";
            // 
            // btVerif
            // 
            this.btVerif.Location = new System.Drawing.Point(423, 316);
            this.btVerif.Name = "btVerif";
            this.btVerif.Size = new System.Drawing.Size(133, 104);
            this.btVerif.TabIndex = 8;
            this.btVerif.Text = "Verificar";
            this.btVerif.UseVisualStyleBackColor = true;
            this.btVerif.Click += new System.EventHandler(this.btVerif_Click);
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(209, 329);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(181, 29);
            this.tbTipo.TabIndex = 7;
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(209, 202);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(114, 29);
            this.tbC.TabIndex = 6;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(209, 157);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(114, 29);
            this.tbB.TabIndex = 5;
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(209, 122);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(114, 29);
            this.tbA.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Triângulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lado C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lado B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btVerif;
        private System.Windows.Forms.MaskedTextBox tbTipo;
        private System.Windows.Forms.MaskedTextBox tbC;
        private System.Windows.Forms.MaskedTextBox tbB;
        private System.Windows.Forms.MaskedTextBox tbA;
    }
}

