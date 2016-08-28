using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class DelegateReferenceWithCodeAnalysis :
        EditableDelegateReference<GenericParameterWithCodeAnalysis>,
        ITypeReferenceWithCodeAnalysis,
        IHasSyntax<NameSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Node<DelegateReferenceWithCodeAnalysis, NameSyntax> node;
        private GenericParameterListWrapper<DelegateReferenceWithCodeAnalysis> genericParameters;

        internal DelegateReferenceWithCodeAnalysis()
        {
            node = new Node<DelegateReferenceWithCodeAnalysis, NameSyntax>(this);
            genericParameters = new GenericParameterListWrapper<DelegateReferenceWithCodeAnalysis>(
                node,
                syntax => syntax.ToGenericParameters(),
                (parentSyntax, childSyntax) => Syntax.WithGenericParameters(childSyntax),
                parent => new GenericParameterWithCodeAnalysis(parent),
                (child, parent) => { });
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

        internal IChildCollection<GenericParameterWithCodeAnalysis, TypeSyntax> GenericParameterList
        {
            get { return genericParameters; }
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
