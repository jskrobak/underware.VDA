using System;
using System.Collections.Generic;
using System.Text;

namespace underware.VDA.Records.V03
{
    public class R713 : Record
    {
        public R713(string line) : base(line)
        {
        }

        public R713() : base()
        {
            Name = "713";
            Version = "03";
        }

        [RecordInfo(1, 8, Align.LEFT)]
        public string C003_DeliveryNoteNo { get; set; }

        [RecordInfo(2, 6, Align.LEFT)]
        public string C004_DespatchDate { get; set; }

        [RecordInfo(3, 5, Align.LEFT)]
        public string C005_UnloadingPoint { get; set; }

        [RecordInfo(4, 2, Align.LEFT)]
        public string C006_DespatchType { get; set; }

        [RecordInfo(5, 4, Align.LEFT)]
        public string C007_CustomerReferenceNoLAB { get; set; }

        [RecordInfo(6, 12, Align.LEFT)]
        public string C008_ContractOrderNo { get; set; }

        [RecordInfo(7, 2, Align.LEFT)]
        public string C009_ProcessCode { get; set; }

        [RecordInfo(8, 4, Align.LEFT)]
        public string C010_Empty { get; set; }

        [RecordInfo(9, 3, Align.LEFT)]
        public string C011_CustomerPlant { get; set; }

        [RecordInfo(10, 8, Align.LEFT)]
        public string C012_Consignment { get; set; }

        [RecordInfo(11, 9, Align.LEFT)]
        public string C013_GoodsReceiverId { get; set; }

        [RecordInfo(12, 1, Align.LEFT)]
        public string C014_Empty2 { get; set; }

        [RecordInfo(13, 7, Align.LEFT)]
        public string C015_CustomerStorageLocation { get; set; }

        [RecordInfo(14, 9, Align.LEFT)]
        public string C016_SupplierId { get; set; }

        [RecordInfo(15, 14, Align.LEFT)]
        public string C017_PointofAssembling { get; set; }

        [RecordInfo(16, 4, Align.LEFT)]
        public string C018_ReleaseNo { get; set; }

        [RecordInfo(17, 6, Align.LEFT)]
        public string C019_CustomerReference { get; set; }

        [RecordInfo(18, 14, Align.LEFT)]
        public string C020_CustomerReferenceNo { get; set; }

        [RecordInfo(19, 5, Align.LEFT)]
        public string C021_Empty3 { get; set; }


    }
}
