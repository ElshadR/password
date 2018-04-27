namespace password
{
    partial class pass
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
            this.passwordd = new System.Windows.Forms.TextBox();
            this.reqem = new System.Windows.Forms.Button();
            this.kicikherif = new System.Windows.Forms.Button();
            this.boyukherif = new System.Windows.Forms.Button();
            this.simvol = new System.Windows.Forms.Button();
            this.minimum8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordd
            // 
            this.passwordd.Location = new System.Drawing.Point(132, 102);
            this.passwordd.Multiline = true;
            this.passwordd.Name = "passwordd";
            this.passwordd.Size = new System.Drawing.Size(329, 35);
            this.passwordd.TabIndex = 0;
            this.passwordd.TextChanged += new System.EventHandler(this.passwordd_TextChanged);
            // 
            // reqem
            // 
            this.reqem.BackColor = System.Drawing.Color.White;
            this.reqem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reqem.Location = new System.Drawing.Point(132, 171);
            this.reqem.Name = "reqem";
            this.reqem.Size = new System.Drawing.Size(75, 23);
            this.reqem.TabIndex = 1;
            this.reqem.UseVisualStyleBackColor = false;
            // 
            // kicikherif
            // 
            this.kicikherif.BackColor = System.Drawing.Color.White;
            this.kicikherif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kicikherif.Location = new System.Drawing.Point(132, 222);
            this.kicikherif.Name = "kicikherif";
            this.kicikherif.Size = new System.Drawing.Size(75, 23);
            this.kicikherif.TabIndex = 1;
            this.kicikherif.UseVisualStyleBackColor = false;
            // 
            // boyukherif
            // 
            this.boyukherif.BackColor = System.Drawing.Color.White;
            this.boyukherif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boyukherif.Location = new System.Drawing.Point(132, 274);
            this.boyukherif.Name = "boyukherif";
            this.boyukherif.Size = new System.Drawing.Size(75, 23);
            this.boyukherif.TabIndex = 1;
            this.boyukherif.UseVisualStyleBackColor = false;
            // 
            // simvol
            // 
            this.simvol.BackColor = System.Drawing.Color.White;
            this.simvol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simvol.Location = new System.Drawing.Point(252, 171);
            this.simvol.Name = "simvol";
            this.simvol.Size = new System.Drawing.Size(75, 23);
            this.simvol.TabIndex = 1;
            this.simvol.UseVisualStyleBackColor = false;
            // 
            // minimum8
            // 
            this.minimum8.BackColor = System.Drawing.Color.White;
            this.minimum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimum8.Location = new System.Drawing.Point(252, 222);
            this.minimum8.Name = "minimum8";
            this.minimum8.Size = new System.Drawing.Size(75, 23);
            this.minimum8.TabIndex = 1;
            this.minimum8.UseVisualStyleBackColor = false;
            // 
            // pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 435);
            this.Controls.Add(this.minimum8);
            this.Controls.Add(this.simvol);
            this.Controls.Add(this.boyukherif);
            this.Controls.Add(this.kicikherif);
            this.Controls.Add(this.reqem);
            this.Controls.Add(this.passwordd);
            this.Name = "pass";
            this.Text = "pass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordd;
        private System.Windows.Forms.Button reqem;
        private System.Windows.Forms.Button kicikherif;
        private System.Windows.Forms.Button boyukherif;
        private System.Windows.Forms.Button simvol;
        private System.Windows.Forms.Button minimum8;
    }
}