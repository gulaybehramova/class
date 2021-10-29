using System;
using System.Collections.Generic;
using System.Text;

namespace class_project
{
    class Vehicle   /*base class*/
    {
        public string Name;
        public string Color;
    }
    class Car: Vehicle      /*derived class*/
    {
        public string Brand;
        public string Model;
    }
}
