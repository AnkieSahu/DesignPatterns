using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class Client
    {
        static void Main(string[] args)
        {
            DataLevelHandler level = new DataLevelHandler();
            var parser = level.SetAndGetDataLevel();
            var req = new List<Request>() { new Request{ JsonData = "sampledata", Level = 1 }, new Request { JsonData = "sampledata", Level = 2 },
            new Request{ JsonData = "sampledata", Level = 3 },new Request{ JsonData = "sampledata", Level = 4 }};            
            foreach (var item in req)
            {
                parser.ParseRequest(item);
            }
            System.Console.ReadLine();
        }
    }
}
