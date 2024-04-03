using CarFactory.Models;
using CarFactory.Models.BodyShape;
using CarFactory.Models.BodyShapes;
using CarFactory.Models.Cars;
using CarFactory.Models.Colors;
using CarFactory.Models.Engine;
using CarFactory.Models.Engines;
using CarFactory.Models.Models;
using CarFactory.Models.SteeringPosition;
using CarFactory.Models.Transmissions;
using System;
using System.Collections.Generic;

namespace CarFactory
{
    public partial class Form1 : Form
    {
        public List<IEngine> EngineList = new List<IEngine>() { new BoxerEngine(), new DieselEngine() };
        public List<ITransmission> TransmissionList = new List<ITransmission>() { new Automatical(), new Mechanical() };
        public List<IModel> ModelsList = new List<IModel>() { new Lada(), new Ferrari() };
        public List<IBodyShape> BodyShapeList = new List<IBodyShape>() { new Sedan(), new Cabriolet() };
        public List<IColor> ColorList = new List<IColor>() { new White(), new Black() };
        public List<ISteeringPosition> SteeringPositionList = new List<ISteeringPosition>() { new RightPosition(), new LeftPosition() };

        public Form1()
        {
            InitializeComponent();

            comboBoxEngines.Items.AddRange(new string[] { EngineList[0].Name, EngineList[1].Name });
            comboBoxTransmission.Items.AddRange(new string[] { TransmissionList[0].Name, TransmissionList[1].Name });
            comboBoxBodyShape.Items.AddRange(new string[] { BodyShapeList[0].Name, BodyShapeList[1].Name });
            comboBoxColor.Items.AddRange(new string[] { ColorList[0].Name, ColorList[1].Name });
            comboBoxModel.Items.AddRange(new string[] { ModelsList[0].Name, ModelsList[1].Name });
            comboBoxSteeringPosition.Items.AddRange(new string[] { SteeringPositionList[0].Name, SteeringPositionList[1].Name });

            comboBoxEngines.SelectedIndex = 0;
            comboBoxTransmission.SelectedIndex = 0;
            comboBoxBodyShape.SelectedIndex = 0;
            comboBoxColor.SelectedIndex = 0;
            comboBoxModel.SelectedIndex = 0;    
            comboBoxSteeringPosition.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ICar car = CarCreation();
            MessageBox.Show(CreatedCarInfo(car));
        }

        private string CreatedCarInfo(ICar car)
        {
            return $"Your car configuration \n Engine - {car.Engine.Name} \n Max speed - {car.Engine.MaxSpeed} \n Transmission - {car.Transmission.Name} \n Color - {car.Color.Name} \n Model - {car.Model.Name} \n Body shape - {car.BodyShape.Name} \n Steering - {car.SteeringPosition.Name}";
        }

        static T FindByName<T>(List<T> list, string name) where T : ICommonProperties
        {
            return list.FirstOrDefault(item => item.Name == name);
        }

        private ICar CarCreation()
        {
            IEngine engine = FindByName(EngineList, comboBoxEngines.SelectedItem.ToString());
            ITransmission transmission = FindByName(TransmissionList, comboBoxTransmission.SelectedItem.ToString());
            IBodyShape bodyShape = FindByName(BodyShapeList, comboBoxBodyShape.SelectedItem.ToString());
            IModel model = FindByName(ModelsList, comboBoxModel.SelectedItem.ToString());
            IColor color = FindByName(ColorList, comboBoxColor.SelectedItem.ToString());
            ISteeringPosition steeringPosition = FindByName(SteeringPositionList, comboBoxSteeringPosition.SelectedItem.ToString());

            return new Car(engine, color, bodyShape, model, transmission, steeringPosition);
        }
    }
}
