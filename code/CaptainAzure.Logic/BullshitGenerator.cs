using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection; 

namespace CaptainAzure.Logic
{
    public class BullshitGenerator
    {

        static List<string> Adjectives = new List<string>(); 
        static List<string> Verbs = new List<string>(); 
        static List<string> Nouns = new List<string>();

        static int maxAdjectives;
        static int maxVerbs;
        static int maxNouns; 

        static BullshitGenerator()
        {

            // lock later. 
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "CaptainAzure.Logic.res.Adjective.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                while (! reader.EndOfStream )
                {
                    Adjectives.Add(reader.ReadLine()); 
                }
            }

            maxAdjectives = Adjectives.Count() - 1; 

            resourceName = "CaptainAzure.Logic.res.Noun.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    Nouns.Add(reader.ReadLine());
                }
            }

            maxNouns = Nouns.Count() - 1; 

            resourceName = "CaptainAzure.Logic.res.Verb.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    Verbs.Add(reader.ReadLine());
                }
            }

            maxVerbs = Verbs.Count() - 1; 


        }


        public string Generate()
        {
            // 3 random numbers 
            var buffer = new StringBuilder();


            var rnd = new Random();

            // adjective verb noun 

            buffer.Append(Adjectives[Convert.ToInt32(rnd.NextDouble() * maxAdjectives)]);
            buffer.Append(" ");
            buffer.Append(Verbs[Convert.ToInt32(rnd.NextDouble() * maxVerbs)]);
            buffer.Append(" ");
            buffer.Append(Nouns[Convert.ToInt32(rnd.NextDouble() * maxNouns)]);


            return buffer.ToString(); 

        }


    }
}
