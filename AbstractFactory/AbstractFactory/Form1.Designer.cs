namespace AbstractFactory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPCTop = new System.Windows.Forms.Button();
            this.btnPC = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMacTop = new System.Windows.Forms.Button();
            this.btnMac = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPCTop);
            this.groupBox1.Controls.Add(this.btnPC);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PC";
            // 
            // btnPCTop
            // 
            this.btnPCTop.Location = new System.Drawing.Point(180, 38);
            this.btnPCTop.Name = "btnPCTop";
            this.btnPCTop.Size = new System.Drawing.Size(75, 23);
            this.btnPCTop.TabIndex = 1;
            this.btnPCTop.Text = "Laptop";
            this.btnPCTop.UseVisualStyleBackColor = true;
            this.btnPCTop.Click += new System.EventHandler(this.btnPCTop_Click);
            // 
            // btnPC
            // 
            this.btnPC.Location = new System.Drawing.Point(66, 39);
            this.btnPC.Name = "btnPC";
            this.btnPC.Size = new System.Drawing.Size(75, 23);
            this.btnPC.TabIndex = 0;
            this.btnPC.Text = "Desktop";
            this.btnPC.UseVisualStyleBackColor = true;
            this.btnPC.Click += new System.EventHandler(this.btnPC_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMacTop);
            this.groupBox2.Controls.Add(this.btnMac);
            this.groupBox2.Location = new System.Drawing.Point(13, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mac";
            // 
            // btnMacTop
            // 
            this.btnMacTop.Location = new System.Drawing.Point(180, 38);
            this.btnMacTop.Name = "btnMacTop";
            this.btnMacTop.Size = new System.Drawing.Size(75, 23);
            this.btnMacTop.TabIndex = 1;
            this.btnMacTop.Text = "Laptop";
            this.btnMacTop.UseVisualStyleBackColor = true;
            this.btnMacTop.Click += new System.EventHandler(this.btnMacTop_Click);
            // 
            // btnMac
            // 
            this.btnMac.Location = new System.Drawing.Point(66, 39);
            this.btnMac.Name = "btnMac";
            this.btnMac.Size = new System.Drawing.Size(75, 23);
            this.btnMac.TabIndex = 0;
            this.btnMac.Text = "Desktop";
            this.btnMac.UseVisualStyleBackColor = true;
            this.btnMac.Click += new System.EventHandler(this.btnMac_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 252);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPCTop;
        private System.Windows.Forms.Button btnPC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMacTop;
        private System.Windows.Forms.Button btnMac;
    }
}

