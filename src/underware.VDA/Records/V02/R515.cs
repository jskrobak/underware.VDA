namespace underware.VDA.Records.V02;

[Parent(typeof(IR512))]
public class R515: Record, IR515
{
    public R515(string line) : base(line)
    {
    }

    public R515() : base()
    {
        Name = "512";
        Version = "02";
    }
    
    [Field(3, 6, Align.LEFT)] public string C003_ProductionAuthorisationStartDate  { get; set; }
    [Field(4, 6, Align.LEFT)] public string C004_ProductionAuthorisationEndDate { get; set; }
    [Field(5, 10, Align.RIGHT)] public string C005_ProductionAuthorisationCumulativeQty { get; set; }
    [Field(6, 6, Align.RIGHT)] public string C006_MaterialAuthorisationStartDate  { get; set; }
    [Field(7, 6, Align.RIGHT)] public string C007_MaterialAuthorisationEndDate { get; set; }
    [Field(8, 10, Align.RIGHT)] public string C008_MaterialAuthorisationCumulativeDemand { get; set; }
    [Field(9, 22, Align.RIGHT)] public string C009_FPSDArticleCode { get; set; }
    [Field(10, 9, Align.RIGHT)] public string C010_SubSuplier { get; set; }
    [Field(11, 6, Align.RIGHT)] public string C011_PlanningHorizonDate { get; set; }
    [Field(12, 14, Align.LEFT)] public string C012_PointOfUse { get; set; }
    [Field(13, 10, Align.LEFT)] public string C013_CumulativeReceivedQtyBeforeReset { get; set; }
    [Field(14, 18, Align.LEFT)] public string C014_Empty { get; set; }
}