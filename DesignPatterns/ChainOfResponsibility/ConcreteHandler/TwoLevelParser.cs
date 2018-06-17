namespace ChainOfResponsibility
{
    public class TwoLevelParser : ParserHandler
    {
        public override void ParseRequest(Request req)
        {
            if(req.Level == 2)
            {
                System.Console.WriteLine("Parsing the json data of 2 Level.");
            }
            else if(_advancedParser != null)
            {
                _advancedParser.ParseRequest(req);
            }
        }
    }
}
