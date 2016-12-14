using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseBulkUpdate
{
    class ReleaseDefinitionsLoader
    {
        private const string ListUrl = "https://tfs.sandvik.com:444/tfs/DefaultCollection/59df98ff-f2ea-48e3-bc7b-95c5990df4e5/_apis/release/definitions";

        public ICollection<ReleaseDefinition> LoadDefinitions()
        {
            var definitions = JObject.Parse(HttpHelper.Get(ListUrl));

            return definitions["value"]
                .Select(x => new ReleaseDefinition
                {
                    Name = x.Value<string>("name"),
                    Url = ListUrl + "/" + x.Value<string>("id"),
                })
                .ToArray();
        }
    }
}
