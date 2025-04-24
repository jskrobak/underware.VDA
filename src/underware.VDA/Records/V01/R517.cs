namespace underware.VDA.Records.V01;

[Parent(typeof(IR513))]
public class R517: Record, IR517
{
    public R517(string line) : base(line)
    {
    }

    public R517() : base()
    {
        Name = "517";
        Version = "01";
    }
    
    [Field(3, 22, Align.LEFT)] 
    public string PartNumberCustomer { get; set; }
    
    [Field(4, 22, Align.LEFT)] 
    public string PartNumberSupplier { get; set; }
    
    [Field(5, 7, Align.LEFT)] 
    public string VolumetricCapacity { get; set; }
    
    [Field(6, 72, Align.LEFT)] 
    public string Empty { get; set; }
}