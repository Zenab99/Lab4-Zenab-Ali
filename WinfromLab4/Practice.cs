using System;
using WordLibrary1;
using System.Windows.Forms;



namespace Lab4_Zenab_Ali
{
    public partial class Practicesession : Form
    {
        private string fileName { get; }
        private Word WordForPractice { get; set; }
        private int Score { get; set; }   
        
        public Practicesession(string listName)
        {
            InitializeComponent();
            fileName = listName;
        }       

        private Word PracticeGenerator()
        {
            var _name = fileName;
            WordForPractice = WordList.LoadList(_name).GetWordToPractice();
            return WordForPractice;
        }

        private void PracticeForm_Load(object sender, EventArgs e)
        {
            PracticeGenerator();
            var _name = fileName;
            var LanguageList = WordList.LoadList(_name).Languages;
            PracticeWordBox.Text =
                $" The language is {LanguageList[WordForPractice.FromLanguage]} with the word {WordForPractice.Translations[WordForPractice.FromLanguage]}" +
                $"\r\n What is the translation for {LanguageList[WordForPractice.ToLanguage]}?";
        }

        private void FinishButton_Click_1(object sender, EventArgs e)
        {
            var _name = fileName;
            var languageList = WordList.LoadList(_name).Languages;
            var answer = AnswerBox.Text.ToLower();
            AnswerBox.Text = string.Empty;

            if (answer == WordForPractice.Translations[WordForPractice.ToLanguage].ToLower())
            {
                Score++;               
            }
            else
            {               
                var buttons = MessageBoxButtons.OK;
                MessageBox.Show($"Your answer {answer} was wrong. The correct answer is {WordForPractice.Translations[WordForPractice.ToLanguage].ToLower()} " + buttons);               
            }

            PracticeGenerator();
            PracticeWordBox.Text =
                $"Language:{languageList[WordForPractice.FromLanguage]} with the word {WordForPractice.Translations[WordForPractice.FromLanguage]}" +
                $"\r\n What is the translation for {languageList[WordForPractice.ToLanguage]}";
            ScoreAmount.Text = Score.ToString();           
        }

        private void StopButton_Click_1(object sender, EventArgs e)
        {
            var buttons = MessageBoxButtons.OK;
            MessageBox.Show($" End of the practice session. Your got {Score} correct answers." + buttons);
            Close();
        }

        private void AnswerBox_TextChanged(object sender, EventArgs e){}
        private void PracticeWordBox_TextChanged(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}
        private void ScoreAmount_Click(object sender, EventArgs e){ }
    }
}