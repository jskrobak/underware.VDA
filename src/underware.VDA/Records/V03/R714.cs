using System;
using System.Collections.Generic;
using System.Text;

namespace underware.VDA.Records.V03
{
    public class R714 : Record
    {
        public R714(string line) : base(line)
        {
        }

        public R714() : base()
        {
            Name = "714";
            Version = "03";
        }

        [RecordInfo(1, 22, Align.LEFT)]
        public string CustomerReferenceNo { get; set; }

        [RecordInfo(2, 22, Align.LEFT)]
        public string SupplierReferenceNo { get; set; }

        [RecordInfo(3, 3, Align.LEFT)]
        public string CountryOfOrigin { get; set; }

        [RecordInfo(4, 13, Align.LEFT)]
        public string DeliveryQty1 { get; set; }

        [RecordInfo(5, 2, Align.LEFT)]
        public string UnitOfQty1 { get; set; }

        [RecordInfo(6, 13, Align.LEFT)]
        public string DeliveryQty2 { get; set; }

        [RecordInfo(7, 2, Align.LEFT)]
        public string UnitOfQty2 { get; set; }

        [RecordInfo(8, 3, Align.LEFT)]
        public string VATRate { get; set; }

        [RecordInfo(9, 1, Align.LEFT)]
        public string Empty1 { get; set; }

        [RecordInfo(10, 3, Align.LEFT)]
        public string DeliveryNoteItemNo { get; set; }

        [RecordInfo(11, 1, Align.LEFT)]
        public string ReleaseKey { get; set; }

        [RecordInfo(12, 15, Align.LEFT)]
        public string BatchNo { get; set; }

        [RecordInfo(13, 1, Align.LEFT)]
        public string CodeUsage { get; set; }

        [RecordInfo(14, 8, Align.LEFT)]
        public string DangerousGoodsCode { get; set; }

        [RecordInfo(15, 1, Align.LEFT)]
        public string PreferenceStatus { get; set; }

        [RecordInfo(16, 1, Align.LEFT)]
        public string DutiableGoods { get; set; }

        [RecordInfo(17, 1, Align.LEFT)]
        public string Empty2 { get; set; }

        [RecordInfo(18, 2, Align.LEFT)]
        public string InventoryStatus { get; set; }

        [RecordInfo(19, 8, Align.LEFT)]
        public string OriginalDeliveryNoteNo { get; set; }

    }
}
