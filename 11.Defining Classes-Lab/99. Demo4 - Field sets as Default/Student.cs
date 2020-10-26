using System;
using System.Collections.Generic;
using System.Text;

namespace _99._Demo4___Field_sets_as_Default
{
    internal class Student
    {
        private string name = "Gosho";
        public string Name 
        {
            get 
            {
                //if (Name.Length>5) // примера не е работещ
                //{
                    return name;
                //}
                //else
                //{
                //    return "NoName";
                //}
            }
            set
            {
                name = value;
            }
        }
    }
}
