using System;

namespace CSharpDom.Text
{
    [Flags]
    internal enum AccessorFlags
    {
        None = 0,
        Get = 0x1,
        Set = 0x2,
        Property = 0x4,
        Indexer = 0x8
    }
}
