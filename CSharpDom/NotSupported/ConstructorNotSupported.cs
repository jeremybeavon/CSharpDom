using System;
using CSharpDom.Common;

namespace CSharpDom.NotSupported
{
    public sealed class ConstructorNotSupported : VisitableNotSupported<IGenericVisitor>, IClassConstructor, IStructConstructor
    {
    }
}
