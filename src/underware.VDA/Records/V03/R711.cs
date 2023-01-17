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
        public string CustomerID { get; set; }

        [RecordInfo(4, 9, Align.LEFT)]
        public string SupplierID { get; set; }

        [RecordInfo(5, 5, Align.LEFT)]
        public string OldTransmissionNo { get; set; }

        [RecordInfo(6, 5, Align.LEFT)]
        public string NewTransmissionNo { get; set; }

        [RecordInfo(7, 6, Align.LEFT)]
        public string TransmissionDate { get; set; }

        [RecordInfo(8, 9, Align.LEFT)]
        public string SubSupplierNo { get; set; }

        [RecordInfo(9, 9, Align.LEFT)]
        public string CarrierID { get; set; }

        [RecordInfo(10, 1, Align.LEFT)]
        public string KeyToStocklist { get; set; }

        [RecordInfo(11, 1, Align.LEFT)]
        public string DeliveryCode { get; set; }

        [RecordInfo(12, 69, Align.LEFT)]
        public string Empty { get; set; }

        
    }
}
