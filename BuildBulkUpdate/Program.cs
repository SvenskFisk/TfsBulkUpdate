using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BuildBulkUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            ////var definitions = new BuildDefinitionLoader().LoadDefinitions();
            ////var buildTest = definitions.First(x => x.Name == "Int 001 Build Test x");
            ////buildTest.Load();

            ////var d = JObject.Parse(buildTest.Data);
            ////d["name"] = "Int 001 Build Test";
            ////buildTest.Data = d.ToString();

            ////buildTest.Update();

#if DEBUG
            Console.ReadLine();
#endif
        }
    }
}
