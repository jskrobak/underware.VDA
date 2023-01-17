using System;
using System.Collections.Generic;
using System.Text;

namespace underware.VDA
{
    class RecordInfo : Attribute
    {
        public RecordInfo(int index, int len, Align align = Align.LEFT)
        {
            Ordinal = index;
            Length = len;
            Align = Align;
        }

        public int Ordinal { get; set; }
        public int Length { get; set; }
        public string Name { get; set; }
        public Align Align { get; set; }
    }

    public enum Align
    {
        LEFT, RIGHT
    }
}
