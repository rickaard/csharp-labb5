namespace Bounce
{
    partial class dialogForm
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
            this.dialogLabel = new System.Windows.Forms.Label();
            this.easyCheckBox = new System.Windows.Forms.CheckBox();
            this.hardCheckBox = new System.Windows.Forms.CheckBox();
            this.easyLabel = new System.Windows.Forms.Label();
            this.hardLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dialogLabel
            // 
            this.dialogLabel.AutoSize = true;
            this.dialogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogLabel.Location = new System.Drawing.Point(36, 22);
            this.dialogLabel.Name = "dialogLabel";
            this.dialogLabel.Size = new System.Drawing.Size(127, 16);
            this.dialogLabel.TabIndex = 0;
            this.dialogLabel.Text = "Välj svårighetsgrad:";
            // 
            // easyCheckBox
            // 
            this.easyCheckBox.AutoSize = true;
            this.easyCheckBox.Checked = true;
            this.easyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.easyCheckBox.Location = new System.Drawing.Point(39, 61);
            this.easyCheckBox.Name = "easyCheckBox";
            this.easyCheckBox.Size = new System.Drawing.Size(44, 17);
            this.easyCheckBox.TabIndex = 1;
            this.easyCheckBox.Text = "Lätt";
            this.easyCheckBox.UseVisualStyleBackColor = true;
            this.easyCheckBox.CheckedChanged += new System.EventHandler(this.easyCheckBox_CheckedChanged);
            // 
            // hardCheckBox
            // 
            this.hardCheckBox.AutoSize = true;
            this.hardCheckBox.Location = new System.Drawing.Point(251, 61);
            this.hardCheckBox.Name = "hardCheckBox";
            this.hardCheckBox.Size = new System.Drawing.Size(51, 17);
            this.hardCheckBox.TabIndex = 2;
            this.hardCheckBox.Text = "Svårt";
            this.hardCheckBox.UseVisualStyleBackColor = true;
            this.hardCheckBox.CheckedChanged += new System.EventHandler(this.hardCheckBox_CheckedChanged);
            // 
            // easyLabel
            // 
            this.easyLabel.AutoSize = true;
            this.easyLabel.Location = new System.Drawing.Point(36, 81);
            this.easyLabel.Name = "easyLabel";
            this.easyLabel.Size = new System.Drawing.Size(106, 13);
            this.easyLabel.TabIndex = 3;
            this.easyLabel.Text = "Liten vind och 5 kast";
            // 
            // hardLabel
            // 
            this.hardLabel.AutoSize = true;
            this.hardLabel.Location = new System.Drawing.Point(251, 81);
            this.hardLabel.Name = "hardLabel";
            this.hardLabel.Size = new System.Drawing.Size(103, 13);
            this.hardLabel.TabIndex = 4;
            this.hardLabel.Text = "Hög vind och 3 kast";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(39, 132);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Avbryt";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(279, 132);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "OK";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // dialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 167);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.hardLabel);
            this.Controls.Add(this.easyLabel);
            this.Controls.Add(this.hardCheckBox);
            this.Controls.Add(this.easyCheckBox);
            this.Controls.Add(this.dialogLabel);
            this.Name = "dialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inställningar";
            this.Load += new System.EventHandler(this.dialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dialogLabel;
        private System.Windows.Forms.CheckBox easyCheckBox;
        private System.Windows.Forms.CheckBox hardCheckBox;
        private System.Windows.Forms.Label easyLabel;
        private System.Windows.Forms.Label hardLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
    }
}