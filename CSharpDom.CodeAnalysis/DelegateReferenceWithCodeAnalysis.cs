using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class DelegateReferenceWithCodeAnalysis :
        EditableDelegateReference<ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<NameSyntax>,
        IHasNode<NameSyntax>,
        IInternalTypeReferenceWithCodeAnalysis
    {
        private readonly UnspecifiedTypeReferenceWithCodeAnalysis typeReference;

        public DelegateReferenceWithCodeAnalysis(
            string name,
            params ITypeReferenceWithCodeAnalysis[] genericParameters)
            : this(new UnspecifiedTypeReferenceWithCodeAnalysis(name, genericParameters))
        {
        }

        internal DelegateReferenceWithCodeAnalysis(UnspecifiedTypeReferenceWithCodeAnalysis typeReference)
        {
            this.typeReference = typeReference;
        }
        
        public override IList<ITypeReferenceWithCodeAnalysis> GenericParameters
        {
            get { return typeReference.GenericParameters; }
            set { typeReference.GenericParameters = value; }
        }

        public override string Name
        {
            get { return typeReference.Name; }
            set { typeReference.Name = value; }
        }
        
        public NameSyntax Syntax
        {
            get { return typeReference.Syntax; }
            set { typeReference.Syntax = value; }
        }

        internal UnspecifiedTypeReferenceWithCodeAnalysis TypeReference
        {
            get { return typeReference; }
        }

        INode<NameSyntax> IHasNode<NameSyntax>.Node
        {
            get { return typeReference.Node; }
        }

        INode<TypeSyntax> IHasNode<TypeSyntax>.Node => typeReference.Node;

        TypeSyntax IHasSyntax<TypeSyntax>.Syntax
        {
            get => typeReference.Syntax;
            set => typeReference.Syntax = (NameSyntax)value;
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitDelegateReferenceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
