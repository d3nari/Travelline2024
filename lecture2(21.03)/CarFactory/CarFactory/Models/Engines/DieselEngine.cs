using CarFactory.Models.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Models.Engines
{
    public class DieselEngine : IEngine
    {
        public string Name { get; } = "Diesel";
        public int MaxSpeed { get; } = 110;

    }
}
