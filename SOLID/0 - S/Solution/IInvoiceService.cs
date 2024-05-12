using System;
namespace SOLID.S.Solution
{
	public interface IInvoiceService
	{
		Invoice CreateInvoice(Order order);
	}

	class InvoiceService : IInvoiceService
	{
		public Invoice CreateInvoice(Order order)
		{
			return new Invoice();
		}
	}
}

