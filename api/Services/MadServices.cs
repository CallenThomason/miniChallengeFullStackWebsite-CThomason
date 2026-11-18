using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class MadServices : IMadServices
    {
        public string madLib(string name, string animal, string another, int num, string noun, string color, string verb, string place, string adj, string food)
        {
           return $"There once was a man named {name}. He had a trusty pet {animal} named {another}. {name} and {another} did everything together. When {another} turned {num}, {name} gave him a {color} {noun}. Then the two {verb} to {place}. They saw a {adj} car, and ate all you could eat {food}! THE END! ";
        }
    }
}