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

        public static List<Prisoner> selectedPrisoners;

        public static List<Prisoner> prisoners = new List<Prisoner>();

        

        


        public static void Create()
        {
            int length = 10;
            for (int i = 0; i < length; i++)
            {                
                prisoners.Add(new Prisoner(generateId(), randGen));
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
            selectedPrisoners = prisoners;
            
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

        public static void Add(Prisoner p)
        {
            p.Id = generateId();
            prisoners.Add(p);
        }





        public static void Replace(int id, Prisoner newP)
        {
            int index = prisoners.FindIndex(p => p.Id == id);
            newP.Id = prisoners[index].Id;
            prisoners[index] = newP;
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



        public static List<Prisoner> SearchBy(string field, string pattern)
        {
            switch (field)
            {
                case "":
                    selectedPrisoners = prisoners;
                    break;
                case "0":
                    selectedPrisoners = prisoners.Where(p=>p.Id.ToString().Contains(pattern)).ToList();
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
            return selectedPrisoners;
        }


        public static List<Prisoner> OrderBy(string field)
        {
            if(selectedPrisoners == null)
            {
                selectedPrisoners = prisoners;
            }
            switch (field)
            {
                case "":
                    return selectedPrisoners;
                case "0":
                    return selectedPrisoners.OrderByDescending(p => p.Id).ToList();
                case "1":
                    return selectedPrisoners.OrderByDescending(p => p.SecondName).ToList();
                case "2":
                    return selectedPrisoners.OrderByDescending(p => p.Age).ToList();
                case "3":
                    return selectedPrisoners.OrderByDescending(p => p.Article).ToList();
                case "4":
                    return selectedPrisoners.OrderByDescending(p => p.Cell).ToList();
                case "5":
                    return selectedPrisoners.OrderByDescending(p => p.SentenceDaysLeft).ToList();
                case "6":
                    return selectedPrisoners.OrderByDescending(p => p.Hierarchy).ToList();
                default:
                    throw new ArgumentException("incorrect orderby field");
            }
        }
    }
}
