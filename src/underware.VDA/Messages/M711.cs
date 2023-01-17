using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using underware.VDA.Records.V03;

namespace underware.VDA.Messages
{
    public class M711 : Message
    {
        public override string MessageType => "4913";
        public override string Sender => AllRecords.OfType<R711>().First().SupplierID;
        public override string Receiver => AllRecords.OfType<R711>().First().CustomerID;

    }
}
