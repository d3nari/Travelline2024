using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Models.Engine
{
    public interface IEngine : ICommonProperties
    {
        string Name { get; }
        int MaxSpeed {  get; }

    }
}
