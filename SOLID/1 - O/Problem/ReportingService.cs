using System;
using SOLID.S.Solution;

namespace SOLID.O.Problem
{
	public class ReportingService
	{
		public ReportingService()
		{

		}

		public void GenerateReport(List<Order> orders, ReportType type)
		{
			if (type == ReportType.PDF)
			{
				CreatePDFReport(orders);
			}
			else if(type == ReportType.EXCEL)
			{
				CreateExcelReport(orders);
			}
		}

        private void CreateExcelReport(List<Order> orders)
        {
            throw new NotImplementedException();
        }

        private void CreatePDFReport(List<Order> orders)
        {
            throw new NotImplementedException();
        }
    }

    public enum ReportType
    {
		PDF,
		EXCEL
    }
}

