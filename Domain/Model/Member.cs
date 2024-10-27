namespace GymManagementApp.Domain.Model
{
    public class Member
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string SubscriptionStart { get; set; }
        public string SubscriptionEnd { get; set; }
        public decimal TotalPaid { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
