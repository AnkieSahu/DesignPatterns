namespace ChainOfResponsibility
{
    public class ThreeLevelParser : ParserHandler
    {
        public override void ParseRequest(Request req)
        {
            if(req.Level == 3)
            {
                System.Console.WriteLine("Parsing the json data of 3 Level.");
            }
            else if(_advancedParser != null)
            {
                _advancedParser.ParseRequest(req);
            }
            else
                System.Console.WriteLine("Data could not be parsed because we have only 3 level of data handling algos.");
        }
    }
}
