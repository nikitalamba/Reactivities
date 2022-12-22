namespace Domain
{
    public class Attendence
    {
        public Guid Id { get; set; }
        public DateOnly StatDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int RequestType { get; set; }
        public string Reason { get; set; }
    }
}