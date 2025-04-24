using System.Linq;
using underware.Edi.Common.DocumentModel;
using underware.VDA.Records;
using underware.VDA.Records.V03;

namespace underware.VDA.Messages;

public class M4905(Interchange interchange): Message(interchange)
{
    public override BaseDocument GetDocument()
    {
        var r511 = (IR511)Interchange.Header;
        var r512 = AllRecords.OfType<IR512>().First();
        var r513 = AllRecords.OfType<IR513>().First();
        
        var vdaDeliveries = ((Record)r513).GetDeliveries();

        var callOff = new CallOff()
        {
            Data = this,
            CustomerNumber = r511.C003_CustomerID,
            SupplierNumber = r511.C004_SupplierID,
            TransmissionNumberOld = r511.C005_OldTransmissionNo,
            TransmissionNumberNew = r511.C006_NewTransmissionNo,
            TransmissionDate = r511.C007_TransmissionDate.ParseDate(),
            CustomerPlant = r512.C003_PlantCustomer,
            PlaceOfDischarge = r512.C011_PointOfUnloading,
            PlaceOfDelivery = r512.C011_PointOfUnloading,
            CallOffNumberNew = r512.C004_DeliveryCallOffNumberNew,
            CallOffNumberOld = r512.C006_DeliveryCallOffNumberOld,
            CallOffDateNew = r512.C005_DeliveryCallOffDateNew.ParseDate(),
            CallOffDateOld = r512.C007_DeliveryCallOffDateOld.ParseDate(),
            CustomerReference = r512.C012_CustomerRef,
            ContractOrOrderNumber = r512.C010_ContractOrOrderNumber,
            BackorderQty = vdaDeliveries.FirstOrDefault(d => d.Date == "333333")?.Quantity.ParseDecimal() ?? 0,
            ImmediateNeedQty = vdaDeliveries.FirstOrDefault(d => d.Date == "444444")?.Quantity.ParseDecimal() ?? 0,
            PartNumberCustomer = r512.C008_PartNumberCustomer,
            PartNumberSupplier = r512.C009_PartNumberSupplier,
            LastReceiptQty = r513.C006_QuantityLastReceipt.ParseDecimal(),
            LastReceivedDeliveryNoteDate = r513.C005_DeliveryNoteDateLastReceipt.TryParseDate(),
            LastReceivedDeliveryNoteNo = r513.C004_DeliveryNoteNumberLastReceipt,
            Deliveries = vdaDeliveries.Where(d => d.Date.IsDate()).Select(d => new CallOffDelivery()
            {
                Date = d.Date.ParseDate(),
                Qty = d.Quantity.ParseDecimal()
            }).ToList()
        };

        foreach (var r514 in ((Record)r513).Subrecords.OfType<IR514>())
        {
            var deliveries = ((Record)r514).GetDeliveries().Where(d => d.Date.IsDate());
            var list = deliveries.Select(d => new CallOffDelivery()
            {
                Date = d.Date.ParseDate(),
                Qty = d.Quantity.ParseDecimal()
            });
            
            callOff.Deliveries.AddRange(list);
        }
        
        return callOff;

    }
    
    
}