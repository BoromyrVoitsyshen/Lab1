namespace Domain.Entities
{
    public class Author : Entity
    {
        public string name { get; set; }
        public string biography { get; set; }
        public Author() 
        {
            ID = 0;
            name = "";
            biography = "";
        }
    }
}
