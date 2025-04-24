namespace underware.VDA.Records;

interface IR711: IInterchangeHeaderRecord
{
    string C003_CustomerID { get; set; }
    string C004_SupplierID { get; set; }
    string C005_OldTransmissionNo { get; set; }
    string C006_NewTransmissionNo { get; set; }
    string C007_TransmissionDate { get; set; }
    string C008_SubSupplierNo { get; set; }
    string C009_CarrierID { get; set; }
    string C010_KeyToStocklist { get; set; }
    string C011_DeliveryCode { get; set; }
    string C012_Empty { get; set; }
}