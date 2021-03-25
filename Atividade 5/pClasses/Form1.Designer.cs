
namespace pClasses
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
            this.btHorista = new System.Windows.Forms.Button();
            this.btMensalista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btHorista
            // 
            this.btHorista.Location = new System.Drawing.Point(95, 142);
            this.btHorista.Name = "btHorista";
            this.btHorista.Size = new System.Drawing.Size(225, 131);
            this.btHorista.TabIndex = 0;
            this.btHorista.Text = "Horista";
            this.btHorista.UseVisualStyleBackColor = true;
            this.btHorista.Click += new System.EventHandler(this.button1_Click);
            // 
            // btMensalista
            // 
            this.btMensalista.Location = new System.Drawing.Point(440, 142);
            this.btMensalista.Name = "btMensalista";
            this.btMensalista.Size = new System.Drawing.Size(225, 131);
            this.btMensalista.TabIndex = 1;
            this.btMensalista.Text = "Mensalista";
            this.btMensalista.UseVisualStyleBackColor = true;
            this.btMensalista.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btMensalista);
            this.Controls.Add(this.btHorista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btHorista;
        private System.Windows.Forms.Button btMensalista;
    }
}

