using System;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class GenericParameterWithCodeAnalysis :
        EditableGenericParameter<ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<TypeSyntax>,
        IHasNode<TypeSyntax>
    {
        private readonly Node<GenericParameterWithCodeAnalysis, TypeSyntax> node;
        
        internal GenericParameterWithCodeAnalysis(
            IList<GenericParameterWithCodeAnalysis> parameters)
        {
            node = new Node<GenericParameterWithCodeAnalysis, TypeSyntax>(this);
        }

        public override ITypeReferenceWithCodeAnalysis Type
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
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
