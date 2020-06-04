using System.Collections.Generic;

namespace Lesson_24_GenericsAndCollections
{
    public class Student{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName =>$"{FirstName} {LastName}";
        public string EmailAddress { get; set; }
        public List<string> PhoneNumbers{get;set;}
    }
}
