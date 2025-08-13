using System;
using System.Collections.Generic;
using underware.Edi.Common;

namespace underware.VDA;

public interface IInterchangeHeaderRecord
{
    string Sender { get; set; }
    string Receiver { get; set; }
    string RefNumber { get; }
    string MessageName { get; }
    Type MessageType { get; }
    string TransmissionDate { get; }
}