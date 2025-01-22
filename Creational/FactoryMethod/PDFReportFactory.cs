public class PDFReportFactory : ReportFactory
{
    public override IReport GenerateReport(string reportName)
    {
        return new PDFreport(reportName);
    }
}