namespace underware.VDA.Records.V02;

[Parent(typeof(IR552))]
public class R554: Record, IR554
{
    public R554(string line) : base(line)
    {
    }

    public R554() : base()
    {
        Name = "554";
        Version = "02";
    }
    
    [Field(3, 6, Align.LEFT)] public string C003_CallInDate1 { get; set; }

    [Field(4, 4, Align.LEFT)] public string C004_CallInTime1 { get; set; }

    [Field(5, 9, Align.LEFT)] public string C005_CallInQty1 { get; set; }

    [Field(6, 1, Align.LEFT)] public string C006_CallInIndicator1 { get; set; }
    
    
    [Field(7, 6, Align.LEFT)] public string C007_CallInDate2 { get; set; }

    [Field(8, 4, Align.LEFT)] public string C008_CallInTime2 { get; set; }

    [Field(9, 9, Align.LEFT)] public string C009_CallInQty2 { get; set; }

    [Field(10, 1, Align.LEFT)] public string C010_CallInIndicator2 { get; set; }
    
    [Field(11, 6, Align.LEFT)] public string C011_CallInDate3 { get; set; }

    [Field(12, 4, Align.LEFT)] public string C012_CallInTime3 { get; set; }

    [Field(13, 9, Align.LEFT)] public string C013_CallInQty3 { get; set; }

    [Field(14, 1, Align.LEFT)] public string C014_CallInIndicator3 { get; set; }
    
    [Field(15, 6, Align.LEFT)] public string C015_CallInDate4 { get; set; }

    [Field(16, 4, Align.LEFT)] public string C016_CallInTime4 { get; set; }

    [Field(17, 9, Align.LEFT)] public string C017_CallInQty4 { get; set; }

    [Field(18, 1, Align.LEFT)] public string C018_CallInIndicator4 { get; set; }
    
    [Field(19, 6, Align.LEFT)] public string C019_CallInDate5 { get; set; }

    [Field(20, 4, Align.LEFT)] public string C020_CallInTime5 { get; set; }

    [Field(21, 9, Align.LEFT)] public string C021_CallInQty5 { get; set; }

    [Field(22, 1, Align.LEFT)] public string C022_CallInIndicator5 { get; set; }
    
    [Field(23, 6, Align.LEFT)] public string C023_CallInDate6 { get; set; }

    [Field(24, 4, Align.LEFT)] public string C024_CallInTime6 { get; set; }

    [Field(25, 9, Align.LEFT)] public string C025_CallInQty6 { get; set; }

    [Field(26, 1, Align.LEFT)] public string C026_CallInIndicator6 { get; set; }
    
    
    [Field(27, 3, Align.LEFT)] public string C027_Empty3 { get; set; }
}