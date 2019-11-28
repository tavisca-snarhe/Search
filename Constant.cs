namespace Tavisca.Applause
{
    public static class Constant
    {
        public static class BadgeType
        {
            public static readonly string Gold = "gold";
            public static readonly string Silver = "silver";
            public static readonly string Bronze = "bronze";
        }
        public static class AwardType
        {
            public static readonly string Annual = "annual";
            public static readonly string Monthly = "monthly";
        }

        public static class AwardName
        {
            public static readonly string Kudos = "kudos";
            public static readonly string Shoutout = "shoutout";
        }

       public static class Timesheet
       {
            public static class MonthlySubmissionStatus
            {
                public const string Open = "open";
                public const string Rejected = "rejected";
                public const string WaitingForApproval = "waitingforapproval";
                public const string Submitted = "submitted";
            }
       }

       public static class Platforms
       {
            public static readonly string GitHub = "github";
            public static readonly string EnterpriseJira = "enterprise_jira";
       }

       public static class PlatformHandles
       {
            public static readonly string GitHubHandle = "github_handle";
            public static readonly string JiraUserName = "enterprise_jira_username";
       }

       public static class PlatformActivities
       {
           public static class Github
           {
               public const string PullRequestApprove = "pull_request_approve";
           }
       }

        public static class EmployeeActivities
        {
            public static class GitHub
            {
                public const string PullRequestReview = "github_pull_request_review";
            }
        }

        public static class Pagination
        {
            public const double Timeout = 15;
        }

        public static string AppName = "Applause";
        public static string HolidaySheetTabName = "2020 Holiday List";
    }
}