namespace MegaDesk_3_Zac_Bell
{
    partial class SearchQuotes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.custNameSearchTextBox = new System.Windows.Forms.TextBox();
            this.custNameSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 44);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(132, 29);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "<- Back Home";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 349);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // custNameSearchTextBox
            // 
            this.custNameSearchTextBox.Location = new System.Drawing.Point(12, 12);
            this.custNameSearchTextBox.Name = "custNameSearchTextBox";
            this.custNameSearchTextBox.Size = new System.Drawing.Size(410, 26);
            this.custNameSearchTextBox.TabIndex = 2;
            this.custNameSearchTextBox.TextChanged += new System.EventHandler(this.custNameSearchTextBox_TextChanged);
            // 
            // custNameSearchButton
            // 
            this.custNameSearchButton.Location = new System.Drawing.Point(450, 12);
            this.custNameSearchButton.Name = "custNameSearchButton";
            this.custNameSearchButton.Size = new System.Drawing.Size(317, 48);
            this.custNameSearchButton.TabIndex = 3;
            this.custNameSearchButton.Text = "Search for Customer Name";
            this.custNameSearchButton.UseVisualStyleBackColor = true;
            this.custNameSearchButton.Click += new System.EventHandler(this.custNameSearchButton_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 450);
            this.Controls.Add(this.custNameSearchButton);
            this.Controls.Add(this.custNameSearchTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitButton);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox custNameSearchTextBox;
        private System.Windows.Forms.Button custNameSearchButton;
    }
}