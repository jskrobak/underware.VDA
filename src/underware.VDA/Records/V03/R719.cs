using System;
using System.Collections.Generic;
using System.Text;

namespace underware.VDA.Records.V03
{
    public class R719 : Record
    {
        public R719(string line) : base(line)
        {
        }

        public R719() : base()
        {
            Name = "719";
            Version = "03";
        }

        [RecordInfo(1, 7, Align.LEFT)]
        public string RecordTypeCounter711 { get; set; }

        [RecordInfo(2, 7, Align.LEFT)]
        public string RecordTypeCounter712 { get; set; }

        [RecordInfo(3, 7, Align.LEFT)]
        public string RecordTypeCounter713 { get; set; }

        [RecordInfo(4, 7, Align.LEFT)]
        public string RecordTypeCounter714 { get; set; }

        [RecordInfo(5, 7, Align.LEFT)]
        public string RecordTypeCounter715 { get; set; }

        [RecordInfo(6, 7, Align.LEFT)]
        public string RecordTypeCounter716 { get; set; }

        [RecordInfo(7, 7, Align.LEFT)]
        public string RecordTypeCounter718 { get; set; }

        [RecordInfo(8, 7, Align.LEFT)]
        public string RecordTypeCounter719 { get; set; }

        [RecordInfo(9, 7, Align.LEFT)]
        public string RecordTypeCounter717 { get; set; }

        [RecordInfo(10, 60, Align.LEFT)]
        public string Empty { get; set; }
    }
}
