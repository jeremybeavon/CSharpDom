using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStructReference<TGenericParameter> : IStructReference<TGenericParameter>
        where TGenericParameter : IGenericParameter
    {
        public abstract IReadOnlyList<TGenericParameter> GenericParameters { get; }

        public abstract string Name { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructReferenceChildren(this, visitor);
        }
    }
}
