using System;
namespace SOLID.S.Problem
{
	internal class OrderService
	{
		public OrderService()
		{
		}

		public void SaveOrder(Order order)
		{
			try
			{
				this.InsertOrder(order);
				var invoice = this.CreateInvoice(order);
				this.EmailInvoice(invoice);
				File.WriteAllText(@"/Users/pedropacheco/Desktop/Infolog.txt", "the order has be completed");
			}catch(Exception e)
			{
				File.WriteAllText(@"/Users/pedropacheco/Desktop/Errorlot.txt", e);
			}
		}

		public bool InsertOrder(Order order)
		{
			return true;
		}

		public Invoice CreateInvoice(Order order)
		{
			return new Invoice();
		}

		public bool EmailInvoice(Invoice invoice)
		{
			return true;
		}
	}

	public class Order { }
	public class Invoice { }
}

