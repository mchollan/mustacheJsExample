﻿namespace mustacheJsExample.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public ContactAddress Address { get; set; }
        public String PhoneNumber { get; set; }

    }
}
