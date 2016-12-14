using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildBulkUpdate
{
    class BuildDefinition
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public string Data { get; set; }

        public void Load()
        {
            Data = HttpHelper.Get(Url);
        }

        public void Update()
        {
            HttpHelper.Put(Url, Data);
        }
    }
}
