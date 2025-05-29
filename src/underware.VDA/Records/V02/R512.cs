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

    //6
    [Field(3, 3, Align.LEFT)] public string C003_PlantCustomer { get; set; }

    //9
    [Field(4, 9, Align.LEFT)] public string C004_DeliveryCallOffNumberNew { get; set; }

    //18
    [Field(5, 6, Align.LEFT)] public string C005_DeliveryCallOffDateNew { get; set; }

    //24
    [Field(6, 9, Align.LEFT)] public string C006_DeliveryCallOffNumberOld { get; set; }

    //33
    [Field(7, 6, Align.LEFT)] public string C007_DeliveryCallOffDateOld { get; set; }

    //39
    [Field(8, 22, Align.LEFT)] public string C008_PartNumberCustomer { get; set; }

    //61
    [Field(9, 22, Align.LEFT)] public string C009_PartNumberSupplier { get; set; }

    //83
    [Field(10, 12, Align.LEFT)] public string C010_ContractOrOrderNumber { get; set; }

    //95
    [Field(11, 5, Align.LEFT)] public string C011_PointOfUnloading { get; set; }

    //100
    [Field(12, 4, Align.LEFT)] public string C012_CustomerRef { get; set; }

    //104
    [Field(13, 2, Align.LEFT)] public string C013_UnitOfQuantity { get; set; }

    //106
    [Field(14, 1, Align.LEFT)] public string C014_DeliveryInterval { get; set; }

    //107
    [Field(15, 1, Align.LEFT)] public string C015_ManufacturingRelease { get; set; }

    //108
    [Field(16, 1, Align.LEFT)] public string C016_MaterialRelease { get; set; }

    //109
    [Field(17, 1, Align.LEFT)] public string C017_UsingCode { get; set; }

    //110
    [Field(18, 7, Align.LEFT)] public string C018_AccountingCode { get; set; }

    //123
    [Field(19, 7, Align.LEFT)] public string C019_Store { get; set; }

    //130
    [Field(22, 5, Align.LEFT)] public string C022_Empty { get; set; }

}

