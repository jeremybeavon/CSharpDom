using CSharpDom.Common;

namespace CSharpDom.NotSupported
{
    public sealed class NestedInterfaceNotSupported : VisitableNotSupported<IGenericVisitor>, IClassNestedInterface
    {
    }
}
