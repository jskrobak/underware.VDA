namespace underware.VDA.Records.V03
{
    public class R715: Record
    {
        public R715(string line) : base(line)
        {
        }

        public R715() : base()
        {
            Name = "715";
            Version = "03";
        }

        [RecordInfo(1, 22, Align.LEFT)]
        public string C003_CustomerPackagingType { get; set; }
        
        [RecordInfo(2, 22, Align.LEFT)]
        public string C004SupplierPackagingType { get; set; }
        
        [RecordInfo(3, 13, Align.LEFT)]
        public string C005_NumberOfPackaging { get; set; }
        
        [RecordInfo(5, 3, Align.LEFT)]
        public string C006_DeliveryNoteItemNo { get; set; }
        
        [RecordInfo(6, 13, Align.LEFT)]
        public string C007_FillingCapacity { get; set; }
        
        [RecordInfo(7, 9, Align.LEFT)]
        public string C008_PackageUnitNoFROM { get; set; }
        
        [RecordInfo(8, 9, Align.LEFT)]
        public string C009__PackageUnitNoTO { get; set; }
        
        [RecordInfo(9, 12, Align.LEFT)]
        public string C010_PackagingDimensions { get; set; }
        
        [RecordInfo(10, 1, Align.LEFT)]
        public string C011_StackingFactor { get; set; }
        
        [RecordInfo(11, 15, Align.LEFT)]
        public string C012_WarehouseDeliveryScheduleNo { get; set; }
        
        [RecordInfo(12, 1, Align.LEFT)]
        public string C013_LabelIndicator { get; set; }
        
        [RecordInfo(13, 1, Align.LEFT)]
        public string C014_PackagingCode { get; set; }
        
        [RecordInfo(14, 1, Align.LEFT)]
        public string C015_PropertyCode { get; set; }
        
        [RecordInfo(15, 1, Align.LEFT)]
        public string C016_Empty { get; set; }
        
    }
}