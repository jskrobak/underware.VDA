using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using underware.VDA.Messages;

namespace underware.VDA.Records.V03
{
    [Parent(typeof(M4905))]
    public class R719 : Record, IR719
    {
        public R719(string line) : base(line)
        {
        }

        public R719() : base()
        {
            Name = "719";
            Version = "03";
        }

        [Field(1, 7, Align.RIGHT, '0')]
        public string RecordTypeCounter711 { get; set; }

        [Field(2, 7, Align.RIGHT, '0')]
        public string RecordTypeCounter712 { get; set; }

        [Field(3, 7, Align.RIGHT, '0')]
        public string RecordTypeCounter713 { get; set; }

        [Field(4, 7, Align.RIGHT, '0')]
        public string RecordTypeCounter714 { get; set; }

        [Field(5, 7, Align.RIGHT, '0')]
        public string RecordTypeCounter715 { get; set; }

        [Field(6, 7, Align.RIGHT, '0')]
        public string RecordTypeCounter716 { get; set; }

        [Field(7, 7, Align.RIGHT, '0')]
        public string RecordTypeCounter718 { get; set; }

        [Field(8, 7, Align.RIGHT, '0')]
        public string RecordTypeCounter719 { get; set; }

        [Field(9, 7, Align.RIGHT, '0')]
        public string RecordTypeCounter717 { get; set; }

        [Field(10, 60, Align.LEFT)]
        public string Empty { get; set; }

        public void Recalculate(Interchange interchange)
        {
            var allRecords = interchange.GetAllRecords();

            RecordTypeCounter711 = allRecords.Count(r => r.Name == "711").ToString();
            RecordTypeCounter712 = allRecords.Count(r => r.Name == "712").ToString();
            RecordTypeCounter713 = allRecords.Count(r => r.Name == "713").ToString();
            RecordTypeCounter714 = allRecords.Count(r => r.Name == "714").ToString();
            RecordTypeCounter715 = allRecords.Count(r => r.Name == "715").ToString();
            RecordTypeCounter716 = allRecords.Count(r => r.Name == "716").ToString();
            RecordTypeCounter718 = allRecords.Count(r => r.Name == "718").ToString();
            RecordTypeCounter719 = allRecords.Count(r => r.Name == "719").ToString();
            RecordTypeCounter717 = allRecords.Count(r => r.Name == "717").ToString();
        }
    }
}
