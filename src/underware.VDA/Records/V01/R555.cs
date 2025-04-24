namespace underware.VDA.Records.V01;

[Parent(typeof(IR552))]
public class R555: Record, IR555
{
    public R555(string line) : base(line)
    {
    }

    public R555() : base()
    {
        Name = "555";
        Version = "01";
    }
    
    [Field(3, 9, Align.LEFT)]
    public string C03_IntermediateSupplier { get; set; }
    
    [Field(4, 22, Align.LEFT)]
    public string C04_AdditionalItemNumber { get; set; }
    
    [Field(5, 10, Align.LEFT)]
    public string C05_QtyBeforeReset { get; set; }
    
    [Field(6, 82, Align.LEFT)]
    public string C06_Empty { get; set; }
}