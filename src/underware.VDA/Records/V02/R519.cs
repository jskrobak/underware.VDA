using System.Linq;
using underware.VDA.Messages;

namespace underware.VDA.Records.V02;

[Parent(typeof(M4905))]
public class R519: Record, IR519
{
    public R519(string line) : base(line)
    {
    }

    public R519() : base()
    {
        Name = "519";
        Version = "02";
    }

    [Field(1, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter511 { get; set; }

    [Field(2, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter512 { get; set; }

    [Field(3, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter513 { get; set; }

    [Field(4, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter514 { get; set; }

    [Field(5, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter517 { get; set; }

    [Field(6, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter518 { get; set; }

    [Field(7, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter519 { get; set; }

    [Field(8, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter515 { get; set; }

    [Field(10, 67)]
    public string Empty { get; set; }

    public void Recalculate(Interchange interchange)
    {
        
        var allRecords = interchange.GetAllRecords();
        
        RecordTypeCounter511 = allRecords.OfType<IR511>().Count().ToString();
        RecordTypeCounter512 = allRecords.OfType<IR512>().Count().ToString();
        RecordTypeCounter513 = allRecords.OfType<IR513>().Count().ToString();
        RecordTypeCounter514 = allRecords.OfType<IR514>().Count().ToString();
        RecordTypeCounter517 = allRecords.OfType<IR517>().Count().ToString();
        RecordTypeCounter518 = allRecords.OfType<IR518>().Count().ToString();
        RecordTypeCounter519 = allRecords.OfType<IR519>().Count().ToString();
        RecordTypeCounter515 = allRecords.OfType<IR515>().Count().ToString();
    }
}