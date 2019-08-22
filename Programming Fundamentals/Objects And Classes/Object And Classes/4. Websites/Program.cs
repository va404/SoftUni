using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Websites
{
    class Websites
    {
        public string WebName { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }

        public Websites(string webName, string domain, List<string> queries)
        {
            this.WebName = webName;
            this.Domain = domain;
            this.Queries = queries;
        }
    }
    class NoQueryWebs
    {
        public string NoQueryWebName { get; set; }
        public string NoQueryDomain { get; set; }

        public NoQueryWebs(string noQueryWebName, string noQueryDomain)
        {

            this.NoQueryWebName = noQueryWebName;
            this.NoQueryDomain = noQueryDomain;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Websites> websites = new List<Websites>();
            List<NoQueryWebs> noQueryWebs = new List<NoQueryWebs>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length > 2)
                {
                    string webName = tokens[0];
                    string domain = tokens[1];
                    List<string> queries = tokens[2].Split(',').ToList();

                    websites.Add(new Websites(webName, domain, queries));
                }
                else
                {
                    string noQueryWebName = tokens[0];
                    string noQueryDomain = tokens[1];

                    noQueryWebs.Add(new NoQueryWebs(noQueryWebName, noQueryDomain));
                }
                input = Console.ReadLine();
            }

            foreach (var site in websites)
            {
                Console.Write($"https://www.{site.WebName}.{site.Domain}/query?=[{string.Join("]&[",site.Queries)}]");
            
                Console.WriteLine();
            }
            foreach (var item in noQueryWebs)
            {
                Console.Write($"https://");
                Console.Write($"www.{item.NoQueryWebName}.{item.NoQueryDomain}");
                Console.WriteLine();
            }
        }
    }
}
