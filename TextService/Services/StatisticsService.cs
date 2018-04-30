// **********************************************************************
// * 
// * Copyright (c) BinckBank N.V.
// *
// **********************************************************************

namespace TextService.Services
{
    using System.Text.RegularExpressions;

    using TextService.Interfaces;

    public class StatisticsService : IStatisticsService
    {
        public int CountWords(string text)
        {
            Regex wordRegex = new Regex(@"[\w]+", RegexOptions.Multiline);
            return wordRegex.Matches(text).Count;
        }
        
        public int NumberOfHyphens(string text)
        {
            return text.Where(x => x == '-').Count();
        }

        public int NumberOfSpaces(string text)
        {
            return text.Where(x => x == ' ').Count();
        }
    }
}
