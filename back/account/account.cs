namespace AccountModel
{
    public class Account
    {
        public long   Id       { get; set; }
        public string Username { get; set; } = "";
        public int    Level    { get; set; } = 1;
        public int    Strick   { get; set; }
    }
}
