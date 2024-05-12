using System;
namespace SOLID.I.Problem
{
	internal class BurguerOrderService : IFoodOrderService
	{
		public BurguerOrderService()
		{
		}

        public void OrderBurguer(int quantity)
        {
            //Code to order Burguer
        }

        public void OrderSalad(int quantity)
        {
            throw new NotImplementedException();
        }

        public void OrderSteak(int quantity)
        {
            throw new NotImplementedException();
        }
    }
}

