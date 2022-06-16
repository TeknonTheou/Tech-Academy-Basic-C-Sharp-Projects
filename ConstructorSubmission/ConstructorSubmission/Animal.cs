using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    class Animal
    {
        public Animal(string name) : this(name, 4) { }//set Animal class default with 4 legs

        public Animal(string name, int numLegs)//set Animal to allow user to input name and number of legs
        {
            Name = name;
            NumLegs = numLegs;
        }

        public string Name { get; set; }
        public int NumLegs { get; set; }
    }
}
