using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Proekt_Besilka
{
    
    public class Game
    {
        public List<Category> Categories;
        public List<WordToGuess> Words;
        public int points { get; set; }
        private Random random;
        private WordToGuess defaultWord;

        public Game()
        {
            Categories = new List<Category>();
            Words = new List<WordToGuess>();
            random = new Random();
            defaultWord = new WordToGuess("зборче", new Category("Default"));
            fillCategories();
            fillWords();
        }

        public WordToGuess GetWordFromCategory(Category category)
        {
            List<WordToGuess> wordsFromCategory = new List<WordToGuess>();
            foreach(WordToGuess wg in Words)
            {
                if (wg.Cat.Equals(category))
                {
                    wordsFromCategory.Add(wg);
                }
            }
            if (wordsFromCategory.Count > 0)
            {
                int index = random.Next(0, wordsFromCategory.Count);
                return wordsFromCategory[index];
            }
            return defaultWord;
        }

        private void fillCategories()
        {
            Category predmeti = new Category("Предмети");
            Categories.Add(predmeti);
            Category gradovi = new Category("Градови");
            Categories.Add(gradovi);
            Category sportovi = new Category("Спортови");
            Categories.Add(sportovi);
            Category iminja = new Category("Имиња");
            Categories.Add(iminja);

        }
        private void fillWords()
        {
            //предмети
            WordToGuess w1 = new WordToGuess("стебло", Categories[0]);
            Words.Add(w1);
            WordToGuess w2 = new WordToGuess("ветерница", Categories[0]);
            Words.Add(w2);
            WordToGuess w3 = new WordToGuess("столче", Categories[0]);
            Words.Add(w3);
            WordToGuess w4 = new WordToGuess("саксија", Categories[0]);
            Words.Add(w4);

            //градови
            WordToGuess w5 = new WordToGuess("Лондон", Categories[1]);
            Words.Add(w5);
            WordToGuess w6 = new WordToGuess("Скопје", Categories[1]);
            Words.Add(w6);
            WordToGuess w7 = new WordToGuess("Кавадарци", Categories[1]);
            Words.Add(w7);
            WordToGuess w8 = new WordToGuess("Прилеп", Categories[1]);
            Words.Add(w8);
            WordToGuess w9 = new WordToGuess("Белград", Categories[1]);
            Words.Add(w9);

            //спортови
            WordToGuess w10 = new WordToGuess("кошарка", Categories[2]);
            Words.Add(w10);
            WordToGuess w11 = new WordToGuess("ракомет", Categories[2]);
            Words.Add(w11);
            WordToGuess w12 = new WordToGuess("одбојка", Categories[2]);
            Words.Add(w12);
            WordToGuess w13 = new WordToGuess("тенис", Categories[2]);
            Words.Add(w13);
            WordToGuess w14 = new WordToGuess("бадмингтон", Categories[2]);
            Words.Add(w14);

            //имиња
            WordToGuess w15 = new WordToGuess("Анастасија", Categories[3]);
            Words.Add(w15);
            WordToGuess w16 = new WordToGuess("Борјан", Categories[3]);
            Words.Add(w16);
            WordToGuess w17 = new WordToGuess("Марко", Categories[3]);
            Words.Add(w17);
            WordToGuess w18 = new WordToGuess("Весна", Categories[3]);
            Words.Add(w18);
            WordToGuess w19 = new WordToGuess("Андријана", Categories[3]);
            Words.Add(w19);

        }
        

    }
}
