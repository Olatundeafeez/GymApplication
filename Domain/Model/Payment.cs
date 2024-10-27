namespace GymManagementApp.Domain.Model
{
    public class Payment
    {
        public int Id { get; set; }
        public int SuperAdminId { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Percentage { get; set; }





    }
}
