using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.CS7
{
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            // compare name lengths

            int temp = x.Name.Length.CompareTo(y.Name.Length);
            //if they are eqaul

            if (temp == 0)
            {
                //then sort by names
                return x.Name.CompareTo(y.Name);
            }
            else
            {
                // sort by length
                return temp;
            }
        }
    }
}
