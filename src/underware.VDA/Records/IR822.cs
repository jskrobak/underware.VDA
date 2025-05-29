namespace underware.VDA.Records;

public interface IR822
{
    string C003_BillNo { get; set; }
    string C004_IssueDate { get; set; }
    string C005_DueDate { get; set; }
    string C006_Surcharges { get; set; }
    string C007_SignCode { get; set; }
    string C008_TotalCacheDiscountAmount { get; set; }
    string C009_TotalVATAmount { get; set; }
    string C010_TotalAmount { get; set; }
    string C011_SignCode { get; set; }
    string C012_Currency { get; set; }
    string C013_ConsignmentId { get; set; }
    string C014_InvoiceCode { get; set; }
    string C015_CountryCode { get; set; }
    string C016_CreditorBookingNo { get; set; }
}