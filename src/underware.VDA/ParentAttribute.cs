#nullable enable
using System;

namespace underware.VDA;

public class ParentAttribute(Type type) : Attribute
{
    public Type Type { get; } = type;
}