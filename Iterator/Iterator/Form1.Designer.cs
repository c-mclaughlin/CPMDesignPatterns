namespace Iterator
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
            this.button1 = new System.Windows.Forms.Button();
            this.IteratedListCollection = new System.Windows.Forms.ListBox();
            this.Longest = new System.Windows.Forms.RadioButton();
            this.Shortest = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iterate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IteratedListCollection
            // 
            this.IteratedListCollection.FormattingEnabled = true;
            this.IteratedListCollection.Location = new System.Drawing.Point(25, 60);
            this.IteratedListCollection.Name = "IteratedListCollection";
            this.IteratedListCollection.Size = new System.Drawing.Size(252, 212);
            this.IteratedListCollection.TabIndex = 1;
            // 
            // Longest
            // 
            this.Longest.AutoSize = true;
            this.Longest.Location = new System.Drawing.Point(142, 22);
            this.Longest.Name = "Longest";
            this.Longest.Size = new System.Drawing.Size(117, 17);
            this.Longest.TabIndex = 2;
            this.Longest.TabStop = true;
            this.Longest.Text = "Known the Longest";
            this.Longest.UseVisualStyleBackColor = true;
            this.Longest.CheckedChanged += new System.EventHandler(this.Longest_CheckedChanged);
            // 
            // Shortest
            // 
            this.Shortest.AutoSize = true;
            this.Shortest.Location = new System.Drawing.Point(142, 37);
            this.Shortest.Name = "Shortest";
            this.Shortest.Size = new System.Drawing.Size(118, 17);
            this.Shortest.TabIndex = 3;
            this.Shortest.TabStop = true;
            this.Shortest.Text = "Known the Shortest";
            this.Shortest.UseVisualStyleBackColor = true;
            this.Shortest.CheckedChanged += new System.EventHandler(this.Shortest_CheckedChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(289, 284);
            this.Controls.Add(this.Shortest);
            this.Controls.Add(this.Longest);
            this.Controls.Add(this.IteratedListCollection);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion 
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox IteratedListCollection;
        private System.Windows.Forms.RadioButton Longest;
        private System.Windows.Forms.RadioButton Shortest;
    }
}

