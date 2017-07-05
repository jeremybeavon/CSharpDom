using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.NotSupported
{
    public sealed class PartialClassCollectionNotSupported : VisitableNotSupported<IGenericVisitor>, IPartialClassCollection
    {
        public int Count
        {
            get { return 0; }
        }
    }
}
