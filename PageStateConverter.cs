using System;

namespace Tavisca.Applause
{
    public static class PageStateConverter
    {
        public static string ConvertPagingStateToString(byte[] pagingState)
        {
            if (pagingState == null) { return null; }
            return Convert.ToBase64String(pagingState);
        }

        public static byte[] ConvertStringToPagingState(string pagingStateString)
        {
            if (pagingStateString == null) { return null; }
            return Convert.FromBase64String(pagingStateString);
        }
    }
}