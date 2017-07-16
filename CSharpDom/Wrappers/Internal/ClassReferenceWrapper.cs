using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassReferenceWrapper : AbstractWrapper<IClassReference>, IClassReferenceWrapper
    {
        private Func<IReadOnlyList<ITypeReferenceWrapper>> genericParameters;
        private Func<string> name;

        public ClassReferenceWrapper(IClassReference classReference)
            : base(classReference)
        {
        }

        public IReadOnlyList<ITypeReferenceWrapper> GenericParameters
        {
            get { return genericParameters(); }
        }

        public string Name
        {
            get { return name(); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassReferenceChildren(this, visitor);
        }

        public override void VisitClassReference<TGenericParameter>(IClassReference<TGenericParameter> classReference)
        {
            genericParameters = () => new ReadOnlyListWrapper<TGenericParameter, ITypeReferenceWrapper>(
                classReference.GenericParameters,
                input => TypeReferenceWrapper.Create(input));
            name = () => classReference.Name;
        }
    }
}
