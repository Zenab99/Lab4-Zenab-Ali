namespace Lab4_Zenab_Ali
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listboxListNames = new System.Windows.Forms.ListBox();
            this.buttonNewList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPractice = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.WordCounter = new System.Windows.Forms.Label();
            this.buttonAddWords = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listboxListNames
            // 
            this.listboxListNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listboxListNames.FormattingEnabled = true;
            this.listboxListNames.ItemHeight = 16;
            this.listboxListNames.Location = new System.Drawing.Point(12, 46);
            this.listboxListNames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listboxListNames.Name = "listboxListNames";
            this.listboxListNames.Size = new System.Drawing.Size(379, 468);
            this.listboxListNames.TabIndex = 0;
            this.listboxListNames.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonNewList
            // 
            this.buttonNewList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonNewList.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonNewList.Location = new System.Drawing.Point(935, 568);
            this.buttonNewList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNewList.Name = "buttonNewList";
            this.buttonNewList.Size = new System.Drawing.Size(85, 42);
            this.buttonNewList.TabIndex = 2;
            this.buttonNewList.Text = "New List";
            this.buttonNewList.UseVisualStyleBackColor = false;
            this.buttonNewList.Click += new System.EventHandler(this.buttonCreateNewList);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(134, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "ListNames";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonPractice
            // 
            this.buttonPractice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPractice.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonPractice.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPractice.Location = new System.Drawing.Point(13, 551);
            this.buttonPractice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPractice.Name = "buttonPractice";
            this.buttonPractice.Size = new System.Drawing.Size(155, 59);
            this.buttonPractice.TabIndex = 6;
            this.buttonPractice.Text = "Practice";
            this.buttonPractice.UseVisualStyleBackColor = false;
            this.buttonPractice.Click += new System.EventHandler(this.buttonPracticeMode);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(398, 46);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(622, 468);
            this.dataGridView.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 8;
            // 
            // WordCounter
            // 
            this.WordCounter.AutoSize = true;
            this.WordCounter.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold);
            this.WordCounter.Location = new System.Drawing.Point(655, 20);
            this.WordCounter.Name = "WordCounter";
            this.WordCounter.Size = new System.Drawing.Size(130, 22);
            this.WordCounter.TabIndex = 9;
            this.WordCounter.Text = "Word List: ";
            this.WordCounter.Click += new System.EventHandler(this.WordCounter_Click);
            // 
            // buttonAddWords
            // 
            this.buttonAddWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddWords.BackColor = System.Drawing.Color.Navy;
            this.buttonAddWords.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonAddWords.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddWords.Location = new System.Drawing.Point(835, 568);
            this.buttonAddWords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddWords.Name = "buttonAddWords";
            this.buttonAddWords.Size = new System.Drawing.Size(82, 39);
            this.buttonAddWords.TabIndex = 10;
            this.buttonAddWords.Text = "Add words";
            this.buttonAddWords.UseVisualStyleBackColor = false;
            this.buttonAddWords.Click += new System.EventHandler(this.buttonAddNewWords);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(648, 568);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Remove Word";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonRemoveWords);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1033, 620);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddWords);
            this.Controls.Add(this.WordCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonPractice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNewList);
            this.Controls.Add(this.listboxListNames);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Vocabulary";
            this.Activated += new System.EventHandler(this.MainMenu_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxListNames;
        private System.Windows.Forms.Button buttonNewList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPractice;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label WordCounter;
        private System.Windows.Forms.Button buttonAddWords;
        private System.Windows.Forms.Button button1;
    }
}