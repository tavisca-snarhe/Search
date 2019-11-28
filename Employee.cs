namespace Tavisca.Applause
{
    public class Employee
    {
       
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tribe { get; set; }
        public string Squad { get; set; }
        public string ProfilePictureUrl { get; set; }
        public bool IEnabled { get; set; }
        public string Email { get; set; }
        public EmployeeRewardsStats RewardStats { get; set; }
    }
}
