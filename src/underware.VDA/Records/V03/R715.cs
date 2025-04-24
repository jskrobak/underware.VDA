namespace underware.VDA.Records.V03
{
    [Parent(typeof(IR714))]
    public class R715: Record, IR715
    {
        public R715(string line) : base(line)
        {
        }

        public R715() : base()
        {
            Name = "715";
            Version = "03";
        }

        [Field(1, 22, Align.LEFT)]
        public string C003_CustomerPackagingType { get; set; }

        [Field(2, 22, Align.LEFT)]
        public string C004_SupplierPackagingType { get; set; }
        
        [Field(3, 13, Align.LEFT)]
        public string C005_NumberOfPackaging { get; set; }
        
        [Field(5, 3, Align.LEFT)]
        public string C006_DeliveryNoteItemNo { get; set; }
        
        [Field(6, 13, Align.LEFT)]
        public string C007_FillingCapacity { get; set; }
        
        [Field(7, 9, Align.LEFT)]
        public string C008_PackageUnitNoFROM { get; set; }
        
        [Field(8, 9, Align.LEFT)]
        public string C009_PackageUnitNoTO { get; set; }
        
        [Field(9, 12, Align.LEFT)]
        public string C010_PackagingDimensions { get; set; }
        
        [Field(10, 1, Align.LEFT)]
        public string C011_StackingFactor { get; set; }
        
        [Field(11, 15, Align.LEFT)]
        public string C012_WarehouseDeliveryScheduleNo { get; set; }
        
        [Field(12, 1, Align.LEFT)]
        public string C013_LabelIndicator { get; set; }
        
        [Field(13, 1, Align.LEFT)]
        public string C014_PackagingCode { get; set; }
        
        [Field(14, 1, Align.LEFT)]
        public string C015_PropertyCode { get; set; }
        
        [Field(15, 1, Align.LEFT)]
        public string C016_Empty { get; set; }
        
    }
}