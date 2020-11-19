using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordLibrary1;

namespace ConsoleApp
{
    class Program
    {
        private static string[] Input(string[] input)
        {
            var argsInput = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                argsInput[i] = input[i];
            }
            return argsInput;

        }

        private static void Main(string[] args)
        {
            WordList _wordList = null;
            WordList.CreateFolder();


           
            if (args.Length == 0)
            {
                Console.WriteLine("Use any of the following parameters : ");
                Console.WriteLine("-lists");
                Console.WriteLine("-new <list name> <language 1> <language 2> ..<language n>");
                Console.WriteLine("-add <list name>");
                Console.WriteLine("-remove <list name > <language> <word1> <word2>... <word n>");
                Console.WriteLine("-words <listname> <sortByLanguage>");
                Console.WriteLine("-count <listname>");
                Console.WriteLine("-practice <listname>");

            }
            else
            {
                switch (Input(args)[0])
                {

                    case "-lists":
                        ListCon();                   

                        break;
                    case "-new":

                        try
                        {
                            AddNew();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid add new input, try again!");
                            Console.WriteLine();
                        }                       
                        break;
                    case "-add":
                        try
                        {
                            AddWords();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid add input, try again!");
                            Console.WriteLine();
                        }                        
                        break;
                    case "-remove":
                        try
                        {
                            ConsoleRemove();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid remove input, try again!");
                            Console.WriteLine();
                        }
                        
                        break;
                    case "-words":
                        try
                        {
                            ConsoleWords();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid input, try again!");
                            Console.WriteLine();
                        }                       
                        break;
                    case "-count":
                        try
                        {
                            ConsoleCount();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid input, try again!");
                            Console.WriteLine();
                        }                      
                        break;
                    case "-practice":
                        try
                        {
                            ConsolePractice();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid input, try again!");
                            Console.WriteLine();
                        }                       
                        break;

                }

            }                     





            void AddWords()
            {
                _wordList = WordList.LoadList(Input(args)[1]);
                if (_wordList == null)
                {
                    Console.WriteLine("Invalid list.");
                }
                else
                {
                    var word = "";
                    do
                    {
                        var newWord = new string[_wordList.Languages.Length];

                        for (var i = 0; i < _wordList.Languages.Length; i++)
                        {
                            Console.Write($"Write a word in {_wordList.Languages[i]}: ");
                            word = Console.ReadLine();

                            if (word == "") break;

                            newWord[i] = word;
                        }

                        if (!newWord.Contains(null))
                        {
                            _wordList.Add(newWord);
                        }
                    } while (word != "");

                    _wordList.Save();
                }
            }

            void ListCon()
            {
                string[] lists = WordList.GetLists();
                if (lists.Length > 0)
                {

                    Console.WriteLine("you have this Lists:");
                    Console.WriteLine();

                    foreach (var list in lists)
                    {
                        Console.WriteLine(list);
                    }
                }
                else
                {
                    Console.WriteLine("No lists available, make a new one!");

                }
                  var files = WordList.GetLists();
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }

            }

            void AddNew()
            {
               
                string name = Input(args)[1];
                var languageList = new string[Input(args).Length - 2];

                if (File.Exists(WordList.GetLists() + name + ".dat"))
                {
                    Console.WriteLine($"{name} already exists. Try again with a different name.");
                    return;
                }
                if (args.Length < 3)
                {
                    Console.WriteLine($"The list must have atleast 1 name and 2 languages. ");
                    return;
                }


                for (var i = 0; i < languageList.Length; i++)
                {
                    languageList[i] = Input(args)[i + 2];
                }

                _wordList = new WordList(name, languageList);
                _wordList.Save();
                ConsoleAdd();

            }

