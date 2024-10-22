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
        public string C003_CustomerReferenceNo { get; set; }

        [RecordInfo(2, 22, Align.LEFT)]
        public string C004_SupplierReferenceNo { get; set; }

        [RecordInfo(3, 3, Align.LEFT)]
        public string C005_CountryOfOrigin { get; set; }

        [RecordInfo(4, 13, Align.LEFT)]
        public string C006_DeliveryQty1 { get; set; }

        [RecordInfo(5, 2, Align.LEFT)]
        public string C007_UnitOfQty1 { get; set; }

        [RecordInfo(6, 13, Align.LEFT)]
        public string C008_DeliveryQty2 { get; set; }

        [RecordInfo(7, 2, Align.LEFT)]
        public string C009_UnitOfQty2 { get; set; }

        [RecordInfo(8, 3, Align.LEFT)]
        public string C010_VATRate { get; set; }

        [RecordInfo(9, 1, Align.LEFT)]
        public string C011_Empty1 { get; set; }

        [RecordInfo(10, 3, Align.LEFT)]
        public string C012_DeliveryNoteItemNo { get; set; }

        [RecordInfo(11, 1, Align.LEFT)]
        public string C013_ReleaseKey { get; set; }

        [RecordInfo(12, 15, Align.LEFT)]
        public string C014_BatchNo { get; set; }

        [RecordInfo(13, 1, Align.LEFT)]
        public string C015_CodeUsage { get; set; }

        [RecordInfo(14, 8, Align.LEFT)]
        public string C016_DangerousGoodsCode { get; set; }

        [RecordInfo(15, 1, Align.LEFT)]
        public string C017_PreferenceStatus { get; set; }

        [RecordInfo(16, 1, Align.LEFT)]
        public string C018_DutiableGoods { get; set; }

        [RecordInfo(17, 1, Align.LEFT)]
        public string C019_Empty2 { get; set; }

        [RecordInfo(18, 1, Align.LEFT)]
        public string C020_InventoryStatus { get; set; }
        
        [RecordInfo(19, 2, Align.LEFT)]
        public string C021_ModifiedVersionCodes { get; set; }
        
        [RecordInfo(20, 8, Align.LEFT)]
        public string C022_OriginalDeliveryNoteNo { get; set; }

    }
}
