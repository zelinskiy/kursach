using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach1.Model
{
    public class Cell
    {

        public int Capacity = 5;

        public int Id;

        public List<Prisoner> Members = new List<Prisoner>();

        public void Add(Prisoner p)
        {
            if(IsFull)
            {
                throw new ArgumentOutOfRangeException("This cell is full!");
            }
            else
            {
                Members.Add(p);
            }            
        }


        /*
        public void Remove(Prisoner p)
        {
            if(Members.Exists(x=>x.Id == p.Id))
            {
                Members.RemoveAll(x => x.Id == p.Id);
            }
            else
            {
                throw new ArgumentException("Prisoner " + p.Id + " not found!");
            }
        }
        */



        public bool IsFull
        {
            get
            {
                return Members.Count == Capacity;
            }            
        }

    }
}
