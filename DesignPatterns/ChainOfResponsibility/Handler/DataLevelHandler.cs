namespace ChainOfResponsibility
{
    public class DataLevelHandler
    {                
        public ParserHandler SetAndGetDataLevel()
        {
            ParserHandler p1 = new SingleLevelParser();
            ParserHandler p2 = new TwoLevelParser();
            ParserHandler p3 = new ThreeLevelParser();
            p1.SetAdvancedParser(p2);
            p2.SetAdvancedParser(p3);
            return p1;
        }
    }
}
