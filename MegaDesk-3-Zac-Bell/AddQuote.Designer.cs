namespace MegaDesk_3_Zac_Bell
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.custNameInput = new System.Windows.Forms.TextBox();
            this.custNameLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.depthInput = new System.Windows.Forms.NumericUpDown();
            this.depthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.calcQuoteButton = new System.Windows.Forms.Button();
            this.drawersLabel = new System.Windows.Forms.Label();
            this.drawersInput = new System.Windows.Forms.NumericUpDown();
            this.surfaceMaterialInput = new System.Windows.Forms.ComboBox();
            this.rushOrderLabel = new System.Windows.Forms.Label();
            this.surfaceMaterialLabel = new System.Windows.Forms.Label();
            this.rushInput = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputQuoteText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersInput)).BeginInit();
            this.SuspendLayout();
            // 
            // custNameInput
            // 
            this.custNameInput.Location = new System.Drawing.Point(202, 8);
            this.custNameInput.Name = "custNameInput";
            this.custNameInput.Size = new System.Drawing.Size(174, 26);
            this.custNameInput.TabIndex = 0;
            this.custNameInput.TextChanged += new System.EventHandler(this.custNameInput_TextChanged);
            // 
            // custNameLabel
            // 
            this.custNameLabel.AutoSize = true;
            this.custNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNameLabel.Location = new System.Drawing.Point(12, 9);
            this.custNameLabel.Name = "custNameLabel";
            this.custNameLabel.Size = new System.Drawing.Size(160, 25);
            this.custNameLabel.TabIndex = 1;
            this.custNameLabel.Text = "Customer Name:";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(398, 174);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(169, 69);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(235, 41);
            this.widthInput.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthInput.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(141, 26);
            this.widthInput.TabIndex = 5;
            this.widthInput.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthInput.ValueChanged += new System.EventHandler(this.widthInput_ValueChanged);
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(235, 73);
            this.depthInput.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthInput.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(141, 26);
            this.depthInput.TabIndex = 6;
            this.depthInput.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthInput.ValueChanged += new System.EventHandler(this.depthInput_ValueChanged);
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(12, 74);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(202, 25);
            this.depthLabel.TabIndex = 7;
            this.depthLabel.Text = "Depth (12-48 inches):";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(12, 42);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(201, 25);
            this.widthLabel.TabIndex = 8;
            this.widthLabel.Text = "Width (24-96 inches):";
            // 
            // calcQuoteButton
            // 
            this.calcQuoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.calcQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcQuoteButton.Location = new System.Drawing.Point(398, 8);
            this.calcQuoteButton.Name = "calcQuoteButton";
            this.calcQuoteButton.Size = new System.Drawing.Size(169, 160);
            this.calcQuoteButton.TabIndex = 9;
            this.calcQuoteButton.Text = "Calculate Quote";
            this.calcQuoteButton.UseVisualStyleBackColor = false;
            this.calcQuoteButton.Click += new System.EventHandler(this.calcQuoteButton_Click);
            // 
            // drawersLabel
            // 
            this.drawersLabel.AutoSize = true;
            this.drawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersLabel.Location = new System.Drawing.Point(12, 108);
            this.drawersLabel.Name = "drawersLabel";
            this.drawersLabel.Size = new System.Drawing.Size(138, 25);
            this.drawersLabel.TabIndex = 11;
            this.drawersLabel.Text = "Drawers (0-7):";
            // 
            // drawersInput
            // 
            this.drawersInput.Location = new System.Drawing.Point(235, 107);
            this.drawersInput.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawersInput.Name = "drawersInput";
            this.drawersInput.Size = new System.Drawing.Size(141, 26);
            this.drawersInput.TabIndex = 10;
            this.drawersInput.ValueChanged += new System.EventHandler(this.drawersInput_ValueChanged);
            // 
            // surfaceMaterialInput
            // 
            this.surfaceMaterialInput.FormattingEnabled = true;
            this.surfaceMaterialInput.Location = new System.Drawing.Point(235, 140);
            this.surfaceMaterialInput.Name = "surfaceMaterialInput";
            this.surfaceMaterialInput.Size = new System.Drawing.Size(141, 28);
            this.surfaceMaterialInput.TabIndex = 15;
            this.surfaceMaterialInput.SelectedIndexChanged += new System.EventHandler(this.surfaceMaterialInput_SelectedIndexChanged);
            // 
            // rushOrderLabel
            // 
            this.rushOrderLabel.AutoSize = true;
            this.rushOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushOrderLabel.Location = new System.Drawing.Point(12, 174);
            this.rushOrderLabel.Name = "rushOrderLabel";
            this.rushOrderLabel.Size = new System.Drawing.Size(118, 25);
            this.rushOrderLabel.TabIndex = 16;
            this.rushOrderLabel.Text = "Rush Order:";
            // 
            // surfaceMaterialLabel
            // 
            this.surfaceMaterialLabel.AutoSize = true;
            this.surfaceMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMaterialLabel.Location = new System.Drawing.Point(12, 143);
            this.surfaceMaterialLabel.Name = "surfaceMaterialLabel";
            this.surfaceMaterialLabel.Size = new System.Drawing.Size(185, 25);
            this.surfaceMaterialLabel.TabIndex = 17;
            this.surfaceMaterialLabel.Text = "Material (5 options):";
            // 
            // rushInput
            // 
            this.rushInput.FormattingEnabled = true;
            this.rushInput.Location = new System.Drawing.Point(235, 175);
            this.rushInput.Name = "rushInput";
            this.rushInput.Size = new System.Drawing.Size(141, 28);
            this.rushInput.TabIndex = 18;
            this.rushInput.SelectedIndexChanged += new System.EventHandler(this.rushInput_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quote:";
            // 
            // outputQuoteText
            // 
            this.outputQuoteText.AutoSize = true;
            this.outputQuoteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputQuoteText.Location = new System.Drawing.Point(90, 218);
            this.outputQuoteText.Name = "outputQuoteText";
            this.outputQuoteText.Size = new System.Drawing.Size(27, 25);
            this.outputQuoteText.TabIndex = 20;
            this.outputQuoteText.Text = "   ";
            this.outputQuoteText.Click += new System.EventHandler(this.outputQuoteText_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 257);
            this.Controls.Add(this.outputQuoteText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rushInput);
            this.Controls.Add(this.surfaceMaterialLabel);
            this.Controls.Add(this.rushOrderLabel);
            this.Controls.Add(this.surfaceMaterialInput);
            this.Controls.Add(this.drawersLabel);
            this.Controls.Add(this.drawersInput);
            this.Controls.Add(this.calcQuoteButton);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.custNameLabel);
            this.Controls.Add(this.custNameInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(606, 313);
            this.MinimumSize = new System.Drawing.Size(606, 313);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox custNameInput;
        private System.Windows.Forms.Label custNameLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown widthInput;
        private System.Windows.Forms.NumericUpDown depthInput;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Button calcQuoteButton;
        private System.Windows.Forms.Label drawersLabel;
        private System.Windows.Forms.NumericUpDown drawersInput;
        private System.Windows.Forms.ComboBox surfaceMaterialInput;
        private System.Windows.Forms.Label rushOrderLabel;
        private System.Windows.Forms.Label surfaceMaterialLabel;
        private System.Windows.Forms.ComboBox rushInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputQuoteText;
    }
}