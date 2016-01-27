using System;
using CSharpDom.Common;

namespace CSharpDom.NotSupported
{
    public sealed class UnnamedAttributeValueNotSupported : VisitableNotSupported<IGenericVisitor>, IUnnamedAttributeValue
    {
        public string RawValue
        {
            get { throw new NotSupportedException(); }
        }
    }
}
