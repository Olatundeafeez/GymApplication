namespace GymManagementApp.Domain.Model
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public List<Member> Members { get; set; }

    }
}
