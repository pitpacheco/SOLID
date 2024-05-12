using System;
namespace SOLID.L.Problem
{
	internal class Bike : Vehicle
	{
		public Bike()
		{
		}

        public override void Brake()
        {
            base.Brake();
        }

        public override void Park()
        {
            base.Park();
        }
        public override void SpeedUp()
        {
            base.SpeedUp();
        }

        public override void TakeOff()
        {
            throw new NotImplementedException();
        }

        public override void Land()
        {
            throw new NotImplementedException();
        }
    }
}

