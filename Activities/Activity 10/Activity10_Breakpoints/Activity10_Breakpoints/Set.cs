using System;
using System.Collections.Generic;

namespace Application
{
    //Copied, Pasted, and Corrected By Nathaniel Kumar

    public class Set
    {
        private List<int> elements;

        public Set()
        {
            elements = new List<int>();
        }
        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
     
                // Do not need the "return false" here in the if statement.
                //
                // The method is checking if the val is the same within the list.
                // Having a "return false" here stops the for loop from advancing to check the other elements in the set.
                //
                // Now the loop now will continue until reaching the end of the list.
                //
                // If the element does not match, the program will leave the if statement and run through the loop again,
                // checking every element until a match, but if all do not match, the program will return false,
                //
                //
                // If the element does match, the program will return true - leaving the for loop.
                if (val == elements[i])
                    return true;
                /*else
                    return false;*/
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        //modifying method to take in both sets to create one unified set
        //A new set called "unionSet" will add Set A as a starting point through addElement method,
        //then add Set B through addElement method.
        //Then return unionSet - which is the new set that is unifed
        //
        //Now set A will not be modified, and not returning "rhs" - which was only set B

        /*public Set union(Set rhs)
        {
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                this.addElement(rhs.elements[i]);
            }
            return rhs;
        }*/
        public Set union (Set setA, Set setB)
        {
            Set unionSet = new Set();
            for (int i = 0; i < setA.elements.Count; i++)
            {
                unionSet.addElement(setA.elements[i]);
            }

            for (int i = 0; i < setB.elements.Count; i++)
            {
                unionSet.addElement(setB.elements[i]);
            }
            return unionSet;
        }

    }
}
