namespace CompositePattern
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
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.btnTank = new System.Windows.Forms.Button();
            this.btnMagic = new System.Windows.Forms.Button();
            this.btnDamage = new System.Windows.Forms.Button();
            this.btnHealer = new System.Windows.Forms.Button();
            this.btnFighter = new System.Windows.Forms.Button();
            this.btnMage = new System.Windows.Forms.Button();
            this.btnPaladin = new System.Windows.Forms.Button();
            this.btnRogue = new System.Windows.Forms.Button();
            this.btnCleric = new System.Windows.Forms.Button();
            this.btnRanger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(173, 13);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.Size = new System.Drawing.Size(378, 416);
            this.txtResponse.TabIndex = 0;
            // 
            // btnTank
            // 
            this.btnTank.Location = new System.Drawing.Point(13, 13);
            this.btnTank.Name = "btnTank";
            this.btnTank.Size = new System.Drawing.Size(154, 42);
            this.btnTank.TabIndex = 1;
            this.btnTank.Text = "Tank";
            this.btnTank.UseVisualStyleBackColor = true;
            this.btnTank.Click += new System.EventHandler(this.btnTank_Click);
            // 
            // btnMagic
            // 
            this.btnMagic.Location = new System.Drawing.Point(13, 61);
            this.btnMagic.Name = "btnMagic";
            this.btnMagic.Size = new System.Drawing.Size(154, 42);
            this.btnMagic.TabIndex = 2;
            this.btnMagic.Text = "Magic";
            this.btnMagic.UseVisualStyleBackColor = true;
            this.btnMagic.Click += new System.EventHandler(this.btnMagic_Click);
            // 
            // btnDamage
            // 
            this.btnDamage.Location = new System.Drawing.Point(13, 109);
            this.btnDamage.Name = "btnDamage";
            this.btnDamage.Size = new System.Drawing.Size(154, 42);
            this.btnDamage.TabIndex = 3;
            this.btnDamage.Text = "Damage";
            this.btnDamage.UseVisualStyleBackColor = true;
            this.btnDamage.Click += new System.EventHandler(this.btnDamage_Click);
            // 
            // btnHealer
            // 
            this.btnHealer.Location = new System.Drawing.Point(13, 157);
            this.btnHealer.Name = "btnHealer";
            this.btnHealer.Size = new System.Drawing.Size(154, 42);
            this.btnHealer.TabIndex = 4;
            this.btnHealer.Text = "Healer";
            this.btnHealer.UseVisualStyleBackColor = true;
            this.btnHealer.Click += new System.EventHandler(this.btnHealer_Click);
            // 
            // btnFighter
            // 
            this.btnFighter.Location = new System.Drawing.Point(13, 206);
            this.btnFighter.Name = "btnFighter";
            this.btnFighter.Size = new System.Drawing.Size(75, 23);
            this.btnFighter.TabIndex = 5;
            this.btnFighter.Text = "Fighter";
            this.btnFighter.UseVisualStyleBackColor = true;
            this.btnFighter.Click += new System.EventHandler(this.btnFighter_Click);
            // 
            // btnMage
            // 
            this.btnMage.Location = new System.Drawing.Point(92, 206);
            this.btnMage.Name = "btnMage";
            this.btnMage.Size = new System.Drawing.Size(75, 23);
            this.btnMage.TabIndex = 6;
            this.btnMage.Text = "Mage";
            this.btnMage.UseVisualStyleBackColor = true;
            this.btnMage.Click += new System.EventHandler(this.btnMage_Click);
            // 
            // btnPaladin
            // 
            this.btnPaladin.Location = new System.Drawing.Point(12, 235);
            this.btnPaladin.Name = "btnPaladin";
            this.btnPaladin.Size = new System.Drawing.Size(75, 23);
            this.btnPaladin.TabIndex = 7;
            this.btnPaladin.Text = "Paladin";
            this.btnPaladin.UseVisualStyleBackColor = true;
            this.btnPaladin.Click += new System.EventHandler(this.btnPaladin_Click);
            // 
            // btnRogue
            // 
            this.btnRogue.Location = new System.Drawing.Point(92, 235);
            this.btnRogue.Name = "btnRogue";
            this.btnRogue.Size = new System.Drawing.Size(75, 23);
            this.btnRogue.TabIndex = 8;
            this.btnRogue.Text = "Rogue";
            this.btnRogue.UseVisualStyleBackColor = true;
            this.btnRogue.Click += new System.EventHandler(this.btnRogue_Click);
            // 
            // btnCleric
            // 
            this.btnCleric.Location = new System.Drawing.Point(13, 264);
            this.btnCleric.Name = "btnCleric";
            this.btnCleric.Size = new System.Drawing.Size(75, 23);
            this.btnCleric.TabIndex = 9;
            this.btnCleric.Text = "Cleric";
            this.btnCleric.UseVisualStyleBackColor = true;
            this.btnCleric.Click += new System.EventHandler(this.btnCleric_Click);
            // 
            // btnRanger
            // 
            this.btnRanger.Location = new System.Drawing.Point(94, 264);
            this.btnRanger.Name = "btnRanger";
            this.btnRanger.Size = new System.Drawing.Size(75, 23);
            this.btnRanger.TabIndex = 10;
            this.btnRanger.Text = "Ranger";
            this.btnRanger.UseVisualStyleBackColor = true;
            this.btnRanger.Click += new System.EventHandler(this.btnRanger_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 441);
            this.Controls.Add(this.btnRanger);
            this.Controls.Add(this.btnCleric);
            this.Controls.Add(this.btnRogue);
            this.Controls.Add(this.btnPaladin);
            this.Controls.Add(this.btnMage);
            this.Controls.Add(this.btnFighter);
            this.Controls.Add(this.btnHealer);
            this.Controls.Add(this.btnDamage);
            this.Controls.Add(this.btnMagic);
            this.Controls.Add(this.btnTank);
            this.Controls.Add(this.txtResponse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button btnTank;
        private System.Windows.Forms.Button btnMagic;
        private System.Windows.Forms.Button btnDamage;
        private System.Windows.Forms.Button btnHealer;
        private System.Windows.Forms.Button btnFighter;
        private System.Windows.Forms.Button btnMage;
        private System.Windows.Forms.Button btnPaladin;
        private System.Windows.Forms.Button btnRogue;
        private System.Windows.Forms.Button btnCleric;
        private System.Windows.Forms.Button btnRanger;
    }
}

