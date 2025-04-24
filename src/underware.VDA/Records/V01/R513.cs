using System;
using System.Collections.Generic;
using System.Text;

namespace underware.VDA.Records.V01
{
    [Parent(typeof(IR512))]
    public class R513 : Record, IR513
    {
        public R513(string line) : base(line)
        {
        }

        public R513() : base()
        {
            Name = "513";
            Version = "01";
        }

        [Field(1, 6, Align.LEFT)]
        public string C003_DateOfRegistrationLastReceipt { get; set; }

        [Field(2, 8, Align.LEFT)]
        public string C004_DeliveryNoteNumberLastReceipt { get; set; }

        [Field(3, 6, Align.LEFT)]
        public string C005_DeliveryNoteDateLastReceipt { get; set; }

        [Field(4, 12, Align.LEFT)]
        public string C006_QuantityLastReceipt  { get; set; }

        [Field(5, 10, Align.LEFT)]
        public string C007_ReceiptProgressNumber { get; set; }
        
        [Field(6, 6, Align.LEFT)]
        public string C008_CallOffDate1 { get; set; }

        [Field(7, 9, Align.LEFT)]
        public string C009_CallOffQty1 { get; set; }
        
        [Field(8, 6, Align.LEFT)]
        public string C010_CallOffDate2 { get; set; }

        [Field(9, 9, Align.LEFT)]
        public string C011_CallOffQty2{ get; set; }
        [Field(10, 6, Align.LEFT)]
        public string C012_CallOffDate3 { get; set; }

        [Field(11, 9, Align.LEFT)]
        public string C013_CallOffQty3{ get; set; }
        [Field(12, 6, Align.LEFT)]
        public string C014_CallOffDate4 { get; set; }

        [Field(13, 9, Align.LEFT)]
        public string C015_CallOffQty4 { get; set; }
        [Field(14, 6, Align.LEFT)]
        public string C016_CallOffDate5 { get; set; }

        [Field(15, 9, Align.LEFT)]
        public string C017_CallOffQty5 { get; set; }

        [Field(16, 6, Align.LEFT)]
        public string C018_Empty { get; set; }


    }
}
