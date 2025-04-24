using System;
using System.Collections.Generic;
using System.Text;
using underware.VDA;
using underware.VDA.Messages;


namespace underware.VDA.Records.V02;

[Parent(typeof(M4905))]
public class R512 : Record, IR512
{
    public R512(string line) : base(line)
    {
    }

    public R512() : base()
    {
        Name = "512";
        Version = "01";
    }

    [Field(3, 3, Align.LEFT)] public string C003_PlantCustomer { get; set; }

    [Field(4, 9, Align.LEFT)] public string C004_DeliveryCallOffNumberNew { get; set; }

    [Field(5, 6, Align.LEFT)] public string C005_DeliveryCallOffDateNew { get; set; }

    [Field(6, 9, Align.LEFT)] public string C006_DeliveryCallOffNumberOld { get; set; }

    [Field(7, 6, Align.LEFT)] public string C007_DeliveryCallOffDateOld { get; set; }

    [Field(8, 22, Align.LEFT)] public string C008_PartNumberCustomer { get; set; }

    [Field(9, 22, Align.LEFT)] public string C009_PartNumberSupplier { get; set; }

    [Field(10, 12, Align.LEFT)] public string C010_ContractOrOrderNumber { get; set; }

    [Field(11, 5, Align.LEFT)] public string C011_PointOfUnloading { get; set; }

    [Field(12, 4, Align.LEFT)] public string C012_CustomerRef { get; set; }

    [Field(13, 2, Align.LEFT)] public string C013_UnitOfQuantity { get; set; }

    [Field(14, 1, Align.LEFT)] public string C014_DeliveryInterval { get; set; }

    [Field(15, 1, Align.LEFT)] public string C015_ManufacturingRelease { get; set; }

    [Field(16, 1, Align.LEFT)] public string C016_MaterialRelease { get; set; }

    [Field(17, 1, Align.LEFT)] public string C017_UsingCode { get; set; }

    [Field(18, 7, Align.LEFT)] public string C018_AccountingCodee { get; set; }

    [Field(19, 7, Align.LEFT)] public string C019_Store { get; set; }

    [Field(22, 5, Align.LEFT)] public string C022_Empty { get; set; }

}

