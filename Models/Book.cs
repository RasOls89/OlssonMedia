namespace Models
{
    public class Book
    {
        public int GameId { get; set; }
        public string FNAuthor { get; set; }
        public string ENAuthor { get; set; }
        public string FullNAuthor { get; set; }
        public string Titel { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }
        public DateTime BookAdded { get; set; }
        public string AddedBy { get; set; }
        public DateTime BookUpdated { get; set; }
        public string UpdatedBy { get; set; }
    }
}