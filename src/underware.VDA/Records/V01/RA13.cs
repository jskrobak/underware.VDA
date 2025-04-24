using underware.VDA.Messages;

namespace underware.VDA.Records.V01;


[Parent(typeof(M4913))]
public class RA13 : Record, IRA13
{
    public RA13(string line) : base(line)
    {
    }

    public RA13() : base()
    {
        Name = "RA13";
        Version = "01";
    }
    
    [Field(3, 35, Align.LEFT)]
    public string C003_AgreementNumber { get; set; }
}