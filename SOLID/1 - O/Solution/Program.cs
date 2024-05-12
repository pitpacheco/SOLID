using System;
namespace SOLID.O.Solution
{
	public class Program
	{
		public static void Main()
		{
			List<Order> orders = new List<Order>();

			ReportingService service = new ReportingService(new ReportGeneratorJson());  // Send implementation
			service.GenerateReport(orders);
		}
	}
}

