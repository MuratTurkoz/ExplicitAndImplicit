using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitAndImplicit
{
    internal class Dog : Animal
    {
        public static explicit operator Dog(Bird b)
        {
            Dog dog = new Dog();
            dog.Name = b.Name;
            dog.Id = b.Id;
            dog.Genus = b.Genus;
            return dog; 
        }
    }
}
