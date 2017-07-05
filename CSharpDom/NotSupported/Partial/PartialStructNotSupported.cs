using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.NotSupported.Partial
{
    public sealed class PartialStructNotSupported : VisitableNotSupported<IGenericVisitor>,
        IPartialStruct,
        IClassNestedPartialStruct,
        IStaticClassNestedPartialStruct,
        IStructNestedPartialStruct
    {
    }
}
