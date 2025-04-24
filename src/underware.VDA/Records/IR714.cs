namespace underware.VDA.Records;

public interface IR714: IParent
{
    string C003_CustomerReferenceNo { get; set; }
    string C004_SupplierReferenceNo { get; set; }
    string C005_CountryOfOrigin { get; set; }
    string C006_DeliveryQty1 { get; set; }
    string C007_UnitOfQty1 { get; set; }
    string C008_DeliveryQty2 { get; set; }
    string C009_UnitOfQty2 { get; set; }
    string C010_VATRate { get; set; }
    string C011_Empty1 { get; set; }
    string C012_DeliveryNoteItemNo { get; set; }
    string C013_ReleaseKey { get; set; }
    string C014_BatchNo { get; set; }
    string C015_CodeUsage { get; set; }
    string C016_DangerousGoodsCode { get; set; }
    string C017_PreferenceStatus { get; set; }
    string C018_DutiableGoods { get; set; }
    string C019_Empty2 { get; set; }
    string C020_InventoryStatus { get; set; }
    string C021_ModifiedVersionCodes { get; set; }
    string C022_OriginalDeliveryNoteNo { get; set; }
}