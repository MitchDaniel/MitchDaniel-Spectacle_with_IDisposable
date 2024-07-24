using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Actor
    {
        public Actor(string fullname) => Fullname = fullname;

        public string Fullname { get; set; } = string.Empty;
    }
}
