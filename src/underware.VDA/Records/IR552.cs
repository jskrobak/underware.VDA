namespace underware.VDA.Records;

public interface IR552
{
    string C003_PlantCustomer { get; set; }

    string C004_DeliveryCallOffNumber { get; set; }

    string C005_DeliveryCallOffDate { get; set; }

    string C006_PartNumberCustomer { get; set; }

    string C007_PartNumberSupplier { get; set; }

    string C008_ReceivingLocation { get; set; }

    string C009_CustomerStorageLocation { get; set; }

    string C010_CriticalPartIndicator { get; set; }

    string C011_RequirementIndicator { get; set; }

    string C012_DCIHorizon { get; set; }

    string C013_ReceivingOrShippingIndicator { get; set; }

    string C014_OrderNumber { get; set; }

    string C015_Overdelivery { get; set; }
    
}