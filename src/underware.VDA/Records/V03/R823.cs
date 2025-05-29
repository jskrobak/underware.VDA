namespace underware.VDA.Records.V03;

[Parent(typeof(IR822))]
public class R823: Record, IR823
{
    public R823(string line) : base(line)
    {
    }

    public R823() : base()
    {
        Name = "823";
        Version = "03";
    }
    
    [Field(3, 8, Align.RIGHT, '0')]
    public string C003_DeliveryNoteNo { get; set; }
    
    [Field(4, 3, Align.RIGHT, '0')]
    public string C004_PlantCustomer { get; set; }
    
    [Field(5, 6, Align.RIGHT, '0')]
    public string C005_DispatchDate { get; set; }
    
    [Field(6, 13, Align.RIGHT, '0')]
    public string C006_TotalSurcharges { get; set; }
    
    [Field(7, 1, Align.RIGHT, '0')]
    public string C007_SignCode{ get; set; }
    
    [Field(8, 13, Align.RIGHT, '0')]
    public string C008_CacheDiscountAmount { get; set; }
    
    [Field(9, 13, Align.RIGHT, '0')]
    public string C009_VATAmount { get; set; }
    
    [Field(10, 13, Align.RIGHT, '0')]
    public string C010_DeliveryNoteTotal { get; set; }
    
    [Field(11, 1, Align.RIGHT, '0')]
    public string C011_SignCode { get; set; }
    
    [Field(12, 12, Align.RIGHT, '0')]
    public string C012_PurchaseOrderNo{ get; set; }
    
    [Field(13, 5, Align.RIGHT, '0')]
    public string C013_UnloadingPoint { get; set; }
    
    [Field(14, 8, Align.RIGHT, '0')]
    public string C014_BookingUloadingNo{ get; set; }
    
    [Field(15, 6, Align.RIGHT, '0')]
    public string C015_StockReceiptDate { get; set; }
    
    [Field(16, 15, Align.RIGHT, '0')]
    public string C016_CustomersContactPerson { get; set; }
    
    [Field(17, 6, Align.RIGHT, '0')]
    public string C017_Empty { get; set; }
        
        
}