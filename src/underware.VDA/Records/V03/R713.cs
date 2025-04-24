using System;
using System.Collections.Generic;
using System.Text;
using underware.VDA.Messages;

namespace underware.VDA.Records.V03
{
    [Parent(typeof(M4913))]
    public class R713 : Record, IR713
    {
        public R713(string line) : base(line)
        {
        }

        public R713() : base()
        {
            Name = "713";
            Version = "03";
        }

        [Field(1, 8, Align.LEFT)]
        public string C003_DeliveryNoteNo { get; set; }

        [Field(2, 6, Align.LEFT)]
        public string C004_DespatchDate { get; set; }

        [Field(3, 5, Align.LEFT)]
        public string C005_UnloadingPoint { get; set; }

        [Field(4, 2, Align.LEFT)]
        public string C006_DespatchType { get; set; }

        [Field(5, 4, Align.LEFT)]
        public string C007_CustomerReferenceNoLAB { get; set; }

        [Field(6, 12, Align.LEFT)]
        public string C008_ContractOrderNo { get; set; }

        [Field(7, 2, Align.LEFT)]
        public string C009_ProcessCode { get; set; }

        [Field(8, 4, Align.LEFT)]
        public string C010_Empty { get; set; }

        [Field(9, 3, Align.LEFT)]
        public string C011_CustomerPlant { get; set; }

        [Field(10, 8, Align.LEFT)]
        public string C012_Consignment { get; set; }

        [Field(11, 9, Align.LEFT)]
        public string C013_GoodsReceiverId { get; set; }

        [Field(12, 1, Align.LEFT)]
        public string C014_Empty2 { get; set; }

        [Field(13, 7, Align.LEFT)]
        public string C015_CustomerStorageLocation { get; set; }

        [Field(14, 9, Align.LEFT)]
        public string C016_SupplierId { get; set; }

        [Field(15, 14, Align.LEFT)]
        public string C017_PointofAssembling { get; set; }

        [Field(16, 4, Align.LEFT)]
        public string C018_ReleaseNo { get; set; }

        [Field(17, 6, Align.LEFT)]
        public string C019_CustomerReference { get; set; }

        [Field(18, 14, Align.LEFT)]
        public string C020_CustomerReferenceNo { get; set; }

        [Field(19, 5, Align.LEFT)]
        public string C021_Empty3 { get; set; }


    }
}
