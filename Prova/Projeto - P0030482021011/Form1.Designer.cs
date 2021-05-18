
namespace Projeto___P0030482021011
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.btVerif = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(511, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(262, 368);
            this.listBox.TabIndex = 0;
            // 
            // btVerif
            // 
            this.btVerif.Location = new System.Drawing.Point(106, 129);
            this.btVerif.Name = "btVerif";
            this.btVerif.Size = new System.Drawing.Size(244, 156);
            this.btVerif.TabIndex = 1;
            this.btVerif.Text = "Verificar";
            this.btVerif.UseVisualStyleBackColor = true;
            this.btVerif.Click += new System.EventHandler(this.btVerif_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(511, 392);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(89, 46);
            this.btLimpar.TabIndex = 2;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(687, 392);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(86, 46);
            this.btSair.TabIndex = 3;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btVerif);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Avaliação Prática ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btVerif;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btSair;
    }
}

