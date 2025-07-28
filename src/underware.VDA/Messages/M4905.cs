using System;
using System.Linq;
using underware.Edi.Common;
using underware.Edi.Common.DocumentModel;
using underware.VDA.Models;
using underware.VDA.Records;
using underware.VDA.Records.V03;

namespace underware.VDA.Messages;

public class M4905(Interchange interchange): Message(interchange), IDeliveryPlace, IUnloadingPoint
{
    public override BaseDocument GetDocument()
    {
        var r511 = (IR511)Interchange.Header;
        
        
        var forecast = new DeliveryForecast()
        {
            BillNo = r511.C006_NewTransmissionNo,// r512.C004_DeliveryCallOffNumberNew,
            Customer = new Party(){GLN = r511.C003_CustomerID},
            Supplier = new Party(){GLN = r511.C004_SupplierID},
            //DeliveryPlace = new Party() {GLN = r512.C003_PlantCustomer},
            IssueDate = r511.C007_TransmissionDate.ParseDate(),
        };

        foreach (var r512 in AllRecords.OfType<IR512>())
        {
            var r513 = ((Record)r512).Subrecords.OfType<IR513>().First();
            var vdaDeliveries = ((Record)r513).GetDeliveries();
            
            var item= new DeliveryForecastItem
            {
                BackorderQty = vdaDeliveries.FirstOrDefault(d => d.Date == "333333")?.Quantity.ParseDecimal() ?? 0,
                ImmediateNeedQty = vdaDeliveries.FirstOrDefault(d => d.Date == "444444")?.Quantity.ParseDecimal() ?? 0,
                 OrderNo = r512.C010_ContractOrOrderNumber,
                 PartNumber = r512.C008_PartNumberCustomer,
                 PlaceOfDelivery = r512.C011_PointOfUnloading,
                 PlaceOfDischarge = r512.C019_Store,
                 DeliveryScheduleNumberNew = r512.C004_DeliveryCallOffNumberNew,
                 DeliveryScheduleNumberOld = r512.C006_DeliveryCallOffNumberOld,
                 DeliveryScheduleDateNew = r512.C005_DeliveryCallOffDateNew.ParseDate(),
                 DeliveryScheduleDateOld = r512.C007_DeliveryCallOffDateOld.ParseDate(),
                 //CumulativeQtyReceived = r513.
                 LastReceivedDeliveryNoteNo = r513.C004_DeliveryNoteNumberLastReceipt,
                 LastReceivedDeliveryNoteDate = r513.C005_DeliveryNoteDateLastReceipt.ParseDate(),
                 LastReceivedQty = r513.C006_QuantityLastReceipt.ParseDecimal(),
                //MostRecentArrivalOfGoods = r512.
            };
            
            foreach (var r514 in ((Record)r513).Subrecords.OfType<IR514>())
            {
               vdaDeliveries.AddRange(((Record)r514).GetDeliveries().ToList());
            }

            var intervalType = IntervalType.Day;
            foreach (var dq in vdaDeliveries)
            {
                var meaning = dq.GetSpecialMeaning();

                if (meaning == SpecialDateMeaning.SwitchToWeeklyMonthly)
                {
                    intervalType++;
                    continue;
                }
                
                if(meaning != SpecialDateMeaning.None)
                {
                    item.Deliveries.Add(new Delivery
                    {
                        Date = DateTime.MinValue,
                        Qty = dq.Quantity.ParseDecimal(),
                        SpecialMeaning = meaning
                    } );
                    continue;
                }
                    
                
                switch (intervalType)
                {
                    case IntervalType.Day:
                        item.Deliveries.Add(new Delivery()
                        {
                            Interval = intervalType,
                            Date = dq.Date.ParseDate(),
                            Qty = dq.Quantity.ParseDecimal()
                        });
                        break;
                    case IntervalType.Week:
                    {
                        var year = int.Parse(dq.Date[..2]);
                        var weekNumber = int.Parse(dq.Date.Substring(4, 2));
                    
                        item.Deliveries.Add(new Delivery()
                        {
                            Interval = intervalType,
                            Year = year,
                            IntervalNumber = weekNumber,
                            Date = Delivery.GetFirstDayOfWeek(year, weekNumber),
                            Qty = dq.Quantity.ParseDecimal()
                        });
                        break;
                    }
                    case IntervalType.Month:
                    {
                        var year = int.Parse(dq.Date[..2]);
                        var month = int.Parse(dq.Date.Substring(2, 2));
                    
                        item.Deliveries.Add(new Delivery()
                        {
                            Interval = intervalType,
                            Year = year,
                            IntervalNumber = month,
                            Date = new DateTime(year, month, 1),
                            Qty = dq.Quantity.ParseDecimal()
                        });
                        break;
                    }
                    case IntervalType.None:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            forecast.Items.Add(item);
        }
        
        return forecast;
    }

    public BaseDocument XGetDocument()
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
            Deliveries = vdaDeliveries.Where(d => d.Date.IsDate()).Select(d => new Delivery()
            {
                Date = d.Date.ParseDate(),
                Qty = d.Quantity.ParseDecimal()
            }).ToList()
        };

        foreach (var r514 in ((Record)r513).Subrecords.OfType<IR514>())
        {
            var deliveries = ((Record)r514).GetDeliveries().Where(d => d.Date.IsDate());
            var list = deliveries.Select(d => new Delivery()
            {
                Date = d.Date.ParseDate(),
                Qty = d.Quantity.ParseDecimal()
            });
            
            callOff.Deliveries.AddRange(list);
        }
        
        return callOff;

    }

    public string DeliveryPlaceId => AllRecords.OfType<IR512>().FirstOrDefault()?.C003_PlantCustomer;
    
    public string UnloadingPointId => AllRecords.OfType<IR512>().FirstOrDefault()?.C011_PointOfUnloading;
}