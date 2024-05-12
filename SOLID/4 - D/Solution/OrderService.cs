using System;
namespace SOLID.D.Solution
{
	public class OrderService
	{
		public readonly IEventNotificationService _eventNotificationService;
		public OrderService(IEventNotificationService eventNotificationService)
		{
			_eventNotificationService = eventNotificationService;

        }

		public void GenerateOrder(Order order)
		{

			_eventNotificationService.Logevent("The order was succeccsfully created");

		}

		
	}

	public class Order { }
}

