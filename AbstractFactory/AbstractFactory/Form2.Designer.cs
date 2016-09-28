namespace AbstractFactory
{
    partial class Form2
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
            this.lblSpecs = new System.Windows.Forms.Label();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblGPU = new System.Windows.Forms.Label();
            this.txtGPU = new System.Windows.Forms.TextBox();
            this.lblRam = new System.Windows.Forms.Label();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSpecs
            // 
            this.lblSpecs.AutoSize = true;
            this.lblSpecs.Location = new System.Drawing.Point(13, 13);
            this.lblSpecs.Name = "lblSpecs";
            this.lblSpecs.Size = new System.Drawing.Size(37, 13);
            this.lblSpecs.TabIndex = 0;
            this.lblSpecs.Text = "Specs";
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(112, 49);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.ReadOnly = true;
            this.txtCPU.Size = new System.Drawing.Size(160, 20);
            this.txtCPU.TabIndex = 1;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(16, 56);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(29, 13);
            this.lblCPU.TabIndex = 2;
            this.lblCPU.Text = "CPU";
            // 
            // lblGPU
            // 
            this.lblGPU.AutoSize = true;
            this.lblGPU.Location = new System.Drawing.Point(16, 85);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(30, 13);
            this.lblGPU.TabIndex = 3;
            this.lblGPU.Text = "GPU";
            // 
            // txtGPU
            // 
            this.txtGPU.Location = new System.Drawing.Point(112, 78);
            this.txtGPU.Name = "txtGPU";
            this.txtGPU.ReadOnly = true;
            this.txtGPU.Size = new System.Drawing.Size(160, 20);
            this.txtGPU.TabIndex = 4;
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(16, 112);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(29, 13);
            this.lblRam.TabIndex = 5;
            this.lblRam.Text = "Ram";
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(112, 104);
            this.txtRam.Name = "txtRam";
            this.txtRam.ReadOnly = true;
            this.txtRam.Size = new System.Drawing.Size(160, 20);
            this.txtRam.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 144);
            this.Controls.Add(this.txtRam);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.txtGPU);
            this.Controls.Add(this.lblGPU);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.txtCPU);
            this.Controls.Add(this.lblSpecs);
            this.Name = "Form2";
            this.Text = "Computer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpecs;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.TextBox txtGPU;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.TextBox txtRam;
    }
}