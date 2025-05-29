namespace underware.VDA.Records.V03;

[Parent(typeof(IR823))]
public class R824: Record, IR824
{
    public R824(string line) : base(line)
    {
    }

    public R824() : base()
    {
        Name = "824";
        Version = "03";
    }
    
    [Field(3, 2, Align.RIGHT, '0')]
    public string C003_TransactionCode { get; set; }
    
    [Field(4, 22, Align.LEFT)]
    public string C004_CustomersItemNo { get; set; }
    
    [Field(5, 13, Align.RIGHT, '0')]
    public string C005_Qty { get; set; }
    
    [Field(6, 3, Align.RIGHT, '0')]
    public string C006_QtyUnit { get; set; }
    
    [Field(7, 2, Align.RIGHT, '0')]
    public string C007_PriceUnit{ get; set; }
    
    [Field(8, 13, Align.RIGHT, '0')]
    public string C008_UnitPrice { get; set; }
    
    [Field(9, 13, Align.RIGHT, '0')]
    public string C009_TotalPrice { get; set; }
    
    [Field(10, 1, Align.RIGHT, '0')]
    public string C010_SignCode { get; set; }
    
    [Field(11, 3, Align.RIGHT, '0')]
    public string C011_CashDiscountPercentage{ get; set; }
    
    [Field(12, 13, Align.RIGHT, '0')]
    public string C012_CashDiscountAmount{ get; set; }
    
    [Field(13, 4, Align.RIGHT, '0')]
    public string C013_VATRate { get; set; }
    
    [Field(14, 13, Align.RIGHT, '0')]
    public string C014_VATAmout{ get; set; }
    
    [Field(15, 14, Align.RIGHT, '0')]
    public string C015_CustomersTestReportNo { get; set; }
    
    [Field(16, 7, Align.RIGHT, '0')]
    public string C017_Empty { get; set; }

    
    
}