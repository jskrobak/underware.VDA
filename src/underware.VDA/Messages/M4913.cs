using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using underware.Edi.Common;
using underware.Edi.Common.DocumentModel;
using underware.VDA.Records;
using underware.VDA.Records.V03;

namespace underware.VDA.Messages
{
    public class M4913(Interchange interchange): Message(interchange), IDeliveryPlace, IUnloadingPoint
    {
        public override BaseDocument GetDocument()
        {
            var r712 = AllRecords.OfType<IR712>().First();
            var r713 = AllRecords.OfType<IR713>().First();
            var a13 = AllRecords.OfType<IRA13>().FirstOrDefault();
            
            //Interchange.Do
            var despatchAdvice = new DespatchAdvice()
            {
                BillNo = r713.C003_DeliveryNoteNo,
                DeliveryDate = $"{r712.C018_TargetArrivalDate}{r712.C019_TargetArrivalTime}".ParseDateTime(),
                IssueDate = $"{r712.C006_CarrierTransferDate}{r712.C007_CarrierTransferTime}".ParseDateTime(),
                DispatchDate = $"{r712.C006_CarrierTransferDate}{r712.C007_CarrierTransferTime}".ParseDateTime(),
                WeightUnit = "KGM",
                GrossWeight = r712.C008_GrossShipmentWeight.ParseDecimal(), 
                AgreementNumber = a13?.C003_AgreementNumber,
                Plant = r713.C011_CustomerPlant,
                UnloadingPoint = r713.C005_UnloadingPoint,
                MeansOfTransportNo = r712.C015_MeansOfTransportNo,
            };
              
            return despatchAdvice;

        }

        public string DeliveryPlaceId => AllRecords.OfType<IR713>().FirstOrDefault()?.C011_CustomerPlant;
        public string UnloadingPointId => AllRecords.OfType<IR713>().FirstOrDefault()?.C005_UnloadingPoint;
        
    }
}
