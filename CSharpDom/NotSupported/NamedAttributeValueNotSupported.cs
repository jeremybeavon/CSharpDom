using System;
using CSharpDom.Common;

namespace CSharpDom.NotSupported
{
    public sealed class NamedAttributeValueNotSupported : VisitableNotSupported<IGenericVisitor>, INamedAttributeValue
    {
        public string Name
        {
            get { throw new NotSupportedException(); }
        }

        public string RawValue
        {
            get { throw new NotSupportedException(); }
        }
    }
}
