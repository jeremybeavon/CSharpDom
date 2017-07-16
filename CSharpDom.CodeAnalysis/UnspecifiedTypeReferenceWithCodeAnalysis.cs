using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Editable;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class UnspecifiedTypeReferenceWithCodeAnalysis :
        EditableUnspecifiedTypeReference<ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<NameSyntax>,
        IInternalTypeReferenceWithCodeAnalysis,
        IHasNode<NameSyntax>//,
                                      //IVisitable<IReflectionVisitor>
    {
        private readonly TypeReferenceNode<UnspecifiedTypeReferenceWithCodeAnalysis, NameSyntax> node;
        private readonly SeparatedSyntaxListWrapper<
            UnspecifiedTypeReferenceWithCodeAnalysis,
            NameSyntax,
            IInternalTypeReferenceWithCodeAnalysis,
            TypeSyntax> genericParameters;
        private readonly WrappedList<
            IInternalTypeReferenceWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis> wrappedGenericParameters;
        
        internal UnspecifiedTypeReferenceWithCodeAnalysis()
        {
            node = new TypeReferenceNode<UnspecifiedTypeReferenceWithCodeAnalysis, NameSyntax>(this);
            genericParameters = new SeparatedSyntaxListWrapper<UnspecifiedTypeReferenceWithCodeAnalysis, NameSyntax, IInternalTypeReferenceWithCodeAnalysis, TypeSyntax>(
                node,
                syntax => syntax.ToGenericParameters(),
                (parentSyntax, childSyntax) => parentSyntax.WithGenericParameters(childSyntax),
                () => new UnspecifiedTypeReferenceWithCodeAnalysis());
            wrappedGenericParameters = new WrappedList<IInternalTypeReferenceWithCodeAnalysis, ITypeReferenceWithCodeAnalysis>(
                genericParameters,
                parent => parent,
                child => (IInternalTypeReferenceWithCodeAnalysis)child);
        }

        public override IList<ITypeReferenceWithCodeAnalysis> GenericParameters
        {
            get { return wrappedGenericParameters; }
            set { genericParameters.ReplaceList(value.Cast<IInternalTypeReferenceWithCodeAnalysis>()); }
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
