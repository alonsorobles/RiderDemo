using System.Collections.Generic;

namespace RiderDemo.Services
{
    public class DataFetchService : IDataFetchService
    {
        public IList<string> GetData(string text)
        {
            return new List<string> {$"{text} 1", $"{text} 2", $"{text} 3"};
        }
    }
}