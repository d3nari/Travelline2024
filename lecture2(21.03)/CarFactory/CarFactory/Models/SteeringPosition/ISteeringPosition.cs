using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Models.SteeringPosition
{
    public interface ISteeringPosition : ICommonProperties
    {
        string Name { get; }
    }
}
