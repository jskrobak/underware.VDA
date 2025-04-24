using System;
using System.Collections.Generic;
using System.Text;
using underware.VDA.Messages;

namespace underware.VDA.Records.V03
{
    [Parent(typeof(M4913))]
    public class R714 : Record, IR714
    {
        public R714(string line) : base(line)
        {
        }

        public R714() : base()
        {
            Name = "714";
            Version = "03";
        }

        [Field(1, 22, Align.LEFT)]
        public string C003_CustomerReferenceNo { get; set; }

        [Field(2, 22, Align.LEFT)]
        public string C004_SupplierReferenceNo { get; set; }

        [Field(3, 3, Align.LEFT)]
        public string C005_CountryOfOrigin { get; set; }

        [Field(4, 13, Align.LEFT)]
        public string C006_DeliveryQty1 { get; set; }

        [Field(5, 2, Align.LEFT)]
        public string C007_UnitOfQty1 { get; set; }

        [Field(6, 13, Align.LEFT)]
        public string C008_DeliveryQty2 { get; set; }

        [Field(7, 2, Align.LEFT)]
        public string C009_UnitOfQty2 { get; set; }

        [Field(8, 3, Align.LEFT)]
        public string C010_VATRate { get; set; }

        [Field(9, 1, Align.LEFT)]
        public string C011_Empty1 { get; set; }

        [Field(10, 3, Align.LEFT)]
        public string C012_DeliveryNoteItemNo { get; set; }

        [Field(11, 1, Align.LEFT)]
        public string C013_ReleaseKey { get; set; }

        [Field(12, 15, Align.LEFT)]
        public string C014_BatchNo { get; set; }

        [Field(13, 1, Align.LEFT)]
        public string C015_CodeUsage { get; set; }

        [Field(14, 8, Align.LEFT)]
        public string C016_DangerousGoodsCode { get; set; }

        [Field(15, 1, Align.LEFT)]
        public string C017_PreferenceStatus { get; set; }

        [Field(16, 1, Align.LEFT)]
        public string C018_DutiableGoods { get; set; }

        [Field(17, 1, Align.LEFT)]
        public string C019_Empty2 { get; set; }

        [Field(18, 1, Align.LEFT)]
        public string C020_InventoryStatus { get; set; }
        
        [Field(19, 2, Align.LEFT)]
        public string C021_ModifiedVersionCodes { get; set; }
        
        [Field(20, 8, Align.LEFT)]
        public string C022_OriginalDeliveryNoteNo { get; set; }

    }
}
