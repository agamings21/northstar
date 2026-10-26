namespace Northstar.Models;
public class TodoTask
{
    public Guid Id {get;set;}
    public string Name {get;set;} = string.Empty;
    public DateTime DueDate {get;set;}
    public DateTime CreatedDateTime {get;set;}
    public Recurrence? Recurrence {get;set;}
    public string? Note {get;set;}
}