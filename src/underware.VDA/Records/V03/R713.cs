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
        public string DeliveryNoteNo { get; set; }

        [RecordInfo(2, 6, Align.LEFT)]
        public string DespatchDate { get; set; }

        [RecordInfo(3, 5, Align.LEFT)]
        public string UnloadingPoint { get; set; }

        [RecordInfo(4, 2, Align.LEFT)]
        public string DespatchType { get; set; }

        [RecordInfo(5, 4, Align.LEFT)]
        public string CustomerReferenceNoLAB { get; set; }

        [RecordInfo(6, 12, Align.LEFT)]
        public string ContractOrderNo { get; set; }

        [RecordInfo(7, 2, Align.LEFT)]
        public string ProcessCode { get; set; }

        [RecordInfo(8, 4, Align.LEFT)]
        public string Empty { get; set; }

        [RecordInfo(9, 3, Align.LEFT)]
        public string CustomerPlant { get; set; }

        [RecordInfo(10, 8, Align.LEFT)]
        public string Consignment { get; set; }

        [RecordInfo(11, 9, Align.LEFT)]
        public string GoodsReceiverId { get; set; }

        [RecordInfo(12, 1, Align.LEFT)]
        public string Empty2 { get; set; }

        [RecordInfo(13, 7, Align.LEFT)]
        public string CustomerStorageLocation { get; set; }

        [RecordInfo(14, 9, Align.LEFT)]
        public string SupplierId { get; set; }

        [RecordInfo(15, 14, Align.LEFT)]
        public string PointofAssembling { get; set; }

        [RecordInfo(16, 4, Align.LEFT)]
        public string ReleaseNo { get; set; }

        [RecordInfo(17, 6, Align.LEFT)]
        public string CustomerReference { get; set; }

        [RecordInfo(18, 14, Align.LEFT)]
        public string CustomerReferenceNo { get; set; }

        [RecordInfo(19, 5, Align.LEFT)]
        public string Empty3 { get; set; }


    }
}
