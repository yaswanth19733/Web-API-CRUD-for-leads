namespace Task.Models
{
    public class Lead
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Category { get; set; }
        public string Course { get; set; }
        public DateTime EnquiryDate { get; set; }
        public string Status { get; set; }
    }
}
