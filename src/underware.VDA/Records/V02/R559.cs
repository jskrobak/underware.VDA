using System.Linq;

namespace underware.VDA.Records.V02;

public class R559: Record, IR559
{
    public R559(string line) : base(line)
    {
    }

    public R559() : base()
    {
        Name = "559";
        Version = "02";
    }
    
    [Field(1, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter551 { get; set; }

    [Field(2, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter552 { get; set; }

    [Field(3, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter553 { get; set; }

    [Field(4, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter554 { get; set; }

    [Field(5, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter555 { get; set; }
    
    [Field(6, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter556 { get; set; }
    
    [Field(7, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter557 { get; set; }

    [Field(8, 7, Align.RIGHT, '0')]
    public string RecordTypeCounter559 { get; set; }

    [Field(9, 67, Align.LEFT)]
    public string Empty { get; set; }

    public void Recalculate(Interchange interchange)
    {
        var allRecords = interchange.GetAllRecords();
        
        RecordTypeCounter551 = allRecords.OfType<IR551>().Count().ToString();
        RecordTypeCounter552 = allRecords.OfType<IR552>().Count().ToString();
        RecordTypeCounter553 = allRecords.OfType<IR553>().Count().ToString();
        RecordTypeCounter554 = allRecords.OfType<IR554>().Count().ToString();
        RecordTypeCounter555 = allRecords.OfType<IR555>().Count().ToString();
        RecordTypeCounter556 = allRecords.OfType<IR556>().Count().ToString();
        RecordTypeCounter557 = allRecords.OfType<IR557>().Count().ToString();
        RecordTypeCounter559 = allRecords.OfType<IR559>().Count().ToString();
    }
}