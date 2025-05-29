using underware.VDA.Messages;

namespace underware.VDA.Records.V03;

[Parent(typeof(M4908))]
public class R822: Record, IR822
{
    public R822(string line) : base(line)
    {
    }

    public R822() : base()
    {
        Name = "822";
        Version = "03";
    }
    
    [Field(3, 8, Align.RIGHT, '0')]
    public string C003_BillNo { get; set; }
    
    [Field(4, 6, Align.RIGHT, '0')]
    public string C004_IssueDate { get; set; }
    
    [Field(5, 6, Align.RIGHT, '0')]
    public string C005_DueDate { get; set; }
    
    [Field(6, 13, Align.RIGHT, '0')]
    public string C006_Surcharges { get; set; }
    
    [Field(7, 1, Align.RIGHT, '0')]
    public string C007_SignCode { get; set; }
    
    [Field(8, 13, Align.RIGHT, '0')]
    public string C008_TotalCacheDiscountAmount { get; set; }
    
    [Field(9, 13, Align.RIGHT, '0')]
    public string C009_TotalVATAmount { get; set; }
    
    [Field(10, 13, Align.RIGHT, '0')]
    public string C010_TotalAmount { get; set; } 
    
    [Field(11, 1, Align.RIGHT, '0')]
    public string C011_SignCode { get; set; }
    
    [Field(12, 3, Align.RIGHT, '0')]
    public string C012_Currency{ get; set; }
    
    [Field(13, 14, Align.RIGHT, '0')]
    public string C013_ConsignmentId { get; set; }
    
    [Field(14, 1, Align.RIGHT, '0')]
    public string C014_InvoiceCode { get; set; }
    
    [Field(15, 2, Align.RIGHT, '0')]
    public string C015_CountryCode { get; set; }
    
    [Field(16, 8, Align.RIGHT, '0')]
    public string C016_CreditorBookingNo { get; set; }
    
    [Field(17, 21, Align.RIGHT, '0')]
    public string C017_Empty { get; set; }
    
}