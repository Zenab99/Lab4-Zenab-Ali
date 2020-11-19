using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordLibrary1;


namespace Lab4_Zenab_Ali
{
    public partial class AddWord : Form
    {
        public string _Name { get; set; }

        public AddWord(string name)
        {
            InitializeComponent();
            _Name = name;
        }

        private void FormAddWords_Load(object sender, EventArgs e)
        {
            var languages = WordList.LoadList(_Name).Languages;
            foreach (var language in languages)
            {
                dataGridViewAddWords.Columns.Add("Languages", language.ToLower());
            }
            dataGridViewAddWords.Rows.Add();
        }

        private void buttonAddWordsConfirm_Click(object sender, EventArgs e)
        {
            var wordList = WordList.LoadList(_Name);
            for (int i = 0; i < dataGridViewAddWords.Rows.Count; i++)
            {
                var wordsArray = new string[wordList.Languages.Length];
                for (int j = 0; j < wordsArray.Length; j++)
                {
                    if (dataGridViewAddWords.Rows[i].Cells[j].Value != null)
                    {
                        wordsArray[j] = dataGridViewAddWords.Rows[i].Cells[j].Value.ToString();
                    }
                }
                if (!wordsArray.Contains(null))
                {
                    wordList.Add(wordsArray);
                }
            }
            wordList.Save();
            Close();
        }

        private void buttonAddWordsCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}