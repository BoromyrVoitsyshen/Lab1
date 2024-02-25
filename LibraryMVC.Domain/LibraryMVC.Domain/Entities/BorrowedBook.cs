namespace Domain.Entities
{
    public class BorrowedBook : Entity
    {
        public int bookID { get; set; }
        public int readerID { get; set; }
        public int borrowStart { get; set; }
        public int borrowTime { get; set; }
        public BorrowedBook()
        {
            ID = 0;
            bookID = 0;
            readerID = 0;
            borrowStart = 0;
            borrowTime = 0;
        }
    }
}
