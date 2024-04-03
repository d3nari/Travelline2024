using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Models.Colors
{
    public interface IColor : ICommonProperties
    {
        public string Name { get; }
    }
}
