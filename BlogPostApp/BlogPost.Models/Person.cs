using System;
using System.Collections.Generic;
using System.Text;

namespace BlogPost.Models
{
    public class Person
    {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }

        public Person()
        {
            //do init stuff
        }
        public Person(int id, string firstName, string lastName, string email) : this()
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;            
        }

        public virtual string GetInfo()
        {
            //return this.Id + " " + this.FirstName + " " + this.LastName + " " + this.Email;
            //return string.Format("{0} {1} {2} {3}", this.Id, this.FirstName, this.LastName, this.Email);
            return $"Id: {this.Id} FirstName: {this.FirstName} LastName: {this.LastName} Email: {this.Email}";
        }
    }
}
