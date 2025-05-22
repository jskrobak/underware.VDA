using System;
using System.Collections.Generic;
using System.Text;

namespace underware.VDA.Records.V01;

[Parent(typeof(IR513))]
public class R514 : Record, IR514
{

    public R514(string line) : base(line)
    {
    }

    public R514() : base()
    {
        Name = "514";
        Version = "01";
    }

    [Field(3, 6, Align.LEFT, '0')] public string C003_CallOffDate6 { get; set; }

    [Field(4, 9, Align.RIGHT, '0')] public string C004_CallOffQty6 { get; set; }

    [Field(5, 6, Align.LEFT, '0')] public string C005_CallOffDate7 { get; set; }

    [Field(6, 9, Align.RIGHT, '0')] public string C006_CallOffQty7 { get; set; }

    [Field(7, 6, Align.LEFT, '0')] public string C007_CallOffDate8 { get; set; }

    [Field(8, 9, Align.RIGHT, '0')] public string C008_CallOffQty8 { get; set; }

    [Field(9, 6, Align.LEFT, '0')] public string C009_CallOffDate9 { get; set; }

    [Field(10, 9, Align.RIGHT, '0')] public string C010_CallOffQty9 { get; set; }

    [Field(11, 6, Align.LEFT, '0')] public string C011_CallOffDate10 { get; set; }

    [Field(12, 9, Align.RIGHT, '0')] public string C012_CallOffQty10 { get; set; }

    [Field(13, 6, Align.LEFT, '0')] public string C013_CallOffDate11 { get; set; }

    [Field(14, 9, Align.RIGHT, '0')] public string C014_CallOffQty11 { get; set; }

    [Field(15, 6, Align.LEFT, '0')] public string C015_CallOffDate12 { get; set; }

    [Field(16, 9, Align.RIGHT, '0')] public string C016_CallOffQty12 { get; set; }

    [Field(17, 6, Align.LEFT, '0')] public string C017_CallOffDate13 { get; set; }

    [Field(18, 9, Align.RIGHT, '0')] public string C018_CallOffQty13 { get; set; }

    [Field(19, 3, Align.LEFT)] public string C019_Empty3 { get; set; }

}

