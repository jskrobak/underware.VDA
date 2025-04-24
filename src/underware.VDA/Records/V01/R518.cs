namespace underware.VDA.Records.V01;

[Parent(typeof(IR513))]
public class R518: Record, IR518
{
    public R518(string line) : base(line)
    {
    }

    public R518() : base()
    {
        Name = "518";
        Version = "01";
    }
    
    [Field(3, 40, Align.LEFT)] 
    public string DeliveryScheduleText1 { get; set; }
    
    [Field(4, 40, Align.LEFT)] 
    public string DeliveryScheduleText2 { get; set; }
    
    [Field(5, 40, Align.LEFT)] 
    public string DeliveryScheduleText3 { get; set; }
    
    [Field(6, 3, Align.LEFT)] 
    public string Empty { get; set; }
}