using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Kursach1.Model
{
    static class Prisoners
    {

        public static string PrisonersListLocation = "prisoners.json";

        public static Random randGen = new Random();

        public static List<Prisoner> prisoners = new List<Prisoner>();

        public static void Create()
        {
            int length = 10;
            prisoners = new List<Prisoner>();
            for (int i = 0; i < length; i++)
            {
                Prisoner p = new Prisoner()
                {
                    Id = i,
                    Name = "Name" + i,
                    Article = i,
                    Cell = i
                };     
                prisoners.Add(p);
            }
        }


        


        public static void Save()
        {
            if (!File.Exists(PrisonersListLocation))
            {
                File.Create(PrisonersListLocation);
            }
            using (TextWriter writer = new StreamWriter(File.Create(PrisonersListLocation)))
            {
                writer.WriteLine(JsonConvert.SerializeObject(prisoners));
            }
        }

        public static void Load()
        {
            if (File.Exists(PrisonersListLocation))
            {
                using (TextReader reader = new StreamReader(File.OpenRead(PrisonersListLocation)))
                {
                    prisoners = JsonConvert.DeserializeObject<List<Prisoner>>(reader.ReadLine());
                }
            }
            
        }




        private static int generateId()
        {
            int r = randGen.Next(1, 10000);
            if (prisoners.Exists(x => x.Id == r))
            {
                return generateId();
            }
            else return r;
        }

        public static void Add(
                string name,
                string age,
                string article,
                string cell
            )
        {
            Regex ageRegex = new Regex(@"[1-9][0-9]");
            Regex numRegex = new Regex(@"[\d]");

            if (!ageRegex.IsMatch(age))
            {
                throw new ArgumentException("Incorrect age");
            }

            if(name == "")
            {
                throw new ArgumentException("Empty name");
            }
            if(article == "")
            {
                throw new ArgumentException("Empty article");
            }
            if (cell == "")
            {
                throw new ArgumentException("Empty cell");
            }
            if (!numRegex.IsMatch(article))
            {
                throw new ArgumentException("Incorrect article number");
            }
            if (!numRegex.IsMatch(cell))
            {
                throw new ArgumentException("Incorrect cell number");
            }

            prisoners.Add(new Prisoner()
            {
                Id = generateId(),
                Name = name,
                Age = int.Parse(age),
                Article = int.Parse(article),
                Cell = int.Parse(cell)
            });
        }


        public static void Remove(string id)
        {
            try
            {
                prisoners.RemoveAll(x => x.Id == int.Parse(id));
            }
            catch
            {
                throw new ArgumentException();
            }
            
        }


        public static string FormStatistics()
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
            sb.AppendLine("Oldest Prisoner: " + prisoners
                    .OrderByDescending(x => x.Age).First().Name);

            sb.AppendLine("Youngest Prisoner: " + prisoners
                    .OrderBy(x => x.Age).First().Name);


            return sb.ToString();
        }
    }
}
