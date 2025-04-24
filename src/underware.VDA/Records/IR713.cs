namespace underware.VDA.Records;

public interface IR713: IParent
{
    string C003_DeliveryNoteNo { get; set; }
    string C004_DespatchDate { get; set; }
    string C005_UnloadingPoint { get; set; }
    string C006_DespatchType { get; set; }
    string C007_CustomerReferenceNoLAB { get; set; }
    string C008_ContractOrderNo { get; set; }
    string C009_ProcessCode { get; set; }
    string C010_Empty { get; set; }
    string C011_CustomerPlant { get; set; }
    string C012_Consignment { get; set; }
    string C013_GoodsReceiverId { get; set; }
    string C014_Empty2 { get; set; }
    string C015_CustomerStorageLocation { get; set; }
    string C016_SupplierId { get; set; }
    string C017_PointofAssembling { get; set; }
    string C018_ReleaseNo { get; set; }
    string C019_CustomerReference { get; set; }
    string C020_CustomerReferenceNo { get; set; }
    string C021_Empty3 { get; set; }
}