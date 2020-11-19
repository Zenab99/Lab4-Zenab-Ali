namespace Lab4_Zenab_Ali
{
    partial class AddWord
    { /// <summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWord));
            this.dataGridViewAddWords = new System.Windows.Forms.DataGridView();
            this.buttonAddWordsCancel = new System.Windows.Forms.Button();
            this.buttonAddWordsConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddWords)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAddWords
            // 
            this.dataGridViewAddWords.AllowUserToDeleteRows = false;
            this.dataGridViewAddWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAddWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddWords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAddWords.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewAddWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddWords.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewAddWords.Location = new System.Drawing.Point(55, 50);
            this.dataGridViewAddWords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewAddWords.Name = "dataGridViewAddWords";
            this.dataGridViewAddWords.RowHeadersVisible = false;
            this.dataGridViewAddWords.RowHeadersWidth = 51;
            this.dataGridViewAddWords.Size = new System.Drawing.Size(931, 399);
            this.dataGridViewAddWords.TabIndex = 0;
            // 
            // buttonAddWordsCancel
            // 
            this.buttonAddWordsCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddWordsCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAddWordsCancel.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonAddWordsCancel.Location = new System.Drawing.Point(55, 466);
            this.buttonAddWordsCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddWordsCancel.Name = "buttonAddWordsCancel";
            this.buttonAddWordsCancel.Size = new System.Drawing.Size(150, 44);
            this.buttonAddWordsCancel.TabIndex = 1;
            this.buttonAddWordsCancel.Text = "Cancel";
            this.buttonAddWordsCancel.UseVisualStyleBackColor = false;
            this.buttonAddWordsCancel.Click += new System.EventHandler(this.buttonAddWordsCancel_Click);
            // 
            // buttonAddWordsConfirm
            // 
            this.buttonAddWordsConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddWordsConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAddWordsConfirm.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonAddWordsConfirm.Location = new System.Drawing.Point(790, 466);
            this.buttonAddWordsConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddWordsConfirm.Name = "buttonAddWordsConfirm";
            this.buttonAddWordsConfirm.Size = new System.Drawing.Size(196, 44);
            this.buttonAddWordsConfirm.TabIndex = 2;
            this.buttonAddWordsConfirm.Text = "Confirm";
            this.buttonAddWordsConfirm.UseVisualStyleBackColor = false;
            this.buttonAddWordsConfirm.Click += new System.EventHandler(this.buttonAddWordsConfirm_Click);
            // 
            // AddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1027, 584);
            this.Controls.Add(this.buttonAddWordsConfirm);
            this.Controls.Add(this.buttonAddWordsCancel);
            this.Controls.Add(this.dataGridViewAddWords);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Words";
            this.Load += new System.EventHandler(this.FormAddWords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddWords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAddWords;
        private System.Windows.Forms.Button buttonAddWordsCancel;
        private System.Windows.Forms.Button buttonAddWordsConfirm;
    }
}