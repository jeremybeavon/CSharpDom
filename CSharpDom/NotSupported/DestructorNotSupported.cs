using CSharpDom.Common;

namespace CSharpDom.NotSupported
{
    public sealed class DestructorNotSupported : VisitableNotSupported<IGenericVisitor>, IDestructor
    {
    }
}
