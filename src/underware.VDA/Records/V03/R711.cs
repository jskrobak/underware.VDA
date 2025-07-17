using System;
using System.Collections.Generic;
using System.Text;
using underware.VDA.Messages;

namespace underware.VDA.Records.V03
{
    public class R711: Record, IR711
    {
        public R711(string line) : base(line)
        {
        }

        public R711() : base()
        {
            Name = "711";
            Version = "03";
        }


        [Field(3, 9, Align.LEFT)]
        public string C003_CustomerID { get; set; }

        [Field(4, 9, Align.LEFT)]
        public string C004_SupplierID { get; set; }

        [Field(5, 5, Align.LEFT)]
        public string C005_OldTransmissionNo { get; set; }

        [Field(6, 5, Align.LEFT)]
        public string C006_NewTransmissionNo { get; set; }

        [Field(7, 6, Align.LEFT)]
        public string C007_TransmissionDate { get; set; }

        [Field(8, 9, Align.LEFT)]
        public string C008_SubSupplierNo { get; set; }

        [Field(9, 9, Align.LEFT)]
        public string C009_CarrierID { get; set; }

        [Field(10, 1, Align.LEFT)]
        public string C010_KeyToStocklist { get; set; }

        [Field(11, 1, Align.LEFT)]
        public string C011_DeliveryCode { get; set; }

        [Field(12, 69, Align.LEFT)]
        public string C012_Empty { get; set; }


        public string Sender
        {
            get => C004_SupplierID;
            set => C004_SupplierID = value;
        }
        public string Receiver
        {
            get => C003_CustomerID;
            set => C003_CustomerID = value;
        }
        
        public string RefNumber => C006_NewTransmissionNo;
        public string MessageName => "4913";
        public Type MessageType => typeof(M4913);
        public string TransmissionDate => C007_TransmissionDate;
    }
}
