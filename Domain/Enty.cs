namespace IWantApp.Domain;

public abstract class Enty
{
    public Enty() 
    { 
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public String Name { get; set; }
    public string CreateBy { get; set; }

    public DateTime CreateOn { get; set; }

    public string EditedBy { get; set; }

    public DateTime EditedOn { get; set; }
}
