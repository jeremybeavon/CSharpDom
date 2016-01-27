using System;
using CSharpDom.Common;

namespace CSharpDom.NotSupported
{
    public sealed class GenericParameterReferenceNotSupported : VisitableNotSupported<IGenericVisitor>, IGenericParameterReference
    {
        public string Name
        {
            get { throw new NotSupportedException(); }
        }
    }
}
