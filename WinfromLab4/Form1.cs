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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }      

            private void MainMenu_Activated(object sender, EventArgs e)
            {
                listboxListNames.Items.Clear();
                var files = WordList.GetLists();
                foreach (var file in files)
                {
                    listboxListNames.Items.Add(file);
                }
            }

            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (listboxListNames.SelectedItem != null)
                {
                    var languageNumeric = 0;
                   var name = listboxListNames.SelectedItem.ToString();
                    var languageList = WordList.LoadList(name).Languages;
                    dataGridView.Rows.Clear();
                    dataGridView.Columns.Clear();

                    foreach (var languages in languageList)
                    {
                        dataGridView.Columns.Add("", languages.ToUpper());
                    }

                    
                    WordList.LoadList(name).List(languageNumeric, x =>
                    {
                        dataGridView.Rows.Add(x);
                    });

                    WordCounter.Text = "Word List: " + WordList.LoadList(name).Count().ToString();
                }
            }

            private void buttonCreateNewList(object sender, EventArgs e)
            {
                NewList newList = new NewList();
                newList.ShowDialog();
            }

            private void buttonAddNewWords(object sender, EventArgs e)
            {
                if (listboxListNames.SelectedItem == null)
                {
                    MessageBox.Show("Choose a list to add word to first!");
                }
                else
                {
                    AddWord addWords = new AddWord(listboxListNames.SelectedItem.ToString());
                    addWords.ShowDialog();
                }
            }

            private void buttonPracticeMode(object sender, EventArgs e)
            {
                if (listboxListNames.SelectedItem == null)
                {
                    MessageBox.Show("Choose a list to practice on first!");
                }
                else
                {
                    Practicesession practice = new Practicesession(listboxListNames.SelectedItem.ToString());
                    practice.ShowDialog();
                }
            }

            private void buttonRemoveWords(object sender, EventArgs e)
            {
                var removeWords = WordList.LoadList(listboxListNames.SelectedItem.ToString());
                var selected = dataGridView.SelectedRows;
                var langInt = 0;

                if (selected.Count != 0)
                {
                    foreach (DataGridViewRow words in selected)
                    {
                        dataGridView.Rows.RemoveAt(words.Index);
                    }
                    removeWords.Remove(langInt, selected[0].Cells[0].Value.ToString());
                    removeWords.Save();
                }
            }

        private void WordCounter_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }