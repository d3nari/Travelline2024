using CarFactory.Models.BodyShape;
using CarFactory.Models.Colors;
using CarFactory.Models.Engine;
using CarFactory.Models.Models;
using CarFactory.Models.SteeringPosition;
using CarFactory.Models.Transmissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Models.Cars
{
    public interface ICar
    {
        public IEngine Engine { get; }
        public ITransmission Transmission { get; }
        public IColor Color { get; }
        public IBodyShape BodyShape { get; }
        public IModel Model { get; }
        public ISteeringPosition SteeringPosition { get; }
    }
}
