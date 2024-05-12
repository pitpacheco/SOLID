namespace SOLID.O.Solution
{
    internal interface IReportGenerator
    {
        void CreateReport(List<Order> orders);
    }
}