using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Proekt_Besilka
{
    [Serializable]
    public class Category
    {
        private static int _counter = 0;
        public int Id { get; set; }
        public string Name { get; set; }

        public Category() { }
        public Category(string name)
        {
            this.Id = System.Threading.Interlocked.Increment(ref _counter);
            this.Name = name;

        }
        public Category(string name, int Id)
        {
            this.Id = Id;
            this.Name = name;

        }
    }
}
