namespace Domain.Entities
{
    public class Genre : Entity
    {
        public string name { get; set; }
        public Genre() 
        {
            ID = 0;
            name = "";
        }
    }
}
