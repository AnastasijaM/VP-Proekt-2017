using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Proekt_Besilka
{
    [Serializable]
    public class WordToGuess
    {
        public string Word { get; set; }
        public Category Cat { get; set; }

        public WordToGuess() { }
        public WordToGuess(string word, Category cat)
        {
            this.Word = word;
            this.Cat = cat;
        }
    }
}
