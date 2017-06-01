namespace Autofahren
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
            this.StartpositionButton = new System.Windows.Forms.Button();
            this.FahrenButton = new System.Windows.Forms.Button();
            this.LangsamerButton = new System.Windows.Forms.Button();
            this.BeendenButton = new System.Windows.Forms.Button();
            this.SchnellerButton = new System.Windows.Forms.Button();
            this.StraßePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // StartpositionButton
            // 
            this.StartpositionButton.Location = new System.Drawing.Point(12, 136);
            this.StartpositionButton.Name = "StartpositionButton";
            this.StartpositionButton.Size = new System.Drawing.Size(75, 23);
            this.StartpositionButton.TabIndex = 0;
            this.StartpositionButton.Text = "Startposition";
            this.StartpositionButton.UseVisualStyleBackColor = true;
            this.StartpositionButton.Click += new System.EventHandler(this.StartpositionButton_Click);
            // 
            // FahrenButton
            // 
            this.FahrenButton.Location = new System.Drawing.Point(238, 136);
            this.FahrenButton.Name = "FahrenButton";
            this.FahrenButton.Size = new System.Drawing.Size(75, 23);
            this.FahrenButton.TabIndex = 1;
            this.FahrenButton.Text = "Fahren";
            this.FahrenButton.UseVisualStyleBackColor = true;
            this.FahrenButton.Click += new System.EventHandler(this.FahrenButton_Click);
            // 
            // LangsamerButton
            // 
            this.LangsamerButton.Location = new System.Drawing.Point(319, 136);
            this.LangsamerButton.Name = "LangsamerButton";
            this.LangsamerButton.Size = new System.Drawing.Size(75, 23);
            this.LangsamerButton.TabIndex = 2;
            this.LangsamerButton.Text = "Langsamer";
            this.LangsamerButton.UseVisualStyleBackColor = true;
            this.LangsamerButton.Click += new System.EventHandler(this.LangsamerButton_Click);
            // 
            // BeendenButton
            // 
            this.BeendenButton.Location = new System.Drawing.Point(700, 136);
            this.BeendenButton.Name = "BeendenButton";
            this.BeendenButton.Size = new System.Drawing.Size(75, 23);
            this.BeendenButton.TabIndex = 3;
            this.BeendenButton.Text = "Beenden";
            this.BeendenButton.UseVisualStyleBackColor = true;
            this.BeendenButton.Click += new System.EventHandler(this.BeendenButton_Click);
            // 
            // SchnellerButton
            // 
            this.SchnellerButton.Location = new System.Drawing.Point(400, 136);
            this.SchnellerButton.Name = "SchnellerButton";
            this.SchnellerButton.Size = new System.Drawing.Size(75, 23);
            this.SchnellerButton.TabIndex = 4;
            this.SchnellerButton.Text = "Schneller";
            this.SchnellerButton.UseVisualStyleBackColor = true;
            this.SchnellerButton.Click += new System.EventHandler(this.SchnellerButton_Click);
            // 
            // StraßePanel
            // 
            this.StraßePanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StraßePanel.Location = new System.Drawing.Point(12, 12);
            this.StraßePanel.Name = "StraßePanel";
            this.StraßePanel.Size = new System.Drawing.Size(763, 118);
            this.StraßePanel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 171);
            this.Controls.Add(this.StraßePanel);
            this.Controls.Add(this.SchnellerButton);
            this.Controls.Add(this.BeendenButton);
            this.Controls.Add(this.LangsamerButton);
            this.Controls.Add(this.FahrenButton);
            this.Controls.Add(this.StartpositionButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartpositionButton;
        private System.Windows.Forms.Button FahrenButton;
        private System.Windows.Forms.Button LangsamerButton;
        private System.Windows.Forms.Button BeendenButton;
        private System.Windows.Forms.Button SchnellerButton;
        private System.Windows.Forms.Panel StraßePanel;
    }
}

