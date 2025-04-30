using System.Linq;
using underware.Edi.Common;
using underware.VDA.Records;

namespace underware.VDA.Messages;

public class M4915(Interchange interchange): Message(interchange), IDeliveryPlace
{
    public string UnloadingPoint => "";
    public string DeliveryPlaceId => AllRecords.OfType<IR552>().FirstOrDefault()?.C003_PlantCustomer;
    
}