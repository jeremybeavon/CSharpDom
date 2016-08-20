using System;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public sealed class GenericParameterWithCodeAnalysis :
        EditableGenericParameter<TypeReferenceWithCodeAnalysis>,
        IHasSyntax<TypeSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly Func<TypeSyntax> getType;
        private readonly Action<TypeSyntax> setType;
        private TypeReferenceWithCodeAnalysis typeReference;

        //public GenericParameterWithCodeAnalysis(TypeReferenceWithCodeAnalysis typeReference)
        //    : this(new DetachedParentWithId<GenericParameterWithCodeAnalysis, TypeSyntax>(typeReference.Syntax))
        //{
        //}

        internal GenericParameterWithCodeAnalysis(ClassReferenceWithCodeAnalysis parent)
        {
            
        }

        public override TypeReferenceWithCodeAnalysis Type
        {
            get { return typeReference; }
            set
            {
                typeReference = value;
            }
        }

        public TypeSyntax Syntax
        {
            get { return getType(); }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }

        internal ClassReferenceWithCodeAnalysis ClassReferenceParent { get; set; }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitGenericParameterWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
