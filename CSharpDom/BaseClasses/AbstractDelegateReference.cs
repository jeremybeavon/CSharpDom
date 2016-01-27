using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractDelegateReference<TGenericParameter> : IDelegateReference<TGenericParameter>
        where TGenericParameter : IGenericParameter
    {
        public abstract IReadOnlyList<TGenericParameter> GenericParameters { get; }

        public abstract string Name { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitDelegateReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitDelegateReferenceChildren(this, visitor);
        }
    }
}
