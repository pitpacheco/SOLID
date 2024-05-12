using System;
namespace SOLID.L.Solution
{
	public class Car : IBrake, ISpeedUp, IPark
	{
		public Car()
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

