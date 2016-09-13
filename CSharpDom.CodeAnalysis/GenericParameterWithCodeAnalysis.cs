using System;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public sealed class GenericParameterWithCodeAnalysis :
        EditableGenericParameter<ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<TypeSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly Node<GenericParameterWithCodeAnalysis, TypeSyntax> node;
        private readonly CachedTypeReferenceNode<GenericParameterWithCodeAnalysis, TypeSyntax> type;
        
        internal GenericParameterWithCodeAnalysis(UnspecifiedTypeReferenceWithCodeAnalysis parent)
            : this()
        {
            UnspecifiedTypeReferenceParent = parent;
        }

        private GenericParameterWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new Node<GenericParameterWithCodeAnalysis, TypeSyntax>(this);
        }

        public override ITypeReferenceWithCodeAnalysis Type
        {
            get { return type.Value; }
            set { type.Value = value; }
        }

        public TypeSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }
        
        internal UnspecifiedTypeReferenceWithCodeAnalysis UnspecifiedTypeReferenceParent
        {
            get { return node.GetParentNode<UnspecifiedTypeReferenceWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<UnspecifiedTypeReferenceWithCodeAnalysis, NameSyntax>(
                    value,
                    parent => parent.GenericParameterList);
            }
        }

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
