namespace Facade
{
    partial class Remote
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
            this.TVSettings = new System.Windows.Forms.GroupBox();
            this.TVInputState = new System.Windows.Forms.TextBox();
            this.TVPowerState = new System.Windows.Forms.TextBox();
            this.SurroundSounds = new System.Windows.Forms.GroupBox();
            this.SoundState = new System.Windows.Forms.TextBox();
            this.DVDPlayer = new System.Windows.Forms.GroupBox();
            this.DVDPowerState = new System.Windows.Forms.TextBox();
            this.GameSystem = new System.Windows.Forms.GroupBox();
            this.GamePowerState = new System.Windows.Forms.TextBox();
            this.PowerBtn = new System.Windows.Forms.Button();
            this.CableBtn = new System.Windows.Forms.Button();
            this.DVDBtn = new System.Windows.Forms.Button();
            this.GameBtn = new System.Windows.Forms.Button();
            this.PowerBtn2 = new System.Windows.Forms.Button();
            this.TVSettings.SuspendLayout();
            this.SurroundSounds.SuspendLayout();
            this.DVDPlayer.SuspendLayout();
            this.GameSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // TVSettings
            // 
            this.TVSettings.Controls.Add(this.TVInputState);
            this.TVSettings.Controls.Add(this.TVPowerState);
            this.TVSettings.Location = new System.Drawing.Point(13, 110);
            this.TVSettings.Name = "TVSettings";
            this.TVSettings.Size = new System.Drawing.Size(200, 100);
            this.TVSettings.TabIndex = 0;
            this.TVSettings.TabStop = false;
            this.TVSettings.Text = "TV Settings";
            // 
            // TVInputState
            // 
            this.TVInputState.Location = new System.Drawing.Point(6, 45);
            this.TVInputState.Name = "TVInputState";
            this.TVInputState.ReadOnly = true;
            this.TVInputState.Size = new System.Drawing.Size(100, 20);
            this.TVInputState.TabIndex = 1;
            this.TVInputState.TextChanged += new System.EventHandler(this.TVInputState_TextChanged);
            // 
            // TVPowerState
            // 
            this.TVPowerState.Location = new System.Drawing.Point(6, 19);
            this.TVPowerState.Name = "TVPowerState";
            this.TVPowerState.ReadOnly = true;
            this.TVPowerState.Size = new System.Drawing.Size(100, 20);
            this.TVPowerState.TabIndex = 0;
            this.TVPowerState.TextChanged += new System.EventHandler(this.TVPowerState_TextChanged);
            // 
            // SurroundSounds
            // 
            this.SurroundSounds.Controls.Add(this.SoundState);
            this.SurroundSounds.Location = new System.Drawing.Point(243, 110);
            this.SurroundSounds.Name = "SurroundSounds";
            this.SurroundSounds.Size = new System.Drawing.Size(200, 100);
            this.SurroundSounds.TabIndex = 1;
            this.SurroundSounds.TabStop = false;
            this.SurroundSounds.Text = "Surround Sound";
            // 
            // SoundState
            // 
            this.SoundState.Location = new System.Drawing.Point(6, 19);
            this.SoundState.Name = "SoundState";
            this.SoundState.ReadOnly = true;
            this.SoundState.Size = new System.Drawing.Size(100, 20);
            this.SoundState.TabIndex = 1;
            this.SoundState.TextChanged += new System.EventHandler(this.SoundState_TextChanged);
            // 
            // DVDPlayer
            // 
            this.DVDPlayer.Controls.Add(this.DVDPowerState);
            this.DVDPlayer.Location = new System.Drawing.Point(13, 216);
            this.DVDPlayer.Name = "DVDPlayer";
            this.DVDPlayer.Size = new System.Drawing.Size(200, 100);
            this.DVDPlayer.TabIndex = 2;
            this.DVDPlayer.TabStop = false;
            this.DVDPlayer.Text = "DVD Player";
            // 
            // DVDPowerState
            // 
            this.DVDPowerState.Location = new System.Drawing.Point(6, 19);
            this.DVDPowerState.Name = "DVDPowerState";
            this.DVDPowerState.ReadOnly = true;
            this.DVDPowerState.Size = new System.Drawing.Size(100, 20);
            this.DVDPowerState.TabIndex = 1;
            this.DVDPowerState.TextChanged += new System.EventHandler(this.DVDPowerState_TextChanged);
            // 
            // GameSystem
            // 
            this.GameSystem.Controls.Add(this.GamePowerState);
            this.GameSystem.Location = new System.Drawing.Point(243, 216);
            this.GameSystem.Name = "GameSystem";
            this.GameSystem.Size = new System.Drawing.Size(200, 100);
            this.GameSystem.TabIndex = 3;
            this.GameSystem.TabStop = false;
            this.GameSystem.Text = "Game System";
            // 
            // GamePowerState
            // 
            this.GamePowerState.Location = new System.Drawing.Point(6, 19);
            this.GamePowerState.Name = "GamePowerState";
            this.GamePowerState.ReadOnly = true;
            this.GamePowerState.Size = new System.Drawing.Size(100, 20);
            this.GamePowerState.TabIndex = 1;
            this.GamePowerState.TextChanged += new System.EventHandler(this.GamePowerState_TextChanged);
            // 
            // PowerBtn
            // 
            this.PowerBtn.Location = new System.Drawing.Point(19, 26);
            this.PowerBtn.Name = "PowerBtn";
            this.PowerBtn.Size = new System.Drawing.Size(75, 23);
            this.PowerBtn.TabIndex = 4;
            this.PowerBtn.Text = "Power ON";
            this.PowerBtn.UseVisualStyleBackColor = true;
            this.PowerBtn.Click += new System.EventHandler(this.PowerBtn_Click);
            // 
            // CableBtn
            // 
            this.CableBtn.Location = new System.Drawing.Point(112, 26);
            this.CableBtn.Name = "CableBtn";
            this.CableBtn.Size = new System.Drawing.Size(75, 23);
            this.CableBtn.TabIndex = 5;
            this.CableBtn.Text = "Cable";
            this.CableBtn.UseVisualStyleBackColor = true;
            this.CableBtn.Click += new System.EventHandler(this.CableBtn_Click);
            // 
            // DVDBtn
            // 
            this.DVDBtn.Location = new System.Drawing.Point(193, 26);
            this.DVDBtn.Name = "DVDBtn";
            this.DVDBtn.Size = new System.Drawing.Size(75, 23);
            this.DVDBtn.TabIndex = 6;
            this.DVDBtn.Text = "DVD";
            this.DVDBtn.UseVisualStyleBackColor = true;
            this.DVDBtn.Click += new System.EventHandler(this.DVDBtn_Click);
            // 
            // GameBtn
            // 
            this.GameBtn.Location = new System.Drawing.Point(274, 26);
            this.GameBtn.Name = "GameBtn";
            this.GameBtn.Size = new System.Drawing.Size(75, 23);
            this.GameBtn.TabIndex = 7;
            this.GameBtn.Text = "Game";
            this.GameBtn.UseVisualStyleBackColor = true;
            this.GameBtn.Click += new System.EventHandler(this.GameBtn_Click);
            // 
            // PowerBtn2
            // 
            this.PowerBtn2.Location = new System.Drawing.Point(368, 26);
            this.PowerBtn2.Name = "PowerBtn2";
            this.PowerBtn2.Size = new System.Drawing.Size(75, 23);
            this.PowerBtn2.TabIndex = 8;
            this.PowerBtn2.Text = "Power OFF";
            this.PowerBtn2.UseVisualStyleBackColor = true;
            this.PowerBtn2.Click += new System.EventHandler(this.PowerBtn2_Click);
            // 
            // Remote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 329);
            this.Controls.Add(this.PowerBtn2);
            this.Controls.Add(this.GameBtn);
            this.Controls.Add(this.DVDBtn);
            this.Controls.Add(this.CableBtn);
            this.Controls.Add(this.PowerBtn);
            this.Controls.Add(this.GameSystem);
            this.Controls.Add(this.DVDPlayer);
            this.Controls.Add(this.SurroundSounds);
            this.Controls.Add(this.TVSettings);
            this.Name = "Remote";
            this.Text = "Remote";
            this.TVSettings.ResumeLayout(false);
            this.TVSettings.PerformLayout();
            this.SurroundSounds.ResumeLayout(false);
            this.SurroundSounds.PerformLayout();
            this.DVDPlayer.ResumeLayout(false);
            this.DVDPlayer.PerformLayout();
            this.GameSystem.ResumeLayout(false);
            this.GameSystem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TVSettings;
        private System.Windows.Forms.TextBox TVInputState;
        private System.Windows.Forms.TextBox TVPowerState;
        private System.Windows.Forms.GroupBox SurroundSounds;
        private System.Windows.Forms.TextBox SoundState;
        private System.Windows.Forms.GroupBox DVDPlayer;
        private System.Windows.Forms.TextBox DVDPowerState;
        private System.Windows.Forms.GroupBox GameSystem;
        private System.Windows.Forms.Button PowerBtn;
        private System.Windows.Forms.Button CableBtn;
        private System.Windows.Forms.TextBox GamePowerState;
        private System.Windows.Forms.Button DVDBtn;
        private System.Windows.Forms.Button GameBtn;
        private System.Windows.Forms.Button PowerBtn2;
    }
}

