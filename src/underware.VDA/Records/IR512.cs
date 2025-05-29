namespace underware.VDA.Records;

public interface IR512
{
    string C003_PlantCustomer { get; set; }

    string C004_DeliveryCallOffNumberNew { get; set; }

    string C005_DeliveryCallOffDateNew { get; set; }

    string C006_DeliveryCallOffNumberOld { get; set; }

    string C007_DeliveryCallOffDateOld { get; set; }

    string C008_PartNumberCustomer { get; set; }

    string C009_PartNumberSupplier { get; set; }

    string C010_ContractOrOrderNumber { get; set; }

    string C011_PointOfUnloading { get; set; }

    string C012_CustomerRef { get; set; }

    string C013_UnitOfQuantity { get; set; }

    string C014_DeliveryInterval { get; set; }

    string C015_ManufacturingRelease { get; set; }

    string C016_MaterialRelease { get; set; }

    string C017_UsingCode { get; set; }

    string C018_AccountingCode { get; set; }

    string C019_Store { get; set; }

    string C022_Empty { get; set; }
}