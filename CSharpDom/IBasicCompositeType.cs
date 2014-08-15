using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
