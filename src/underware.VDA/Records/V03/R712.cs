using System;
using System.Collections.Generic;
using System.Text;
using underware.VDA.Messages;

namespace underware.VDA.Records.V03
{
    [Parent(typeof(M4913))]
    public class R712 : Record, IR712
    {
        public R712(string line) : base(line)
        {
        }

        public R712() : base()
        {
            Name = "712";
            Version = "03";
        }

        [Field(3, 8, Align.LEFT)]
        public string C003_ShipmentLoadReferenceNo { get; set; }
        
        [Field(4, 3, Align.LEFT)]
        public string C004_PlantSupplier { get; set; }
        
        [Field(5, 14, Align.LEFT)]
        public string C005_Carrier { get; set; }
        
        [Field(6, 6, Align.LEFT)]
        public string C006_CarrierTransferDate { get; set; }
        
        [Field(7, 4, Align.LEFT)]
        public string C007_CarrierTransferTime { get; set; }
        
        [Field(8, 7, Align.LEFT)]
        public string C008_GrossShipmentWeight { get; set; }
        
        [Field(9, 7, Align.LEFT)]
        public string C009_NetShipmentWeight { get; set; }
        
        [Field(10, 2, Align.LEFT)]
        public string C010_PrepaymentOfChangesKey { get; set; }
        
        [Field(11, 1, Align.LEFT)]
        public string C011_CarrierTransmissionKey { get; set; }
        
        [Field(12, 4, Align.LEFT)]
        public string C012_NoOfPackages { get; set; }
        
        [Field(13, 14, Align.LEFT)]
        public string C013_TransportPartnerId { get; set; }
        
        [Field(14, 2, Align.LEFT)]
        public string C014_KeyToMeansOfTransport { get; set; }
        
        [Field(15, 25, Align.LEFT)]
        public string C015_MeansOfTransportNo { get; set; }
        
        [Field(16, 1, Align.LEFT)]
        public string C016_CodeForItem { get; set; }

        [Field(17, 8, Align.LEFT)]
        public string C017_Content { get; set; }

        [Field(18, 6, Align.LEFT)]
        public string C018_TargetArrivalDate { get; set; }

        [Field(19, 4, Align.LEFT)]
        public string C019_TargetArrivalTime { get; set; }

        [Field(20, 3, Align.LEFT)]
        public string C020_LoadMetre { get; set; }

        [Field(21, 1, Align.LEFT)]
        public string C021_LorryTypeCode { get; set; }

        [Field(22, 3, Align.LEFT)]
        public string C022_Empty { get; set; }

    }
}
