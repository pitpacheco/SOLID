using System;
namespace SOLID.S.Solution
{
	public interface INotificationService
	{
		bool EmailInvoice(Invoice invoice);
	}

	class NotificationService: INotificationService
	{
		public bool EmailInvoice(Invoice invoice)
		{
			return true;
		}
	}
}

