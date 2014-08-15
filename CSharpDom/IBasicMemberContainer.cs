using System.Collections.ObjectModel;

namespace CSharpDom
{
    internal interface IBasicMemberContainer : IHasBasicCompositeType
    {
        Collection<EventNode> Events { get; }

        Collection<IndexerNode> Indexers { get; }

        Collection<PropertyNode> Properties { get; }

        Collection<MethodNode> Methods { get; }
    }
}
