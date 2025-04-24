namespace underware.VDA.Records.V01;

[Parent(typeof(IR555))]
public class R557: Record, IR557
{
    public R557(string line) : base(line)
    {
    }

    public R557() : base()
    {
        Name = "557";
        Version = "01";
    }
    
    [Field(3, 27, Align.LEFT)]
    public string C03_DailyCallInText1 { get; set; }
    
    [Field(4, 28, Align.LEFT)]
    public string C04_Blank1 { get; set; }
    
    [Field(5, 4, Align.LEFT)]
    public string C05_Text1 { get; set; }
    
    [Field(6, 5, Align.LEFT)]
    public string C06_Blank2 { get; set; }

    [Field(7, 1, Align.LEFT)]
    public string C07_Text2 { get; set; }
    
    [Field(8, 2, Align.LEFT)]
    public string C08_Blank3 { get; set; }
    
    [Field(9, 40, Align.LEFT)]
    public string C09_DailyCallInText2 { get; set; }
    
    [Field(10, 20, Align.LEFT)]
    public string C10_DailyCallInText3 { get; set; }
    
    [Field(11, 20, Align.LEFT)]
    public string C11_Text3 { get; set; }
    
    [Field(12, 3, Align.LEFT)]
    public string C12_Blank4 { get; set; }
    
    
    
}