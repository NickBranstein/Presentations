using System.ComponentModel;

namespace Core.Domain;

public class Dashboard
{
    public int SayHelloJobsRun { get; set; }
    public int BuildHouseJobsRun { get; set; }
    public int PaintingJobsRun { get; set; }
    public int PlumbingJobsRun { get; set; }
    public int SalesJobsRun { get; set; }
    public int WeldingJobsRun { get; set; }
}