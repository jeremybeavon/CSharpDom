using System;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractGenericParameterReference : IGenericParameterReference
    {
        public abstract string Name { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitGenericParameterReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
