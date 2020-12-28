using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2PP
{
    public class Person
    {
        protected string name;
        protected string surname;
        protected DateTime birthdate;


        public int GetAge()
        {
            return (int)((DateTime.Now - birthdate).TotalDays / 365);
        }
    }
}
