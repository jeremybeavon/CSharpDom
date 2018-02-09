using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfaceReferenceWithCodeAnalysis :
        EditableInterfaceReference<ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<NameSyntax>,
        IHasNode<NameSyntax>,
        IInternalTypeReferenceWithCodeAnalysis,
        IUnspecifiedTypeReferenceWrapper
    {
        private readonly UnspecifiedTypeReferenceWithCodeAnalysis typeReference;
        
        public InterfaceReferenceWithCodeAnalysis(
            string name,
            params ITypeReferenceWithCodeAnalysis[] genericParameters)
        {
            typeReference = new UnspecifiedTypeReferenceWithCodeAnalysis(name, genericParameters);
        }

        public InterfaceReferenceWithCodeAnalysis(UnspecifiedTypeReferenceWithCodeAnalysis typeReference)
        {
            this.typeReference = typeReference;
        }

        internal InterfaceReferenceWithCodeAnalysis()
        {
            typeReference = new UnspecifiedTypeReferenceWithCodeAnalysis();
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

        public override int GetHashCode()
        {
            return typeReference.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is InterfaceReferenceWithCodeAnalysis reference && typeReference == reference.typeReference;
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

        UnspecifiedTypeReferenceWithCodeAnalysis IUnspecifiedTypeReferenceWrapper.TypeReference => typeReference;

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitInterfaceReferenceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
