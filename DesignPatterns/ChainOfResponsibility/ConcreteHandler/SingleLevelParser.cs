namespace ChainOfResponsibility
{
    public class SingleLevelParser : ParserHandler
    {
        public override void ParseRequest(Request req)
        {
            if(req.Level == 1)
            {
                System.Console.WriteLine("Parsing the json data of 1 Level.");
            }
            else if(_advancedParser != null)
            {
                _advancedParser.ParseRequest(req);
            }
        }
    }
}
