public class ExcelReportFactory : ReportFactory
{
    public override IReport GenerateReport(string reportName) 
    {
        return new ExcelReport(reportName);
    }
}