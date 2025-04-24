namespace underware.VDA.Records;

public interface IR715
{
    string C003_CustomerPackagingType { get; set; }
    string C004_SupplierPackagingType { get; set; }
    string C005_NumberOfPackaging { get; set; }
    string C006_DeliveryNoteItemNo { get; set; }
    string C007_FillingCapacity { get; set; }
    string C008_PackageUnitNoFROM { get; set; }
    string C009_PackageUnitNoTO { get; set; }
    string C010_PackagingDimensions { get; set; }
    string C011_StackingFactor { get; set; }
    string C012_WarehouseDeliveryScheduleNo { get; set; }
    string C013_LabelIndicator { get; set; }
    string C014_PackagingCode { get; set; }
    string C015_PropertyCode { get; set; }
    string C016_Empty { get; set; }
}