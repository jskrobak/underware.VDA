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
        public string C003_ShipmentLoadReferenceNo { get; set; }
        
        [RecordInfo(4, 3, Align.LEFT)]
        public string C004_PlantSupplier { get; set; }
        
        [RecordInfo(5, 14, Align.LEFT)]
        public string C005_Carrier { get; set; }
        
        [RecordInfo(6, 6, Align.LEFT)]
        public string C006_CarrierTransferDate { get; set; }
        
        [RecordInfo(7, 4, Align.LEFT)]
        public string C007_CarrierTransferTime { get; set; }
        
        [RecordInfo(8, 7, Align.LEFT)]
        public string C008_GrossShipmentWeight { get; set; }
        
        [RecordInfo(9, 7, Align.LEFT)]
        public string C009_NetShipmentWeight { get; set; }
        
        [RecordInfo(10, 2, Align.LEFT)]
        public string C010_PrepaymentOfChangesKey { get; set; }
        
        [RecordInfo(11, 1, Align.LEFT)]
        public string C011_CarrierTransmissionKey { get; set; }
        
        [RecordInfo(12, 4, Align.LEFT)]
        public string C012_NoOfPackages { get; set; }
        
        [RecordInfo(13, 14, Align.LEFT)]
        public string C013_TransportPartnerId { get; set; }
        
        [RecordInfo(14, 2, Align.LEFT)]
        public string C014_KeyToMeansOfTransport { get; set; }
        
        [RecordInfo(15, 25, Align.LEFT)]
        public string C015_MeansOfTransportNo { get; set; }
        
        [RecordInfo(16, 1, Align.LEFT)]
        public string C016_CodeForItem { get; set; }

        [RecordInfo(17, 8, Align.LEFT)]
        public string C017_Content { get; set; }

        [RecordInfo(18, 6, Align.LEFT)]
        public string C018_TargetArrivalDate { get; set; }

        [RecordInfo(19, 4, Align.LEFT)]
        public string C019_TargetArrivalTime { get; set; }

        [RecordInfo(20, 3, Align.LEFT)]
        public string C020_LoadMetre { get; set; }

        [RecordInfo(21, 1, Align.LEFT)]
        public string C021_LorryTypeCode { get; set; }

        [RecordInfo(22, 3, Align.LEFT)]
        public string C022_Empty { get; set; }

    }
}
