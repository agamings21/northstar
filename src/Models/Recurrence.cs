namespace Northstar.Models;

public class Recurrence
{
    public Guid Id {get;set;}
    public string Name {get;set;} = string.Empty;
    
    public string RecurrenceType {get;set;} = string.Empty;
}