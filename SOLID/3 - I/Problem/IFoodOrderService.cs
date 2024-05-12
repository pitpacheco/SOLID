using System;
namespace SOLID.I.Problem
{
	internal interface IFoodOrderService
	{
		void OrderBurguer(int quantity);
		void OrderSteak(int quantity);
		void OrderSalad(int quantity);
	}
}