            void ConsoleAdd()
            {
                _wordList = WordList.LoadList(Input(args)[1]);
                if (_wordList == null)
                {
                    Console.WriteLine("Invalid list.");
                }
                else
                {
                    var word = "";
                    do
                    {
                        var newWord = new string[_wordList.Languages.Length];

                        for (var i = 0; i < _wordList.Languages.Length; i++)
                        {
                            Console.Write($"Write a word in {_wordList.Languages[i]}: ");
                            word = Console.ReadLine();

                            if (word == "")
                            {
                                break;
                            }

                            newWord[i] = word;
                        }

                        if (!newWord.Contains(null))
                        {
                            _wordList.Add(newWord);
                        }
                    }
                    while (word != "");
                    _wordList.Save();
                }
            }

            void ConsoleRemove()
            {
                _wordList = WordList.LoadList(Input(args)[1]);
                var language = Input(args)[2];
                var removeLang = 0;
                if (_wordList == null)
                {
                    Console.WriteLine("Invalid list.");
                }
                else
                {

                    for (var i = 0; i < _wordList.Languages.Length; i++)
                    {
                        if (_wordList.Languages[i] == language)
                        {
                            removeLang = i;
                        }
                    }

                    Console.WriteLine($"The words  {Input(args)[1]}  were removed from list.");
                    for (var i = 3; i < Input(args).Length; i++)
                        if (_wordList.Remove(removeLang, Input(args)[i]))
                        {
                            Console.WriteLine($"- {Input(args)[i]}");
                        }

                    _wordList.Save();
                }
            }

            void ConsoleWords()
            {
                _wordList = WordList.LoadList(Input(args)[1]);
                var langSort = Input(args)[2];
                var numberOfLanguages = 0;
                if (_wordList == null)
                {
                    Console.WriteLine("Invalid list.");
                }
                else
                {


                    for (var i = 0; i < _wordList.Languages.Length; i++)
                    {
                        if (langSort == _wordList.Languages[i])
                        {
                            numberOfLanguages = i;
                        }

                    }

                    Console.WriteLine();

                    foreach (var t in _wordList.Languages)
                    {
                        Console.Write($"{t.PadRight(20).ToLower()}");
                    }

                    Console.WriteLine();

                    Action<string[]> listWords = words =>
                    {
                        foreach (var t in words) Console.Write($"{t.PadRight(20)}");

                        Console.WriteLine();
                    };
                    _wordList.List(numberOfLanguages, listWords);
                    Console.WriteLine();
                }
            }


            void ConsoleCount()
            {
                _wordList = WordList.LoadList(Input(args)[1]);
                if (_wordList == null)
                {
                    Console.WriteLine("The List is not valid.");
                }
                else
                {
                    Console.WriteLine($"The numbers of words in {_wordList.Name} is: {_wordList.Count()}");
                }
            }

            void ConsolePractice()
            {
                _wordList = WordList.LoadList(Input(args)[1]);
                var input = "";
                var attemptedTranslations = 0.0;
                var correct = 0.0;
                if (_wordList == null)
                {
                    Console.WriteLine("Invalid list.");
                }
                else
                {

                    while (true)
                    {

                        Console.WriteLine();
                        var practiceWord = _wordList.GetWordToPractice();
                        Console.WriteLine($"The language is { _wordList.Languages[practiceWord.FromLanguage]} with the word: {practiceWord.Translations[practiceWord.FromLanguage]}");
                        Console.Write($"what is the translation for {_wordList.Languages[practiceWord.ToLanguage]}: ");
                        input = Console.ReadLine().ToLower();
                        attemptedTranslations++;

                        if (input == practiceWord.Translations[practiceWord.ToLanguage])
                        {
                            Console.WriteLine("Correct!");
                            correct++;
                        }
                        if (input != practiceWord.Translations[practiceWord.ToLanguage])
                        {
                            if (input == "")
                            {
                                attemptedTranslations--;
                                Console.WriteLine();
                                break;
                            }

                            Console.WriteLine("Sorry wrong answer!");
                        }
                    }

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Number of words you practiced: {attemptedTranslations}, : You got {correct} words right");
                        Console.WriteLine($"Your score: {correct / attemptedTranslations * 100:0}%");
                    }
                }
            }
        }



    }
}
