using underware.VDA.Messages;

namespace underware.VDA.Records.V01;

[Parent(typeof(M4915))]
public class R552: Record, IR552
{
    public R552(string line) : base(line)
    {
    }

    public R552() : base()
    {
        Name = "552";
        Version = "01";
    }
    
    [Field(3, 3, Align.LEFT)] 
    public string C003_PlantCustomer { get; set; }
    
    [Field(4, 9, Align.LEFT)] 
    public string C004_DeliveryCallOffNumber { get; set; }
    
    [Field(5, 6, Align.LEFT)] 
    public string C005_DeliveryCallOffDate { get; set; }
    
    [Field(6, 22, Align.LEFT)] 
    public string C006_PartNumberCustomer { get; set; }
    
    [Field(7, 22, Align.LEFT)] 
    public string C007_PartNumberSupplier { get; set; }
    
    [Field(8, 5, Align.LEFT)] 
    public string C008_ReceivingLocation { get; set; }
    
    [Field(9, 7, Align.LEFT)] 
    public string C009_CustomerStorageLocation { get; set; }
    
    [Field(10, 1, Align.LEFT)] 
    public string C010_CriticalPartIndicator { get; set; }
    
    [Field(11, 1, Align.LEFT)] 
    public string C011_RequirementIndicator { get; set; }
    
    [Field(12, 6, Align.LEFT)] 
    public string C012_DCIHorizon { get; set; }
    
    [Field(13, 1, Align.LEFT)] 
    public string C013_ReceivingOrShippingIndicator { get; set; }
    
    [Field(14, 12, Align.LEFT)] 
    public string C014_OrderNumber { get; set; }
    
    [Field(15, 10, Align.LEFT)] 
    public string C015_Overdelivery { get; set; }
    
    [Field(16, 14, Align.LEFT)] 
    public string C016_UsageLocationCode { get; set; }
    
    [Field(17, 4, Align.LEFT)] 
    public string C017_Blank { get; set; }
}