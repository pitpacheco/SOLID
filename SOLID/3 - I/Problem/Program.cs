using System;
namespace SOLID.I.Problem
{
	public class Program
	{
		public static void Main()
		{
			BurguerOrderService service = new BurguerOrderService();
			service.OrderBurguer(2);
		}
	}
}

