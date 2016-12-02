namespace Template_Method
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
            this.btnMarvel = new System.Windows.Forms.Button();
            this.btnDC = new System.Windows.Forms.Button();
            this.txtList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMarvel
            // 
            this.btnMarvel.Location = new System.Drawing.Point(12, 73);
            this.btnMarvel.Name = "btnMarvel";
            this.btnMarvel.Size = new System.Drawing.Size(148, 23);
            this.btnMarvel.TabIndex = 0;
            this.btnMarvel.Text = "Marvel";
            this.btnMarvel.UseVisualStyleBackColor = true;
            this.btnMarvel.Click += new System.EventHandler(this.btnMarvel_Click);
            // 
            // btnDC
            // 
            this.btnDC.Location = new System.Drawing.Point(193, 73);
            this.btnDC.Name = "btnDC";
            this.btnDC.Size = new System.Drawing.Size(149, 23);
            this.btnDC.TabIndex = 1;
            this.btnDC.Text = "DC";
            this.btnDC.UseVisualStyleBackColor = true;
            this.btnDC.Click += new System.EventHandler(this.btnDC_Click);
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(12, 135);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.ReadOnly = true;
            this.txtList.Size = new System.Drawing.Size(330, 133);
            this.txtList.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 280);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.btnDC);
            this.Controls.Add(this.btnMarvel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMarvel;
        private System.Windows.Forms.Button btnDC;
        private System.Windows.Forms.TextBox txtList;
    }
}

