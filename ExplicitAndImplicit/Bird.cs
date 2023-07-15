using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitAndImplicit
{
    internal class Bird:Animal
    {
        public static implicit operator Bird(Dog b)
        {
            Bird bird = new Bird();
            bird.Name = b.Name;
            bird.Id = b.Id;
            bird.Genus = b.Genus;
            return bird;
        }
    }
}
