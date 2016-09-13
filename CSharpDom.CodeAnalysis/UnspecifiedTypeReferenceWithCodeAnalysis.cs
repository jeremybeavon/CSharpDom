using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public sealed class UnspecifiedTypeReferenceWithCodeAnalysis :
        EditableUnspecifiedTypeReference<GenericParameterWithCodeAnalysis>,
        IHasSyntax<NameSyntax>,
        ITypeReferenceWithCodeAnalysis,
        IHasNode<NameSyntax>//,
                                      //IVisitable<IReflectionVisitor>
    {
        private readonly Node<UnspecifiedTypeReferenceWithCodeAnalysis, NameSyntax> node;
        private readonly GenericParameterListWrapper<UnspecifiedTypeReferenceWithCodeAnalysis> genericParameters;
        
        internal UnspecifiedTypeReferenceWithCodeAnalysis()
        {
            node = new Node<UnspecifiedTypeReferenceWithCodeAnalysis, NameSyntax>(this);
            genericParameters = new GenericParameterListWrapper<UnspecifiedTypeReferenceWithCodeAnalysis>(
                node,
                syntax => syntax.ToGenericParameters(),
                (parentSyntax, childSyntax) => parentSyntax.WithGenericParameters(childSyntax));
        }

        public override IList<GenericParameterWithCodeAnalysis> GenericParameters
        {
            get { return genericParameters; }
            set { Syntax = Syntax.WithGenericParameters(value); }
        }

        public override string Name
        {
            get { return Syntax.ToName(); }
            set { Syntax = Syntax.WithName(value); }
        }

        public NameSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        TypeSyntax IHasSyntax<TypeSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (NameSyntax)value; }
        }
        
        internal Node<UnspecifiedTypeReferenceWithCodeAnalysis, NameSyntax> Node
        {
            get { return node; }
        }
        
        INode<NameSyntax> IHasNode<NameSyntax>.Node
        {
            get { return node; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitUnspecifiedTypeReferenceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
