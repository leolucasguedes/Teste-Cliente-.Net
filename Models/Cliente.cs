namespace WebApi.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Client()
        {
            Name = string.Empty;
        }
    }
}

