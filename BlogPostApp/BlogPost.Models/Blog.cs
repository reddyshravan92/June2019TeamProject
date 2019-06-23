using System;
namespace BlogPost.Models
{
    public class Blog
    {
        public static string Category { get; set; }
        public BlogType BlogType { get; set; }
        public Blog()
        {
            this.Id = 1010;
            this._name = "Angular";
            this._email = "Satya@gmail.com";
            this.CreatedBy = "SAtya";
            this.CreatedDate = DateTime.Now;
            this.BlogType = BlogType.Public;
        }

        static Blog()
        {
            Category = "Web";
        }

        public Blog(int id, string name, string email) : this()
        {
            if(id> 0)
            {
                this.Id = id;
            }

            if (!string.IsNullOrEmpty(name))
            {
                this._name = name;
            }

            this._email = email;
        }

        private string _name;

        public int Id { get; set; }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if(value == "Angular" || value=="CSharp" ||value == "Api")
                {
                    this._name = value;
                }
                else if (value.Length == 5)
                {
                    this._name = "5 char name";
                }
                else
                {
                    throw new Exception($"Given {value} is not valid");
                }
            }
        }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        private string _email;
        public string Email
        {
            set
            {
                this._email = value;
            }
        }

        public string BlogDetails
        {
            get
            {
                return $"{this.Id} {this.Name} {this.CreatedBy} {this.CreatedDate.ToShortDateString()}";
            }
        }
    }
}
