namespace Domain.Entities
{
    public class Publisher : Entity
    {
        public string name { get; set; }
        public string contactInfo { get; set; }
        public Publisher() 
        {
            ID = 0;
            name = "";
            contactInfo = "";
        }
    }
}
