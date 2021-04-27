
namespace Métodos
{
    partial class frmExercício4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btNum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btLetras = new System.Windows.Forms.Button();
            this.btBranco = new System.Windows.Forms.Button();
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbTexto);
            this.groupBox1.Controls.Add(this.btNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btLetras);
            this.groupBox1.Controls.Add(this.btBranco);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btNum
            // 
            this.btNum.Location = new System.Drawing.Point(6, 288);
            this.btNum.Name = "btNum";
            this.btNum.Size = new System.Drawing.Size(227, 95);
            this.btNum.TabIndex = 4;
            this.btNum.Text = "Quantidade de números";
            this.btNum.UseVisualStyleBackColor = true;
            this.btNum.Click += new System.EventHandler(this.btNum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto";
            // 
            // btLetras
            // 
            this.btLetras.Location = new System.Drawing.Point(532, 288);
            this.btLetras.Name = "btLetras";
            this.btLetras.Size = new System.Drawing.Size(227, 95);
            this.btLetras.TabIndex = 6;
            this.btLetras.Text = "Quantidade de letras";
            this.btLetras.UseVisualStyleBackColor = true;
            this.btLetras.Click += new System.EventHandler(this.btLetras_Click);
            // 
            // btBranco
            // 
            this.btBranco.Location = new System.Drawing.Point(261, 288);
            this.btBranco.Name = "btBranco";
            this.btBranco.Size = new System.Drawing.Size(227, 95);
            this.btBranco.TabIndex = 5;
            this.btBranco.Text = "Primeiro caractér branco";
            this.btBranco.UseVisualStyleBackColor = true;
            this.btBranco.Click += new System.EventHandler(this.btBranco_Click);
            // 
            // rtbTexto
            // 
            this.rtbTexto.Location = new System.Drawing.Point(261, 54);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(384, 128);
            this.rtbTexto.TabIndex = 7;
            this.rtbTexto.Text = "";
            // 
            // frmExercício4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmExercício4";
            this.Text = "frmExercício4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLetras;
        private System.Windows.Forms.Button btBranco;
        private System.Windows.Forms.RichTextBox rtbTexto;
    }
}