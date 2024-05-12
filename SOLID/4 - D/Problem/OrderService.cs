using System;
namespace SOLID.D.Problem
{
	public class DataDogService
	{
		public void LogEvent(string message)
		{
			// Code to event on DataDog
		}
	}



	public class OrderService
	{
		public readonly DataDogService dataDogService;
		public OrderService(DataDogService _dataDogService)
		{
			_dataDogService = dataDogService;
		}

		public void GenerateOrder(Order order)
		{
			dataDogService.LogEvent("the order was successfully created");
		}
	}


    public class Order
    {

    }
}

