using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordGame
{
    public class WordBank
    {
        private List<string> words;
        private Random random;

        public WordBank(string filePath)
        {
            random = new Random();
            words = new List<string>();

            if (File.Exists(filePath))
            {
                foreach (var line in File.ReadAllLines(filePath))
                {
                    string trimmed = line.Trim();
                    if (!string.IsNullOrEmpty(trimmed))
                        words.Add(trimmed);
                }
            }
            else
            {
                throw new FileNotFoundException("kelime listesi dosyası bulunamadı", filePath);
            }
        }

        public string GetRandomWord()
        {
            if (words.Count == 0)
                return "";

            int index = random.Next(words.Count);
            return words[index];
        }
    }

}
