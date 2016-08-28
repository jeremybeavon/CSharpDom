using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfaceReferenceWithCodeAnalysis :
        EditableInterfaceReference<GenericParameterWithCodeAnalysis>,
        IHasSyntax<NameSyntax>,
        ITypeReferenceWithCodeAnalysis//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Node<InterfaceReferenceWithCodeAnalysis, NameSyntax> node;
        private readonly GenericParameterListWrapper<InterfaceReferenceWithCodeAnalysis> genericParameters;

        internal InterfaceReferenceWithCodeAnalysis()
        {
            node = new Node<InterfaceReferenceWithCodeAnalysis, NameSyntax>(this);
            genericParameters = new GenericParameterListWrapper<InterfaceReferenceWithCodeAnalysis>(
                node,
                syntax => syntax.ToGenericParameters(),
                (parentSyntax, childSyntax) => parentSyntax.WithGenericParameters(childSyntax),
                parent => new GenericParameterWithCodeAnalysis(parent),
                (child, parent) => child.InterfaceReferenceParent = parent);
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

        internal IChildCollection<GenericParameterWithCodeAnalysis, TypeSyntax> GenericParameterList
        {
            get { return genericParameters; }
        }

        TypeSyntax IHasSyntax<TypeSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (NameSyntax)value; }
        }

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
