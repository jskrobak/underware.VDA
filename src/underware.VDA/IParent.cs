using System.Collections.Generic;

namespace underware.VDA;

public interface IParent
{
    IList<Record> Subrecords { get; }
}