﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Models.Transmissions
{
    public interface ITransmission : ICommonProperties
    {
        string Name { get; }
    }
}
