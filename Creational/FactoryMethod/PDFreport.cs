public class PDFreport : IReport
{
    private string _reportName = string.Empty;

    public PDFreport(string reportName) 
    {
        this._reportName = reportName;
    }

    public void Print() 
    {
        Console.WriteLine($"{this._reportName}.pdf is printed.");
    }
}