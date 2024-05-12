using System;
namespace SOLID.S.Solution
{
	internal class OrderService
	{
		private readonly IOrderRepository _orderRepository;
		private readonly INotificationService _notificacionService;
		private readonly IInvoiceService _invoiceService;
		private readonly ILoggerService _loggerService;

		public OrderService(IOrderRepository orderRepository,
                            INotificationService notificacionService,
                            IInvoiceService invoiceService,
                            ILoggerService loggerService)
		{
			_orderRepository = orderRepository;
			_notificacionService = notificacionService;
			_invoiceService = invoiceService;
			_loggerService = loggerService;
		}

		public void SaveOrder(Order order)
		{
			try
			{
				_orderRepository.InsertOrder(order);

				var invoice = _invoiceService.CreateInvoice(order);

				_notificacionService.EmailInvoice(invoice);

				_loggerService.Info("The order has been complete");


			}
			catch(Exception ex)
			{
				_loggerService.Error(ex.Message, ex);
			}
		}
	}
}

