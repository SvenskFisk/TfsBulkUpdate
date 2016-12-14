using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseBulkUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            ////var definitions = new ReleaseDefinitionsLoader().LoadDefinitions();

            ////foreach (var definition in definitions)
            ////{
            ////    Console.WriteLine("Update " + definition.Name);
            ////    definition.Load();

            ////    var d = JObject.Parse(definition.Data);
            ////    File.WriteAllText($"C:\\temp\\ReleaseDefinitionBackup\\{d.Value<string>("id")}.json", definition.Data);

            ////    foreach (var env in d["environments"])
            ////    {
            ////        // update deployment user
            ////        var deployPassword = env["variables"]["deployPassword"];
            ////        var deployUser = env["variables"]["deployUser"];
            ////        if (deployPassword != null && deployUser != null)
            ////        {
            ////            deployPassword["value"] = "f4totGPJyLskbs_";
            ////            deployUser["value"] = "sandvik\\biztalkreleaseuser";
            ////        }

            ////        // update scriptpaths in all tasks to n:
            ////        var paths = env["deployStep"]["tasks"]
            ////            .SelectMany(x => new[] { x["inputs"]["ScriptPath"], x["inputs"]["ScriptArguments"] })
            ////            .Where(x => x != null);

            ////        foreach (var token in paths)
            ////        {
            ////            var old = token.Value<string>();
            ////            token.Replace(old.Replace("c:\\", "n:\\").Replace("C:\\", "n:\\"));
            ////        }
            ////    }

            ////    // save changes
            ////    definition.Data = d.ToString();
            ////    definition.Update();
            ////}

#if DEBUG
            Console.ReadLine();
#endif
        }
    }
}
