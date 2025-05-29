using System.Linq;
using underware.VDA.Messages;

namespace underware.VDA.Records.V03;

[Parent(typeof(M4908))]
public class R829: Record, IR829
{
    public R829(string line) : base(line)
    {
    }

    public R829() : base()
    {
        Name = "829 ";
        Version = "03";
    }
    
    [Field(3, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter821 { get; set; }

    [Field(4, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter822 { get; set; }

    [Field(5, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter823 { get; set; }

    [Field(6, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter824 { get; set; }

    [Field(7, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter825 { get; set; }

    [Field(8, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter826 { get; set; }

    [Field(9, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter827 { get; set; }

    [Field(10, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter829 { get; set; }

    [Field(11, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter828 { get; set; }

    [Field(12, 13, Align.RIGHT, '0')]
    public string TotalVATAmount { get; set; }
    
    [Field(13, 13, Align.RIGHT, '0')]
    public string TotalPaymentAmount { get; set; }
    
    [Field(14, 1, Align.RIGHT, '0')]
    public string SignCode { get; set; }
    
    [Field(15, 1, Align.RIGHT, '0')]
    public string PaymentMode { get; set; }
    
    [Field(16, 32, Align.RIGHT, '0')]
    public string Empty { get; set; }

    
    public void Recalculate(Interchange interchange)
    {
        var allRecords = interchange.GetAllRecords();

        RecordTypeCounter821 = allRecords.OfType<IR821>().Count().ToString();
        RecordTypeCounter822 = allRecords.OfType<IR822>().Count().ToString();
        RecordTypeCounter823 = allRecords.OfType<IR823>().Count().ToString();
        RecordTypeCounter824 = allRecords.OfType<IR824>().Count().ToString();
        RecordTypeCounter825 = allRecords.OfType<IR825>().Count().ToString();
        RecordTypeCounter826 = allRecords.OfType<IR826>().Count().ToString();
        RecordTypeCounter827 = allRecords.OfType<IR827>().Count().ToString();
        RecordTypeCounter828 = allRecords.OfType<IR828>().Count().ToString();
        RecordTypeCounter829 = allRecords.OfType<IR829>().Count().ToString();
        
    }
}
