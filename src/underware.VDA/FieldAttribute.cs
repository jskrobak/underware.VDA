using System;
using System.Collections.Generic;
using System.Text;

namespace underware.VDA
{
    [AttributeUsage(AttributeTargets.Property)]
    class FieldAttribute(int index, int len, Align align = Align.LEFT, char padChar = ' ')
        : Attribute
    {
        public int Ordinal { get; set; } = index;
        public int Length { get; set; } = len;
        public string Name { get; set; }
        public Align Align { get; set; } = align;

        public char PadChar { get; set; } = padChar;
    }

    public enum Align
    {
        LEFT, RIGHT
    }
}
