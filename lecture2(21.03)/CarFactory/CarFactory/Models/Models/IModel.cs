using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Models.Models
{
    public interface IModel : ICommonProperties
    {
        string Name { get; }
    }
}
