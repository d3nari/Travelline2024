﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Models.Transmissions
{
    public class Mechanical : ITransmission
    {
        public string Name { get; } = "Mechanical";
    }
}
