using System.Collections.Generic;

namespace RiderDemo.Services
{
    public interface IDataFetchService
    {
        IList<string> GetData(string text);
    }
}