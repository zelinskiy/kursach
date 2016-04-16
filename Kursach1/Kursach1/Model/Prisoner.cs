using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kursach1
{
    public class Prisoner
    {
        public int Id;
        public string Name;
        public int Age;
        public int Article;
        public int Cell;

        public Prisoner() { }

        public Prisoner(
                int id,
                string name,
                int age,
                int article,
                int cell
        )
        {
            Id = id;
            Name = name;
            Age = age;
            Article = article;
            Cell = cell;
        }
        
    }

    
}
