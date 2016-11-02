namespace ProxyPattern
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
            this.cbPlayer1 = new System.Windows.Forms.ComboBox();
            this.cbPlayer2 = new System.Windows.Forms.ComboBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPlayer1
            // 
            this.cbPlayer1.DisplayMember = "none";
            this.cbPlayer1.FormattingEnabled = true;
            this.cbPlayer1.Location = new System.Drawing.Point(13, 13);
            this.cbPlayer1.Name = "cbPlayer1";
            this.cbPlayer1.Size = new System.Drawing.Size(121, 21);
            this.cbPlayer1.TabIndex = 0;
            this.cbPlayer1.Text = "Pick A Type";
            // 
            // cbPlayer2
            // 
            this.cbPlayer2.FormattingEnabled = true;
            this.cbPlayer2.Location = new System.Drawing.Point(317, 13);
            this.cbPlayer2.Name = "cbPlayer2";
            this.cbPlayer2.Size = new System.Drawing.Size(121, 21);
            this.cbPlayer2.TabIndex = 1;
            this.cbPlayer2.Text = "Pick A Type";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(13, 212);
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(422, 20);
            this.txtResults.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(187, 183);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Battle";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 261);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.cbPlayer2);
            this.Controls.Add(this.cbPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPlayer1;
        private System.Windows.Forms.ComboBox cbPlayer2;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnGo;
    }
}

