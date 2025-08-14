using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task
{
    class Animal
    {
        //        1. Animal(Base Class)
        //Should store basic information common to all animals(name, age).
        //Must provide a way for derived classes to define their own way of making sounds.
        //Must have a method to display animal details, but allow child classes to change how it works.
        //Must allow feeding animals through a common action.  [feeding]

        public string Name { get; set; }

    }
}
