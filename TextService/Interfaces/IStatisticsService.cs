// **********************************************************************
// * 
// * Copyright (c) BinckBank N.V.
// *
// **********************************************************************

namespace TextService.Interfaces
{
    public interface IStatisticsService
    {
        int CountWords(string text);

        int NumberOfHyphens(string text);

        int NumberOfSpaces(string text);
    }
}
