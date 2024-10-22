using System;
using System.Collections.Generic;
using System.Text;

namespace underware.VDA.Records.V03
{
    public class R711: Record
    {
        public R711(string line) : base(line)
        {
        }

        public R711() : base()
        {
            Name = "711";
            Version = "03";
        }


        [RecordInfo(3, 9, Align.LEFT)]
        public string C003_CustomerID { get; set; }

        [RecordInfo(4, 9, Align.LEFT)]
        public string C004_SupplierID { get; set; }

        [RecordInfo(5, 5, Align.LEFT)]
        public string C005_OldTransmissionNo { get; set; }

        [RecordInfo(6, 5, Align.LEFT)]
        public string C006_NewTransmissionNo { get; set; }

        [RecordInfo(7, 6, Align.LEFT)]
        public string C007_TransmissionDate { get; set; }

        [RecordInfo(8, 9, Align.LEFT)]
        public string C008_SubSupplierNo { get; set; }

        [RecordInfo(9, 9, Align.LEFT)]
        public string C009_CarrierID { get; set; }

        [RecordInfo(10, 1, Align.LEFT)]
        public string C010_KeyToStocklist { get; set; }

        [RecordInfo(11, 1, Align.LEFT)]
        public string C011_DeliveryCode { get; set; }

        [RecordInfo(12, 69, Align.LEFT)]
        public string C012_Empty { get; set; }

        
    }
}
