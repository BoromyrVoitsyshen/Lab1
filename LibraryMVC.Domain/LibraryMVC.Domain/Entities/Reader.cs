namespace Domain.Entities
{
    public class Reader : Entity
    {
        public string name { get; set; }
        public string contactInfo { get; set; }

        public Reader() 
        {
            ID = 0;
            name = "";
            contactInfo = "";
        }
    }
}
