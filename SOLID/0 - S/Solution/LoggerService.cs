using System;
namespace SOLID.S.Solution
{
	public interface ILoggerService
	{
		void Info(string info);
		void Debug(string info);
		void Error(string message, Exception ex);
	}

	public class LoggerService
	{
		public LoggerService()
		{

		}

		public void Info(string info)
		{

		}

		public void Debug (string info)
		{

		}

		public void Error(string info, Exception ex)
		{

		}
	}
}

