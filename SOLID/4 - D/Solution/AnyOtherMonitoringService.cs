using System;
namespace SOLID.D.Solution
{
	public class AnyOtherMonitoringService : IEventNotificationService
	{
		public AnyOtherMonitoringService()
		{
		}

        public void Logevent(string message)
        {
            throw new NotImplementedException();
        }
    }
}

