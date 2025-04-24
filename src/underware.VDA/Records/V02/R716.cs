namespace underware.VDA.Records.V02
{
    [Parent(typeof(IR714))]
    public class R716: Record, IR716
    {
        public R716(string line) : base(line)
        {
        }

        public R716() : base()
        {
            Name = "716";
            Version = "02";
        }

        [Field(1, 40, Align.LEFT)]
        public string Text1 { get; set; }  
        
        [Field(2, 40, Align.LEFT)]
        public string Text2 { get; set; }
        
        [Field(3, 40, Align.LEFT)]
        public string Text3 { get; set; }
        
        [Field(4, 3, Align.LEFT)]
        public string Empty { get; set; }
        
    }
}