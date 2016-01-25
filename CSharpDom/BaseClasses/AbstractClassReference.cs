using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassReference<TGenericParameter> : IClassReference<TGenericParameter>
        where TGenericParameter : IGenericParameter
    {
        public abstract IReadOnlyList<TGenericParameter> GenericParameters { get; }

        public abstract string Name { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassReferenceChildren(this, visitor);
        }
    }
}
