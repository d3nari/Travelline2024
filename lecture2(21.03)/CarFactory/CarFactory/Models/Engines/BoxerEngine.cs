using CarFactory.Models.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Models.Engines
{
    public class BoxerEngine : IEngine
    {
        public string Name { get; } = "Boxer";
        public int MaxSpeed { get; } = 180;
    }
}
