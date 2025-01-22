public class ExcelReport : IReport
{
    private string _reportName = string.Empty;
    
    public ExcelReport(string reportName) 
    {
        this._reportName = reportName;
    }
    
    public void Print()
    {
        Console.WriteLine($"{this._reportName}.xlsx is printed.");
    }
}