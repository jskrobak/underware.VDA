namespace underware.VDA.Records;

public interface IR821: IInterchangeHeaderRecord
{
    string C003_CustomerID { get; set; }
    string C004_SupplierID { get; set; }
    string C005_OldTransmissionNo { get; set; }
    string C006_NewTransmissionNo { get; set; }
    string C007_TransmissionDate { get; set; }
    string C008_CustomersVATNo { get; set; }
    string C009_SuppliersVATNo { get; set; }
    string C010_SuppliersRegNo { get; set; }
}