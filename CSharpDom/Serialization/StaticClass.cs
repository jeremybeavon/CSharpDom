using System;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StaticClass : IStaticClass
    {
        public void Accept(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
