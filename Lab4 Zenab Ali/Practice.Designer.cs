namespace Lab4_Zenab_Ali
{
    partial class Practicesession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Practicesession));
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.PracticeWordBox = new System.Windows.Forms.TextBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ScoreAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AnswerBox
            // 
            this.AnswerBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AnswerBox.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold);
            this.AnswerBox.Location = new System.Drawing.Point(405, 378);
            this.AnswerBox.Margin = new System.Windows.Forms.Padding(4);
            this.AnswerBox.Multiline = true;
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(433, 86);
            this.AnswerBox.TabIndex = 2;
            this.AnswerBox.Text = "Write Your answer Here :)";
            this.AnswerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AnswerBox.TextChanged += new System.EventHandler(this.AnswerBox_TextChanged);
            // 
            // PracticeWordBox
            // 
            this.PracticeWordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PracticeWordBox.Location = new System.Drawing.Point(292, 139);
            this.PracticeWordBox.Margin = new System.Windows.Forms.Padding(4);
            this.PracticeWordBox.Multiline = true;
            this.PracticeWordBox.Name = "PracticeWordBox";
            this.PracticeWordBox.Size = new System.Drawing.Size(679, 231);
            this.PracticeWordBox.TabIndex = 3;
            this.PracticeWordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PracticeWordBox.TextChanged += new System.EventHandler(this.PracticeWordBox_TextChanged);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold);
            this.ScoreLabel.Location = new System.Drawing.Point(507, 85);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(163, 28);
            this.ScoreLabel.TabIndex = 36;
            this.ScoreLabel.Text = "Total Score:";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StopButton.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold);
            this.StopButton.Location = new System.Drawing.Point(292, 490);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(190, 54);
            this.StopButton.TabIndex = 51;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click_1);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.Lime;
            this.SubmitButton.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold);
            this.SubmitButton.Location = new System.Drawing.Point(813, 490);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(186, 54);
            this.SubmitButton.TabIndex = 52;
            this.SubmitButton.Text = "Finished";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.FinishButton_Click_1);
            // 
            // ScoreAmount
            // 
            this.ScoreAmount.Location = new System.Drawing.Point(667, 85);
            this.ScoreAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreAmount.Name = "ScoreAmount";
            this.ScoreAmount.Size = new System.Drawing.Size(43, 28);
            this.ScoreAmount.TabIndex = 47;
            this.ScoreAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScoreAmount.Click += new System.EventHandler(this.ScoreAmount_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(704, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 28);
            this.label1.TabIndex = 53;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Practicesession
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1212, 625);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.ScoreAmount);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.PracticeWordBox);
            this.Controls.Add(this.AnswerBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Practicesession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practice in Session";
            this.Load += new System.EventHandler(this.PracticeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.TextBox PracticeWordBox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label ScoreAmount;
        private System.Windows.Forms.Label label1;
    }
}