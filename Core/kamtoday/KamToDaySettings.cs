
namespace Parser.Core.Habra
{
    class KamToDaySettings : IParserSettings
    {
        public KamToDaySettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public string BaseUrl { get; set; } = "https://kamtoday.ru/news/ecologics/";

        public string Prefix { get; set; } = "?PAGEN_1={CurrentId}";

        public int StartPoint { get; set; }

        public int EndPoint { get; set; }
    }
}
