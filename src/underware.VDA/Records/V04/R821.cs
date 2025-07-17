using System;
using underware.VDA.Messages;

namespace underware.VDA.Records.V04;

public class R821: Record, IR821
{
    public R821(string line) : base(line)
    {
    }

    public R821() : base()
    {
        Name = "821";
        Version = "04";
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
    
    
    [Field(8, 20, Align.LEFT)]
    public string C008_CustomersVATNo { get; set; }
    
    [Field(9, 20, Align.LEFT)]
    public string C009_SuppliersVATNo { get; set; }
    
    [Field(10, 25, Align.LEFT)]
    public string C010_SuppliersRegNo { get; set; }
    
    [Field(11, 24, Align.LEFT)]
    public string C011_Blank { get; set; }

    public string Sender
    {
        get => C003_CustomerID;
        set => C003_CustomerID = value;
    }
    public string Receiver
    {
        get => C004_SupplierID;
        set => C004_SupplierID = value;
    }
    public string RefNumber => C006_NewTransmissionNo;
    public string MessageName => "4908";
    public Type MessageType => typeof(M4908);
    public string TransmissionDate => C007_TransmissionDate;
}