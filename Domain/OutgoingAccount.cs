namespace Domain
{
    public class OutgoingAccount
    {
        public int Id { get; set; }
        public Outgoing Outgoing { get; set; }
        public Account Account { get; set; }
    }
}