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
    public class Car : ICar
    {
        public IEngine Engine { get; }
        public IColor Color { get; }
        public IBodyShape BodyShape { get; }
        public IModel Model { get; }
        public ITransmission Transmission { get; }
        public ISteeringPosition SteeringPosition { get; }

        public Car(IEngine engine, IColor color, IBodyShape bodyShape, IModel model, ITransmission transmission, ISteeringPosition steeringPosition)
        {
            Engine = engine;
            Color = color;
            BodyShape = bodyShape;
            Model = model;
            Transmission = transmission;
            SteeringPosition = steeringPosition;
        }
    }
}
