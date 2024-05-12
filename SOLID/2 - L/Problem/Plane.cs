using System;
namespace SOLID.L.Problem
{
	 internal class Plane : Vehicle
	{
		public Plane()
		{
		}
        public override void Brake()
        {
            base.Brake();
        }

        public override void Land()
        {
            throw new Exception();
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
            throw new Exception();
        }
    }
}

