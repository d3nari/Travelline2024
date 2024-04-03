using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Models.BodyShape
{
    public interface IBodyShape : ICommonProperties
    {
        string Name { get; }
    }
}
