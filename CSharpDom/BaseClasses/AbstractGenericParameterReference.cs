using System;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractGenericParameterReference : AbstractGenericVisitableObject, IGenericParameterReference
    {
        public abstract string Name { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitGenericParameterReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
