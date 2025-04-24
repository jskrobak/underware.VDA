namespace underware.VDA.Records.V01;

[Parent(typeof(IR555))]
public class R556: Record, IR556
{
    public R556(string line) : base(line)
    {
    }

    public R556() : base()
    {
        Name = "555";
        Version = "01";
    }
    
    [Field(3, 22, Align.LEFT)]
    public string C03_PackagingCodeCustomer { get; set; }
    
    [Field(4, 22, Align.LEFT)]
    public string C04_PackagingCodeSupplier { get; set; }
    
    [Field(5, 7, Align.LEFT)]
    public string C05_NumberOfPartsPerPallet { get; set; }
    
    [Field(6, 72, Align.LEFT)]
    public string C06_Empty { get; set; }
    
    
}