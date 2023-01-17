using System;
using System.Collections.Generic;
using System.Text;

namespace underware.VDA.Records.V03
{
    public class R712 : Record
    {
        public R712(string line) : base(line)
        {
        }

        public R712() : base()
        {
            Name = "712";
            Version = "03";
        }

        [RecordInfo(3, 8, Align.LEFT)]
        public string ShipmentLoadReferenceNo { get; set; }
        
        [RecordInfo(4, 3, Align.LEFT)]
        public string PlantSupplier { get; set; }
        
        [RecordInfo(5, 14, Align.LEFT)]
        public string Carrier { get; set; }
        
        [RecordInfo(6, 6, Align.LEFT)]
        public string CarrierTransferDate { get; set; }
        
        [RecordInfo(7, 4, Align.LEFT)]
        public string CarrierTransferTime { get; set; }
        
        [RecordInfo(8, 7, Align.LEFT)]
        public string GrossShipmentWeight { get; set; }
        
        [RecordInfo(9, 7, Align.LEFT)]
        public string NetShipmentWeight { get; set; }
        
        [RecordInfo(10, 2, Align.LEFT)]
        public string PrepaymentOfChangesKey { get; set; }
        
        [RecordInfo(11, 1, Align.LEFT)]
        public string CarrierTransmissionKey { get; set; }
        
        [RecordInfo(12, 4, Align.LEFT)]
        public string NoOfPackages { get; set; }
        
        [RecordInfo(13, 14, Align.LEFT)]
        public string TransportPartnerId { get; set; }
        
        [RecordInfo(14, 2, Align.LEFT)]
        public string KeyToMeansOfTransport { get; set; }
        
        [RecordInfo(15, 25, Align.LEFT)]
        public string MeansOfTransportNo { get; set; }
        
        [RecordInfo(16, 1, Align.LEFT)]
        public string CodeForItem { get; set; }

        [RecordInfo(17, 8, Align.LEFT)]
        public string Content { get; set; }

        [RecordInfo(18, 6, Align.LEFT)]
        public string TargetArrivalDate { get; set; }

        [RecordInfo(19, 4, Align.LEFT)]
        public string TargetArrivalTime { get; set; }

        [RecordInfo(20, 3, Align.LEFT)]
        public string LoadMetre { get; set; }

        [RecordInfo(21, 1, Align.LEFT)]
        public string LorryTypeCode { get; set; }

        [RecordInfo(22, 3, Align.LEFT)]
        public string Empty { get; set; }

    }
}
