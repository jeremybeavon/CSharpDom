using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassReferenceWrapper : AbstractWrapper<IClassReference>, IClassReferenceWrapper
    {
        private Func<IReadOnlyList<IGenericParameterWrapper>> genericParameters;
        private Func<string> name;

        public ClassReferenceWrapper(IClassReference classReference)
            : base(classReference)
        {
        }

        public IReadOnlyList<IGenericParameterWrapper> GenericParameters
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
            genericParameters = () => new ReadOnlyListWrapper<TGenericParameter, IGenericParameterWrapper>(
                classReference.GenericParameters,
                input => new GenericParameterWrapper(input));
            name = () => classReference.Name;
        }
    }
}
