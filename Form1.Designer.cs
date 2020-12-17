namespace Operatorler
{
    partial class Form1
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
            this.btnToplama = new System.Windows.Forms.Button();
            this.btnCikartma = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btnBölme = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToplama
            // 
            this.btnToplama.Location = new System.Drawing.Point(11, 12);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(776, 84);
            this.btnToplama.TabIndex = 0;
            this.btnToplama.Text = "Toplama";
            this.btnToplama.UseVisualStyleBackColor = true;
            this.btnToplama.Click += new System.EventHandler(this.btnToplama_Click);
            // 
            // btnCikartma
            // 
            this.btnCikartma.Location = new System.Drawing.Point(12, 102);
            this.btnCikartma.Name = "btnCikartma";
            this.btnCikartma.Size = new System.Drawing.Size(776, 84);
            this.btnCikartma.TabIndex = 0;
            this.btnCikartma.Text = "Çıkartma";
            this.btnCikartma.UseVisualStyleBackColor = true;
            this.btnCikartma.Click += new System.EventHandler(this.btnCikartma_Click);
            // 
            // btnCarpma
            // 
            this.btnCarpma.Location = new System.Drawing.Point(12, 192);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(776, 84);
            this.btnCarpma.TabIndex = 0;
            this.btnCarpma.Text = "Çarpma";
            this.btnCarpma.UseVisualStyleBackColor = true;
            this.btnCarpma.Click += new System.EventHandler(this.btnCarpma_Click);
            // 
            // btnBölme
            // 
            this.btnBölme.Location = new System.Drawing.Point(12, 282);
            this.btnBölme.Name = "btnBölme";
            this.btnBölme.Size = new System.Drawing.Size(776, 84);
            this.btnBölme.TabIndex = 0;
            this.btnBölme.Text = "Bölme";
            this.btnBölme.UseVisualStyleBackColor = true;
            this.btnBölme.Click += new System.EventHandler(this.btnBölme_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(12, 372);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(776, 84);
            this.btnMod.TabIndex = 0;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 467);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnBölme);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btnCikartma);
            this.Controls.Add(this.btnToplama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.Button btnCikartma;
        private System.Windows.Forms.Button btnCarpma;
        private System.Windows.Forms.Button btnBölme;
        private System.Windows.Forms.Button btnMod;
    }
}

