using System;
namespace SOLID.L.Solution
{
	public class Bike : ISpeedUp, IBrake, IPark
	{
		public Bike()
		{
		}

        public void Brake()
        {
            throw new NotImplementedException();
        }

        public void Park()
        {
            throw new NotImplementedException();
        }

        public void SpeedUp()
        {
            throw new NotImplementedException();
        }
    }
}

