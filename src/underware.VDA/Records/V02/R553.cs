namespace underware.VDA.Records.V02;

[Parent(typeof(IR552))]
public class R553: Record, IR553
{
    public R553(string line) : base(line)
    {
    }

    public R553() : base()
    {
        Name = "553";
        Version = "01";
    }

    [Field(3, 10, Align.LEFT)]
    public string C003_CumulativeQuantity { get; set; }

    
    [Field(4, 6, Align.LEFT)]
    public string C004_ReceivingDate1 { get; set; }

    [Field(5, 8, Align.LEFT)]
    public string C005_AdviseNoteNumber1 { get; set; }

    [Field(6, 6, Align.LEFT)]
    public string C006_AdviseNoteDate1  { get; set; }

    [Field(7, 12, Align.LEFT)]
    public string C007_DeliveredQuantity1 { get; set; }
        
    [Field(8, 1, Align.LEFT)]
    public string C008_DeliveryStatusIndicator1 { get; set; }

    
    [Field(9, 6, Align.LEFT)]
    public string C009_ReceivingDate2 { get; set; }
    
    [Field(10, 8, Align.LEFT)]
    public string C010_AdviseNoteNumber2 { get; set; }

    [Field(11, 6, Align.LEFT)]
    public string C011_AdviseNoteDate2{ get; set; }
    
    [Field(12, 12, Align.LEFT)]
    public string C012_DeliveredQuantity2  { get; set; }

    [Field(13, 1, Align.LEFT)]
    public string C013_DeliveryStatusIndicator2{ get; set; }

    
    [Field(14, 6, Align.LEFT)]
    public string C014_ReceivingDate3 { get; set; }
    
    [Field(15, 8, Align.LEFT)]
    public string C015_AdviseNoteNumber3 { get; set; }

    [Field(16, 6, Align.LEFT)]
    public string C016_AdviseNoteDate3 { get; set; }
    
    [Field(17, 12, Align.LEFT)]
    public string C017_DeliveredQuantity3  { get; set; }

    [Field(18, 1, Align.LEFT)]
    public string C018_DeliveryStatusIndicator3 { get; set; }
    
    [Field(19, 14, Align.LEFT)]
    public string C019_Empty { get; set; }
}