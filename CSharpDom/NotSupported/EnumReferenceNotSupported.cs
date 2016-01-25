using System;
using CSharpDom.Common;

namespace CSharpDom.NotSupported
{
    public sealed class EnumReferenceNotSupported : VisitableNotSupported<IGenericVisitor>, IEnumReference
    {
        public string Name
        {
            get { throw new NotSupportedException(); }
        }
    }
}
