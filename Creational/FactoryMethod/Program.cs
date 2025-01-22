ReportFactory? factory = null;

while (true)
{
    Console.WriteLine("1. Genrate PDF Report");
    Console.WriteLine("2. Genrate Excel Report");
    Console.Write("Enter your choice : ");
    int choice = int.Parse(Console.ReadLine());
    Console.Write("Enter report name : ");
    string reportName = Console.ReadLine();
    Console.Clear();

    switch (choice)
    {
        case 1:
            factory = new PDFReportFactory();
            break;
        case 2:
            factory = new ExcelReportFactory();
            break;
        default:
            break;
    }

    IReport report = factory.GenerateReport(reportName);
    report.Print();
}