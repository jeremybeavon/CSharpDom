using System.Collections.Generic;

namespace CSharpDom
{
    internal interface IBasicCompositeType
    {
        IReadOnlyCollection<EventNode> Events { get; }

        IReadOnlyCollection<IndexerNode> Indexers { get; }

        IReadOnlyCollection<PropertyNode> Properties { get; }

        IReadOnlyCollection<MethodNode> Methods { get; }
    }
}
