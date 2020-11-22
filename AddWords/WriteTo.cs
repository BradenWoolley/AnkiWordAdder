using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddWords
{
    class WriteTo
    {
        //File is contained within the Debug folder, this keeps the app easier to distribute but selecting a folder/file function can be implemented later.
        string file = "Translations.txt";
        //Appends words and translations using Anki's basic ';' formatting, override functions can be implemented to allow for Anki's html and other formats .
        public void WriteToFile(string word, string translation)
        {
            using(StreamWriter writer = new StreamWriter(file, true))
            {
                writer.WriteLine($"{word};{translation}");
            }
        }
        //Overwrites the textfile.
        public void Purge()
        {
            using (StreamWriter writer = new StreamWriter(file, false))
            {

            }
        }
        //Appends the chosen character in the correct case to the input field.s
        public string AddLetter(string letter, string sentence, bool upper)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(sentence);
            letter = (upper) ? letter : letter.ToLower();
            sb.Append(letter);
            return sb.ToString();
        }
    }
}
