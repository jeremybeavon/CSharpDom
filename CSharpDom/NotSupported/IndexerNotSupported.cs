using System;
using CSharpDom.Common;

namespace CSharpDom.NotSupported
{
    public sealed class IndexerNotSupported : VisitableNotSupported<IGenericVisitor>, IClassIndexer, IInterfaceIndexer
    {
        public InterfaceMemberInheritanceModifier InheritanceModifier
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
