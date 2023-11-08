namespace Models
{
    public class Book : IStatus
    {
        public int GameId { get; set; }
        public string FNAuthor { get; set; }
        public string ENAuthor { get; set; }
        public string FullNAuthor { get; set; }
        public string Titel { get; set; }
        public string Genre { get; set; }
        public string Category { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }
        public bool StillOwn { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }
        public string ReasonForUpdating { get; set; }
        DateTime? IStatus.Updated { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}