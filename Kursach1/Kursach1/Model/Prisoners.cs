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

        

        IEnumerator IEnumerable.GetEnumerator()
        {
            return prisoners.GetEnumerator();
        }



        public void Create()
        {
            int length = 10;
            for (int i = 0; i < length; i++)
            {                
                prisoners.Add(new Prisoner(generateId(), randGen));
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
            try
            {
                prisoners.RemoveAll(x => x.Id == id);
            }
            catch
            {
                throw new ArgumentException();
            }
            
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
                  
            /*
            switch (field)
            {
                case "":
                    selectedPrisoners = prisoners;
                    break;
                case "0":
                    selectedPrisoners = prisoners.Where(p=>p.Id.ToString() == pattern ).ToList();
                    break;
                case "1":
                    selectedPrisoners = prisoners.Where(p => p.FirstName.ToString().Contains(pattern)).ToList();
                    break;
                case "2":
                    selectedPrisoners = prisoners.Where(p => p.Age.ToString().Contains(pattern)).ToList();
                    break;
                case "3":
                    selectedPrisoners = prisoners.Where(p => p.Article.ToString().Contains(pattern)).ToList();
                    break;
                case "4":
                    selectedPrisoners = prisoners.Where(p => p.Cell.ToString().Contains(pattern)).ToList();
                    break;
                case "5":
                    return selectedPrisoners.Where(p => p.SentenceDaysLeft.ToString().Contains(pattern)).ToList();
                case "6":
                    return selectedPrisoners.Where(p => p.Hierarchy.Contains(pattern)).ToList();
                default:
                    throw new ArgumentException("incorrect searchby field");
            }
            */
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


    }
        


}
