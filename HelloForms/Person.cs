using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloForms
{
    enum Gender 
    {
     Male,
     Female,
     Alien,
     Unknown
    
    }
    class Person
    {
        public string Name { get; set; }
        public  string Movie { get; set; }
        public  string Color { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public Person()
        {
            Gender = Gender.Unknown;
        }

        public bool IsValid
        {
            get { return !String.IsNullOrEmpty(Name)  //Make it true if all of these are true
                         && !String.IsNullOrEmpty(Movie) 
                         && !String.IsNullOrEmpty(Color)
                         && Age > 0; }

        }
        public bool IsValid2
        {
            get
            {
                return !String.IsNullOrEmpty(Name)  //Make it true if all of these are true
                       && Gender != Gender.Unknown;
                       
            }

        }



    }
}
