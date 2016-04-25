using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Kursach1.Model
{
    public class Cells : IEnumerable
    {

        public List<Cell> cells = new List<Cell>();


        public Cell Insert(Prisoner p)
        {
            Cell freeCell = getAvailableCell();
            p.Cell = freeCell.Id;
            freeCell.Add(p);
            return freeCell;
        }

        public Cell Insert(Prisoner p, int id)
        {
            int index = cells.FindIndex(x => x.Id == id);
            if (cells[index].IsFull)
            {
                throw new ArgumentException("Selected cell if full!");
            }
            cells[index].Add(p);
            return cells[index];
        }


        
        public void RemovePrisoner(int prisonerId)
        {
            for(int i=0;i<cells.Count;i++)
            {
                Cell c = cells[i];
                if(c.Members.Exists(x=>x.Id == prisonerId))
                {
                    c.Members.RemoveAll(x => x.Id == prisonerId);
                    return;
                }
            }
            throw new ArgumentException("Searched prisoner " + prisonerId + " not found!");
            
        }
        
        
        
        public Cells (int capacity, List<Prisoner> ps)
        {
            cells = new List<Cell>();
            for(int i = 0; i< capacity; i++)
            {
                cells.Add(new Cell() { Id = i });
            }
            foreach(Prisoner p in ps)
            {
                cells[p.Cell].Add(p);
                /*
                if(cells.Exists(x=>x.Id == p.Cell))
                {
                    cells[cells.FindIndex(x => x.Id == p.Cell)].Members.Add(p);
                }
                else
                {
                    Cell newCell = new Cell() { Id = p.Cell, Capacity = 5 };
                    newCell.Add(p);
                    cells.Add(newCell);
                }

                */
            }
        }   




        public Cell getAvailableCell()
        {
            foreach (Cell c in cells)
            {
                if (!c.IsFull)
                {
                    return c;
                }
            }

            if (cells.Count == cells.Capacity)
            {
                throw new Exception("Prison is full!");
            }

            Cell newCell = new Cell(){ Id = cells.Count + 1 };
            cells.Add(newCell);
            return newCell;

            
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            return cells.GetEnumerator();
        }


    }
}
