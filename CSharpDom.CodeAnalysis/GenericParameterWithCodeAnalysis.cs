using System;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class GenericParameterWithCodeAnalysis :
        EditableGenericParameter,
        IHasSyntax<TypeSyntax>,
        IHasNode<TypeSyntax>
    {
        private readonly IInternalTypeReferenceWithCodeAnalysis type;
        
        internal GenericParameterWithCodeAnalysis(IInternalTypeReferenceWithCodeAnalysis type)
        {
            this.type = type;
        }

        public ITypeReferenceWithCodeAnalysis Type
        {
            get { return type; }
        }

        public TypeSyntax Syntax
        {
            get { return type.Syntax; }
            set { type.Syntax = value; }
        }
        
        INode<TypeSyntax> IHasNode<TypeSyntax>.Node
        {
            get { return type.Node; }
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
