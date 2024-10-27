namespace GymManagementApp.Domain.Model
{
    public class SuperAdmin
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string ConfirmPassword { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
