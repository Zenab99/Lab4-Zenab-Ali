using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WordLibrary1;

namespace Lab4_Zenab_Ali
{
    public partial class NewList : Form
    {
        public WordList _wordList { get; set; }

        public NewList()
        {
            InitializeComponent();
        }       
        private void FormEdit_Load(object sender, EventArgs e)
        {
            buttonSaveNewList.Enabled = false;
        }

        private void buttonAddNewList_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = true;
            buttonUpdateWords.Enabled = false;
            buttonCancel.Enabled = true;
            string[] languages = textBoxLanguage.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            if (languages.Length > 1)
            {
                foreach (string language in languages)
                {
                    dataGridView1.Columns.Add(language, language);
                }
                dataGridView1.Visible = true;
            }
            else
            {
                MessageBox.Show("You must at least add two languages in the field to the left");
                buttonUpdateWords.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (WordList.GetLists().Contains(textBoxNameOfList.Text.ToLower()) || textBoxNameOfList.Text.Length == 0)
            {
                buttonSaveNewList.Enabled = false;
                buttonUpdateWords.Enabled = false;
                textBoxLanguage.Enabled = false;
            }
            else
            {
                buttonSaveNewList.Enabled = true;
                buttonUpdateWords.Enabled = true;
                textBoxLanguage.Enabled = true;
            }
        }


        private void buttonSaveNewList_Click(object sender, EventArgs e)
        {
                bool isntNull = true;
                string[] languages = new string[dataGridView1.Columns.Count];
                List<string[]> words = new List<string[]>();
                string[] wordsAdd = new string[dataGridView1.Columns.Count];

            if (buttonSaveNewList.Text == "Exit")
            {
                this.Close();
            }
            else
            {
                dataGridView1.AllowUserToAddRows = false;

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    languages[i] = dataGridView1.Columns[i].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            wordsAdd[j] = dataGridView1.Rows[i].Cells[j].Value.ToString().Replace(";", "");
                            isntNull = true;
                        }
                        else
                        {
                            MessageBox.Show("Every word has not been saved!");
                            isntNull = false;
                            dataGridView1.AllowUserToAddRows = false;
                            break;
                        }
                    }
                    if (isntNull)
                    {
                        words.Add(wordsAdd);
                    }
                    else
                    {
                        isntNull = false;
                    }
                }

                if (dataGridView1.Rows.Count < 1)
                {
                    MessageBox.Show("Add words to your list.");
                    dataGridView1.AllowUserToAddRows = true;
                }
                else
                {
                    _wordList = new WordList(textBoxNameOfList.Text, languages);
                    foreach (var word in words)
                    {
                        _wordList.Add(word);
                    }

                    _wordList.Save();
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            buttonUpdateWords.Enabled = true;
            buttonCancel.Enabled = false;
            dataGridView1.ReadOnly = false;
            dataGridView1.Enabled = true;
            buttonSaveNewList.Text = "Exit";
            textBoxLanguage.Focus();
        }

        private void textBoxLanguage_TextChanged(object sender, EventArgs e) {buttonUpdateWords.Enabled = true;}
        private void toolTip1_Popup(object sender, PopupEventArgs e){ }
        private void label2_Click(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}
    }
}