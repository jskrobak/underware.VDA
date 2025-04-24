namespace underware.VDA.Records;

public interface IR511: IInterchangeHeaderRecord
{
    string C003_CustomerID { get; set; }
    string C004_SupplierID { get; set; }
    string C005_OldTransmissionNo { get; set; }
    string C006_NewTransmissionNo { get; set; }
    string C007_TransmissionDate { get; set; }
    string C008_DateSetToZeroNumber { get; set; }
    string C009_Empty { get; set; }
}