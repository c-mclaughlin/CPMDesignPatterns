namespace Facade
{
    partial class Product
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
            this.CurrentSettings = new System.Windows.Forms.GroupBox();
            this.pwrState = new System.Windows.Forms.TextBox();
            this.inpState = new System.Windows.Forms.TextBox();
            this.sndState = new System.Windows.Forms.TextBox();
            this.dvdState = new System.Windows.Forms.TextBox();
            this.gameState = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentSettings
            // 
            this.CurrentSettings.Controls.Add(this.label4);
            this.CurrentSettings.Controls.Add(this.label3);
            this.CurrentSettings.Controls.Add(this.label2);
            this.CurrentSettings.Controls.Add(this.label1);
            this.CurrentSettings.Controls.Add(this.lbl1);
            this.CurrentSettings.Controls.Add(this.gameState);
            this.CurrentSettings.Controls.Add(this.dvdState);
            this.CurrentSettings.Controls.Add(this.sndState);
            this.CurrentSettings.Controls.Add(this.inpState);
            this.CurrentSettings.Controls.Add(this.pwrState);
            this.CurrentSettings.Location = new System.Drawing.Point(13, 13);
            this.CurrentSettings.Name = "CurrentSettings";
            this.CurrentSettings.Size = new System.Drawing.Size(259, 151);
            this.CurrentSettings.TabIndex = 0;
            this.CurrentSettings.TabStop = false;
            this.CurrentSettings.Text = "Current Settings";
            // 
            // pwrState
            // 
            this.pwrState.Location = new System.Drawing.Point(6, 19);
            this.pwrState.Name = "pwrState";
            this.pwrState.ReadOnly = true;
            this.pwrState.Size = new System.Drawing.Size(100, 20);
            this.pwrState.TabIndex = 0;
            // 
            // inpState
            // 
            this.inpState.Location = new System.Drawing.Point(6, 45);
            this.inpState.Name = "inpState";
            this.inpState.ReadOnly = true;
            this.inpState.Size = new System.Drawing.Size(100, 20);
            this.inpState.TabIndex = 1;
            // 
            // sndState
            // 
            this.sndState.Location = new System.Drawing.Point(6, 71);
            this.sndState.Name = "sndState";
            this.sndState.ReadOnly = true;
            this.sndState.Size = new System.Drawing.Size(100, 20);
            this.sndState.TabIndex = 2;
            // 
            // dvdState
            // 
            this.dvdState.Location = new System.Drawing.Point(6, 97);
            this.dvdState.Name = "dvdState";
            this.dvdState.ReadOnly = true;
            this.dvdState.Size = new System.Drawing.Size(100, 20);
            this.dvdState.TabIndex = 3;
            // 
            // gameState
            // 
            this.gameState.Location = new System.Drawing.Point(6, 123);
            this.gameState.Name = "gameState";
            this.gameState.ReadOnly = true;
            this.gameState.Size = new System.Drawing.Size(100, 20);
            this.gameState.TabIndex = 4;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(169, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(65, 13);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Power State";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input State";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sound State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DVD State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Game State";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CurrentSettings);
            this.Name = "Product";
            this.Text = "Product";
            this.CurrentSettings.ResumeLayout(false);
            this.CurrentSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CurrentSettings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox gameState;
        private System.Windows.Forms.TextBox dvdState;
        private System.Windows.Forms.TextBox sndState;
        private System.Windows.Forms.TextBox inpState;
        private System.Windows.Forms.TextBox pwrState;
    }
}