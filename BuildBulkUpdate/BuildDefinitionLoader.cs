using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BuildBulkUpdate
{
    class BuildDefinitionLoader
    {
        private const string ListUrl = "https://tfs.sandvik.com:444/tfs/DefaultCollection/59df98ff-f2ea-48e3-bc7b-95c5990df4e5/_apis/build/definitions";

        public ICollection<BuildDefinition> LoadDefinitions()
        {
            var definitions = JObject.Parse(HttpHelper.Get(ListUrl));

            return definitions["value"]
                .Select(x => new BuildDefinition
                {
                    Name = x.Value<string>("name"),
                    Url = x.Value<string>("url"),
                })
                .ToArray();
        }
    }
}
