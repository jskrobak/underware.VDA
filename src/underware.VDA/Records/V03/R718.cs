namespace underware.VDA.Records.V03
{
    [Parent(typeof(IR714))]
    public class R718: Record, IR718
    {
        public R718(string line) : base(line)
        {
        }

        public R718() : base()
        {
            Name = "715";
            Version = "03";
        }
        
    }
}