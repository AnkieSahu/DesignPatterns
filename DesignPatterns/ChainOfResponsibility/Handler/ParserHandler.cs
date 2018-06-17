namespace ChainOfResponsibility
{
    public abstract class ParserHandler
    {
        protected ParserHandler _advancedParser;
        public void SetAdvancedParser(ParserHandler parser)
        {
            this._advancedParser = parser;
        }
        public abstract void ParseRequest(Request req);    
    }
}
