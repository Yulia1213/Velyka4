using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Jornal
{
    [Serializable]

    public class Book
    {
        public List<Person> AllPeople { get; set; }

        public Book()
        {
            AllPeople = new List<Person>();
        }

        public void AddClient(Person person)
        {
            AllPeople.Add(person);
        }


    }
}
