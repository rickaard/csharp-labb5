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
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gravityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.goButton.Location = new System.Drawing.Point(13, 459);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 0;
            this.goButton.Text = "Go!";
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
            this.gravityUpDown.Location = new System.Drawing.Point(401, 462);
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
            this.label1.Location = new System.Drawing.Point(355, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gravity";
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Location = new System.Drawing.Point(13, 13);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(508, 440);
            this.panel.TabIndex = 3;
            // 
            // Bounce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 494);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gravityUpDown);
            this.Controls.Add(this.goButton);
            this.Name = "Bounce";
            this.Text = "Bounce";
            ((System.ComponentModel.ISupportInitialize)(this.gravityUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.NumericUpDown gravityUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
    }
}

