using System;

namespace underware.VDA;

public interface IInterchangeHeaderRecord
{
    string Sender { get; set; }
    string Receiver { get; }
    string RefNumber { get; }
    string MessageName { get; }
    Type MessageType { get; }
}