using System;

namespace Tavisca.Applause
{
    public class GithubStatistics
    {
        public DateTime Date { get; set; }
        public int NumberOfPRs { get; set; }
        public int NumberOfPRsWithOutComments { get; set; }
        public int NumberOfPRsWithComments { get; set; }
    }
}
