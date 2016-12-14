namespace ReleaseBulkUpdate
{
    internal class ReleaseDefinition
    {
        public string Name { get;  set; }

        public string Url { get;  set; }

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