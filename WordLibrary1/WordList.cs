using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordLibrary1
{
   public class WordList
    {
        public string Name { get; }
        public string[] Languages { get; }
        
        
        private List<Word> words { get; } = new List<Word>();

        private static readonly string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static readonly string Specfile = Path.Combine(folder, "WordTrainer");



        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
        }


        public static string[] GetLists()
        {

            var files = Directory.GetFiles(Specfile).Select(Path.GetFileNameWithoutExtension).ToArray();
            return files;           

        }

        public static WordList LoadList(string name)
        {
            var folder = Specfile + "\\" + $"{name}.dat";

            if (File.Exists(folder))
            {
                var sr = new StreamReader(Specfile + "\\" + $"{name}.dat");
                var file = sr.ReadLine();
                var languages = file.TrimEnd(';').Split(';');
                var wordList = new WordList(name, languages);
                file = sr.ReadLine();

                while (file != null)
                {
                    var translation = new Word(file.TrimEnd(';').Split(';'));
                   
                    wordList.words.Add(translation);
                    file = sr.ReadLine();
                }

                sr.Close();
                return wordList;
            }

            return null;



        }


        public void Save()
        {

            var folder = Specfile + "\\" + $"{Name}.dat";
            if (File.Exists(folder))
            {
                var fs = new StreamWriter(folder);
                fs.WriteLine(Languages[0] + ";" + Languages[1]);
                foreach (var language in words)
                {
                    fs.WriteLine(language.Translations[0] + ";" + language.Translations[1]);


                }      
                fs.Close();
            }
            else
            {
                var fs = new StreamWriter(folder);
                    fs.WriteLine(Languages[0] + ";" + Languages[1]);
                    fs.Close();
                foreach (var language in words)
                {
                    fs.WriteLine(language.Translations[0] + ";" + language.Translations[1]);
                }
            }
                           

        }

        public void Add(params string[] translation)
        {
            var newword = new Word(translation);
            words.Add(newword);           

        }

        public Word GetWordToPractice()
        {          
             

            Random rnd = new Random();
            var rndWord = rnd.Next(0, words.Count);
            var fromLanguage = rnd.Next(0, Languages.Length);
            var toLanguage = rnd.Next(0, Languages.Length);            
            
            while (toLanguage == fromLanguage)
            {
                toLanguage = rnd.Next(0, Languages.Length);
            }
            Word word = new Word(fromLanguage, toLanguage, words[rndWord].Translations);
            return word;
        }

        public int Count()
        {
            return words.Count;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {

           var sortTrans = words.OrderBy(x => x.Translations[sortByTranslation]).ToList();
                            
            foreach (var translation in sortTrans)
            {
                showTranslations(translation.Translations);
            }
        }

        public bool Remove(int translations, string word)
        {
            var removeword = 0;
            if (words.Any(i => i.Translations[translations] == word))
                removeword =
                    words.IndexOf(words.First(i => i.Translations[translations] == word));
            words.RemoveAt(removeword);
            return true;

        }
        public static void CreateFolder()
        {
            Directory.CreateDirectory(Specfile);
        }
    }
}
