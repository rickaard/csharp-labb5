namespace Bounce
{
    partial class Bounce
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
            this.goButton = new System.Windows.Forms.Button();
            this.gravityUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amountLeftLabel = new System.Windows.Forms.Label();
            this.amountLeftNumber = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.speedUpDown = new System.Windows.Forms.NumericUpDown();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.restartGameButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gravityUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.goButton.Location = new System.Drawing.Point(13, 475);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 0;
            this.goButton.Text = "Skjut!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // gravityUpDown
            // 
            this.gravityUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gravityUpDown.DecimalPlaces = 2;
            this.gravityUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gravityUpDown.Location = new System.Drawing.Point(321, 476);
            this.gravityUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            65536});
            this.gravityUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gravityUpDown.Name = "gravityUpDown";
            this.gravityUpDown.Size = new System.Drawing.Size(120, 20);
            this.gravityUpDown.TabIndex = 1;
            this.gravityUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gravityUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.gravityUpDown.ValueChanged += new System.EventHandler(this.gravityUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(275, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gravity";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menyToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menyToolStripMenuItem
            // 
            this.menyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menyToolStripMenuItem.Name = "menyToolStripMenuItem";
            this.menyToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.menyToolStripMenuItem.Text = "Meny";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.settingsToolStripMenuItem.Text = "Inställningar";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exitToolStripMenuItem.Text = "Avsluta";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.aboutToolStripMenuItem.Text = "Om";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // amountLeftLabel
            // 
            this.amountLeftLabel.AutoSize = true;
            this.amountLeftLabel.Location = new System.Drawing.Point(459, 33);
            this.amountLeftLabel.Name = "amountLeftLabel";
            this.amountLeftLabel.Size = new System.Drawing.Size(66, 13);
            this.amountLeftLabel.TabIndex = 5;
            this.amountLeftLabel.Text = "Försök kvar:";
            // 
            // amountLeftNumber
            // 
            this.amountLeftNumber.AutoSize = true;
            this.amountLeftNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLeftNumber.Location = new System.Drawing.Point(531, 28);
            this.amountLeftNumber.Name = "amountLeftNumber";
            this.amountLeftNumber.Size = new System.Drawing.Size(18, 20);
            this.amountLeftNumber.TabIndex = 6;
            this.amountLeftNumber.Text = "5";
            // 
            // windLabel
            // 
            this.windLabel.AutoSize = true;
            this.windLabel.Location = new System.Drawing.Point(12, 33);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(66, 13);
            this.windLabel.TabIndex = 7;
            this.windLabel.Text = "Aktuell Vind:";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(121, 480);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(77, 13);
            this.speedLabel.TabIndex = 8;
            this.speedLabel.Text = "Skjuthastighet:";
            // 
            // speedUpDown
            // 
            this.speedUpDown.DecimalPlaces = 1;
            this.speedUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.speedUpDown.Location = new System.Drawing.Point(195, 478);
            this.speedUpDown.Name = "speedUpDown";
            this.speedUpDown.Size = new System.Drawing.Size(64, 20);
            this.speedUpDown.TabIndex = 9;
            this.speedUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.speedUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.speedUpDown.ValueChanged += new System.EventHandler(this.speedUpDown_ValueChanged);
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(228, 33);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(41, 13);
            this.pointsLabel.TabIndex = 10;
            this.pointsLabel.Text = "Poäng:";
            // 
            // restartGameButton
            // 
            this.restartGameButton.Location = new System.Drawing.Point(550, 473);
            this.restartGameButton.Name = "restartGameButton";
            this.restartGameButton.Size = new System.Drawing.Size(75, 23);
            this.restartGameButton.TabIndex = 11;
            this.restartGameButton.Text = "Starta om";
            this.restartGameButton.UseVisualStyleBackColor = true;
            this.restartGameButton.Click += new System.EventHandler(this.restartGameButton_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BackgroundImage = global::Bounce.Properties.Resources.football;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Location = new System.Drawing.Point(13, 58);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(612, 398);
            this.panel.TabIndex = 3;
            // 
            // Bounce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 510);
            this.Controls.Add(this.restartGameButton);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.speedUpDown);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.amountLeftNumber);
            this.Controls.Add(this.amountLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gravityUpDown);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Bounce";
            this.Text = "Labb 5";
            ((System.ComponentModel.ISupportInitialize)(this.gravityUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.NumericUpDown gravityUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label amountLeftLabel;
        private System.Windows.Forms.Label amountLeftNumber;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.NumericUpDown speedUpDown;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Button restartGameButton;
    }
}

