namespace mustacheJsExample.Models
{
    public class Contact
    {
        public Contact()
        {
            // initialize the Aliases so it will never be null
            Aliases = new List<String>();
        }

        public Guid Id { get; set; }
        public String Name { get; set; }
        public List<String> Aliases { get; set; }
        public ContactAddress Address { get; set; }
        public String PhoneNumber { get; set; }

    }
}
