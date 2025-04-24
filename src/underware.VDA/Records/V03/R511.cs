using System;
using underware.VDA.Messages;

namespace underware.VDA.Records.V03;

public class R511: Record, IR511
{
    public R511(string line) : base(line)
    {
    }

    public R511() : base()
    {
        Name = "511";
        Version = "03";
    }


    [Field(3, 9, Align.LEFT)]
    public string C003_CustomerID { get; set; }

    [Field(4, 9, Align.LEFT)]
    public string C004_SupplierID { get; set; }

    [Field(5, 5, Align.LEFT)]
    public string C005_OldTransmissionNo { get; set; }

    [Field(6, 5, Align.LEFT)]
    public string C006_NewTransmissionNo { get; set; }

    [Field(7, 6, Align.LEFT)]
    public string C007_TransmissionDate { get; set; }

    [Field(8, 6, Align.LEFT)]
    public string C008_DateSetToZeroNumber { get; set; }

    [Field(9, 83, Align.LEFT)]
    public string C009_Empty { get; set; }

    public string Sender
    {
        get { return C003_CustomerID; }
        set { C003_CustomerID = value; }
    }

    public string Receiver => C004_SupplierID;
    
    public string RefNumber => C006_NewTransmissionNo;
    public string MessageName => "4905";
    public Type MessageType => typeof(M4905);
}