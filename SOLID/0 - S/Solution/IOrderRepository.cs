using System;
namespace SOLID.S.Solution
{
	public interface IOrderRepository
	{
		public bool InsertOrder(Order order);
	}

	class OrderRepository :IOrderRepository
	{
		public bool InsertOrder (Order order)
		{
			return true;
		}
	}
}

