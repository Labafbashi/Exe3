using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PRG03
{
    public class PersonHandler : Person
    {
        public void SetAge(Person pers, int a) => pers.Age = a;
        public void SetFName (Person pers, string fn) => pers.Fname = fn;
        public void SetLName(Person pers, string ln) => pers.Lname = ln;
        public void SetWeight(Person pers, double w) => pers.Weight = w;
        public void SetHeight(Person pers, double h) => pers.Height = h;

        public void ChangeFLName(Person pers, string fn, string ln)
        {
            pers.Fname = fn;
            pers.Lname = ln;
        }

        public void ChangeHW(Person pers, double h, double w)
        {
            pers.Height = h;
            pers.Weight = w;
        }

        public Person CreatePerson(string fname, string lname, int age, double height, double weight)
        {
            Person person = new Person(fname,lname,age,height,weight);
            return person;
        }

        
    }
}
