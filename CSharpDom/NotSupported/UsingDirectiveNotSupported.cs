using CSharpDom.Common;
using System;

namespace CSharpDom.NotSupported
{
    public sealed class UsingDirectiveNotSupported : VisitableNotSupported<IGenericVisitor>, IUsingDirective
    {
        public string Name
        {
            get { throw new NotSupportedException(); }
        }
    }
}
