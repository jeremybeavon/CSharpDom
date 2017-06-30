using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public sealed class UnspecifiedTypeReferenceWithCodeAnalysis :
        EditableUnspecifiedTypeReference<GenericParameterWithCodeAnalysis>,
        IHasSyntax<NameSyntax>,
        IInternalTypeReferenceWithCodeAnalysis,
        IHasNode<NameSyntax>//,
                                      //IVisitable<IReflectionVisitor>
    {
        private readonly TypeReferenceNode<UnspecifiedTypeReferenceWithCodeAnalysis, NameSyntax> node;
        private readonly SeparatedSyntaxListWrapper<
            UnspecifiedTypeReferenceWithCodeAnalysis,
            NameSyntax,
            GenericParameterWithCodeAnalysis,
            TypeSyntax> genericParameters;
        
        internal UnspecifiedTypeReferenceWithCodeAnalysis()
        {
            node = new TypeReferenceNode<UnspecifiedTypeReferenceWithCodeAnalysis, NameSyntax>(this);
            genericParameters = new SeparatedSyntaxListWrapper<UnspecifiedTypeReferenceWithCodeAnalysis, NameSyntax, GenericParameterWithCodeAnalysis, TypeSyntax>(
                node,
                syntax => syntax.ToGenericParameters(),
                (parentSyntax, childSyntax) => parentSyntax.WithGenericParameters(childSyntax),
                () => new GenericParameterWithCodeAnalysis(new UnspecifiedTypeReferenceWithCodeAnalysis()));
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
        
        internal TypeReferenceNode<UnspecifiedTypeReferenceWithCodeAnalysis, NameSyntax> Node
        {
            get { return node; }
        }
        
        INode<NameSyntax> IHasNode<NameSyntax>.Node
        {
            get { return node; }
        }

        INode<TypeSyntax> IHasNode<TypeSyntax>.Node => node;

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
