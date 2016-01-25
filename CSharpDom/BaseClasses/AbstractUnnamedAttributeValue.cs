using System;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractUnnamedAttributeValue : IUnnamedAttributeValue
    {
        public abstract string RawValue { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitUnnamedAttributeValue(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
