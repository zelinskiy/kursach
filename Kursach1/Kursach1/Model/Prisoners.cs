using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Collections;

namespace Kursach1.Model
{
    public class Prisoners:IEnumerable
    {

        public string PrisonersListLocation = "prisoners.json";

        public Random randGen = new Random();

        public List<Prisoner> selectedPrisoners;

        public List<Prisoner> prisoners = new List<Prisoner>();


        public Cells cells;
        
        

        

        IEnumerator IEnumerable.GetEnumerator()
        {
            return prisoners.GetEnumerator();
        }



        public void Create()
        {
            int length = 10;
            for (int i = 0; i < length; i++)
            {                
                Add(new Prisoner(generateId(), randGen));
            }
        }


        


        public void Save()
        {
            using (TextWriter writer = new StreamWriter(File.Create(PrisonersListLocation)))
            {
                writer.WriteLine(JsonConvert.SerializeObject(prisoners));
            }
        }

        public void Load()
        {
            if (File.Exists(PrisonersListLocation))
            {
                using (TextReader reader = new StreamReader(File.OpenRead(PrisonersListLocation)))
                {
                    prisoners = JsonConvert.DeserializeObject<List<Prisoner>>(reader.ReadLine());                    
                }
            }
            selectedPrisoners = prisoners;
            cells = new Cells(100, prisoners);
        }




        private int generateId()
        {
            int r = randGen.Next(1, 10000);
            if (prisoners.Exists(x => x.Id == r))
            {
                return generateId();
            }
            else return r;
        }


        


        public void Add(Prisoner p)
        {
            p.Id = generateId();
            if(p.Cell < 0 || p.Cell > cells.cells.Count)
            {
                throw new ArgumentException("This cell is full");
            }
            if(p.Cell == -1)
            {
                cells.Insert(p);                
            }
            else
            {
                cells.Insert(p, p.Cell);
            }
            
            prisoners.Add(p);
        }





        public void Replace(int id, Prisoner newP)
        {
            int index = prisoners.FindIndex(p => p.Id == id);
            newP.Id = prisoners[index].Id;
            prisoners[index] = newP;
        }







        public void Remove(int id)
        {
            cells.RemovePrisoner(id);
            prisoners.RemoveAll(x => x.Id == id);            
        }


        public string FormStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Prisoners: " + prisoners.Count);
            sb.AppendLine("5 Most popular articles: " +
                    prisoners
                        .OrderByDescending(x=>prisoners
                        .FindAll(p=>p.Article == x.Article)
                        .Count)
                        .GroupBy(x=>x.Article)
                        .Select(g => g.First())
                        .Take(5)
                        .Select(x=>x.Article.ToString())
                        .Aggregate((i,j)=> i + " " + j)
                );
            sb.AppendLine("Самый молодой заключенный: " + prisoners
                    .OrderByDescending(x => x.Age).First().Id);

            sb.AppendLine("Самый старый заключенный: " + prisoners
                    .OrderBy(x => x.Age).First().Id);

            sb.AppendLine("Будут отпущены в этом месяце:");
            foreach(Prisoner p in prisoners.Where(p=>p.SentenceDaysLeft < 30 && p.SentenceDaysLeft >=0).OrderBy(p=>p.SentenceDaysLeft))
            {
                sb.AppendLine(p.FirstName + " " + p.SecondName + " " + p.WillBeFreeDate.ToString("yy/mm/dd"));
            }


            return sb.ToString();
        }



        public List<Prisoner> SearchBy(Func<Prisoner, string> f, string pattern, bool strict)
        {
            if (strict)
            {
                selectedPrisoners = prisoners.Where(x => f(x).ToLower() == pattern.ToLower()).ToList();
            }
            else
            {
                selectedPrisoners = prisoners.Where(x => f(x).ToLower().Contains(pattern.ToLower())).ToList();
            }

            return selectedPrisoners;
        }


        public List<Prisoner> OrderBy(Func<Prisoner, string> f, bool ascending)
        {
            if (ascending)
            {
                selectedPrisoners = prisoners.OrderBy(x => TryParse(f(x))).ToList();
            }
            else
            {
                selectedPrisoners = prisoners.OrderByDescending(x => TryParse(f(x))).ToList();
            }
            
            return selectedPrisoners;
        }
        
        public dynamic TryParse(string s)
        {
            int res;

            if(int.TryParse(s,out res))
            {
                return res;
            }
            else
            {
                return s;
            }            
            
        }





        public void Clear()
        {
            while (prisoners.Count != 0)
            {
                Remove(prisoners[0].Id);
            }
            selectedPrisoners = prisoners;
        }






        public void Convoy(int prisonerId, string cellId)
        {
            int cid = int.Parse(cellId);
            Prisoner p = prisoners[prisoners.FindIndex(x => x.Id == prisonerId)];
            p.Cell = cells.Insert(p, cid).Id;
            cells.RemovePrisoner(prisonerId);
        }


    }
        


}
