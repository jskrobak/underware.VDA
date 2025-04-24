namespace underware.VDA.Records;

interface IR712
{
    string C003_ShipmentLoadReferenceNo { get; set; }
    string C004_PlantSupplier { get; set; }
    string C005_Carrier { get; set; }
    string C006_CarrierTransferDate { get; set; }
    string C007_CarrierTransferTime { get; set; }
    string C008_GrossShipmentWeight { get; set; }
    string C009_NetShipmentWeight { get; set; }
    string C010_PrepaymentOfChangesKey { get; set; }
    string C011_CarrierTransmissionKey { get; set; }
    string C012_NoOfPackages { get; set; }
    string C013_TransportPartnerId { get; set; }
    string C014_KeyToMeansOfTransport { get; set; }
    string C015_MeansOfTransportNo { get; set; }
    string C016_CodeForItem { get; set; }
    string C017_Content { get; set; }
    string C018_TargetArrivalDate { get; set; }
    string C019_TargetArrivalTime { get; set; }
    string C020_LoadMetre { get; set; }
    string C021_LorryTypeCode { get; set; }
    string C022_Empty { get; set; }
}