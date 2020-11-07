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
        
        private List<Word> words = new List<Word>();   

        public WordList(string name, params string[] languages)
        {
            Name = name.ToLower();
            Languages = languages;
        }


        public static string[] GetLists()
        {          
            Fold.CreateFolder();
            var files = Directory.GetFiles(Fold.Specfile).Select(Path.GetFileNameWithoutExtension).ToArray();
            return files;
        }

        public static WordList LoadList(string name)
        {
            Fold.CreateFolder();
            var sr = new StreamReader(Fold.GetFilePath(name));
            var lang = sr.ReadLine();
            var language = lang.ToLower().TrimEnd(';').Split(';');
            WordList wordList = new WordList(name, language);
            
            if (lang == null)
            {
                return null;
            }
            if (File.Exists(Fold.GetFilePath(name.ToLower())))
            {
                var file = Fold.GetFilePath(name);
                var fs = File.Create(file);
                fs.Close();

                while (!sr.EndOfStream)
                {
                    var translations = sr.ReadLine().TrimEnd(';').Split(';');
                    wordList.Add(translations);
                }
                return wordList;
            }
            return null;

        }

        public void Save()
        {
            LoadList(Name);
            var file = Fold.GetFilePath(Name);
            var fs = File.Create(Fold.GetFilePath(Name));
            fs.Close();

            foreach (var language in Languages)
            {
                
                File.AppendAllText(file, $"{language};");
            }
            foreach (var words in words)
            {
                File.AppendAllText(file, "\n");

                for (int i = 0; i < Languages.Length; i++)
                {
                    File.AppendAllText(file, $"{words.Translations[i]};");
                }
            }            

        }

        public void Add(params string[] translation)
        {
            if(translation.Length == Languages.Length)
            {
                words.Add(new Word(translation));
            }
            else 
            {
                throw new ArgumentException();
            }  

        }

        public Word GetWordToPractice()
        {
            LoadList(Name);
            Random rnd = new Random();
            int rndWord = rnd.Next(words.Count);           
            int fromLanguage = rnd.Next(Languages.Length);
            int toLanguage = rnd.Next(Languages.Length);            
            
            while (toLanguage == fromLanguage)
            {
                toLanguage = rnd.Next(Languages.Length);
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
            var sortTrans = words.OrderBy(x => x.Translations[sortByTranslation]).ToArray();

            LoadList(Name);            
            foreach (var translation in sortTrans)
            {
                showTranslations(translation.Translations);
            }
        }
        public bool Remove(int translations, string word)
        {
            var removeWord = words.Where(x => x.Translations[translations] != word).ToList();
            words = removeWord;
            Save();
            return true;
        }
       
    }
}
