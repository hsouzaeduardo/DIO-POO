using System;
using System.Collections.Generic;

namespace DIO.Avacloud.Entidades
{
    public class Customer : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Int64 Document { get; set; }
        public List<Address> Address { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string FullName
        {
            get
            {
                string fullName = FirstName;
                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    fullName += $" {LastName}";
                }
                return fullName;
            }
        }
        public override string ToString() =>  $"Nome Completo:{FullName} E-mail: {Email} Data de Nascimento: {BirthDate}";
        public override bool Validate()
        {
            return !string.IsNullOrWhiteSpace(FirstName);
        }
    }
}
