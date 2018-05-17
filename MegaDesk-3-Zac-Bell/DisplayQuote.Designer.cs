namespace MegaDesk_3_Zac_Bell
{
    partial class DisplayQuote
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
            this.exitButton = new System.Windows.Forms.Button();
            this.displayQuotesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.displayQuotesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(132, 29);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "<- Back Home";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displayQuotesGridView
            // 
            this.displayQuotesGridView.AllowUserToAddRows = false;
            this.displayQuotesGridView.AllowUserToDeleteRows = false;
            this.displayQuotesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.displayQuotesGridView.Location = new System.Drawing.Point(12, 53);
            this.displayQuotesGridView.Name = "displayQuotesGridView";
            this.displayQuotesGridView.ReadOnly = true;
            this.displayQuotesGridView.RowTemplate.Height = 28;
            this.displayQuotesGridView.Size = new System.Drawing.Size(1137, 214);
            this.displayQuotesGridView.TabIndex = 2;
            this.displayQuotesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayQuotesGridView_CellContentClick);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 279);
            this.Controls.Add(this.displayQuotesGridView);
            this.Controls.Add(this.exitButton);
            this.Name = "DisplayQuote";
            this.Text = "Display Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.displayQuotesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView displayQuotesGridView;
    }
}