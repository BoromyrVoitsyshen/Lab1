namespace Domain.Entities
{
    public class Book : Entity
    {
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public string genre { get; set; }
        public int publishingYear { get; set; }

        public Book() 
        {
            ID = 0;
            title = "";
            author = "";
            publisher = "";
            genre = "";
            publishingYear = 0;
        }
    }
}
