using System;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public sealed class GenericParameterWithCodeAnalysis :
        EditableGenericParameter<ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<TypeSyntax>,
        IHasNode<TypeSyntax>
    {
        private readonly Node<GenericParameterWithCodeAnalysis, TypeSyntax> node;
        private readonly CachedTypeReferenceNode<GenericParameterWithCodeAnalysis, TypeSyntax> type;
        
        internal GenericParameterWithCodeAnalysis()
        {
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
        
        INode<TypeSyntax> IHasNode<TypeSyntax>.Node
        {
            get { return node; }
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
