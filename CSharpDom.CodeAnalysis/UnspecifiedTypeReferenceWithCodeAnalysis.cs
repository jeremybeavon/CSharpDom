using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.BaseClasses.Editable;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

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

        public UnspecifiedTypeReferenceWithCodeAnalysis(
            string name,
            params ITypeReferenceWithCodeAnalysis[] genericParameters)
            : this()
        {
            if (genericParameters.Length == 0)
            {
                Syntax = SyntaxFactory.IdentifierName(name);
            }
            else
            {
                SeparatedSyntaxList<TypeSyntax> argumentList = SyntaxFactory.SeparatedList(
                    genericParameters.Select(parameter => parameter.Syntax));
                Syntax = SyntaxFactory.GenericName(
                    SyntaxFactory.Identifier(name),
                    SyntaxFactory.TypeArgumentList(argumentList));
            }
        }

        internal UnspecifiedTypeReferenceWithCodeAnalysis()
        {
            node = new TypeReferenceNode<UnspecifiedTypeReferenceWithCodeAnalysis, NameSyntax>(this);
            genericParameters = new SeparatedSyntaxListWrapper<UnspecifiedTypeReferenceWithCodeAnalysis, NameSyntax, IInternalTypeReferenceWithCodeAnalysis, TypeSyntax>(
                node,
                syntax => syntax.ToGenericParameters(),
                (parentSyntax, childSyntax) => parentSyntax.WithGenericParameters(childSyntax),
                GetTypeReference);
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

        private static IInternalTypeReferenceWithCodeAnalysis GetTypeReference(TypeSyntax syntax)
        {
            return syntax is PredefinedTypeSyntax ?
                (IInternalTypeReferenceWithCodeAnalysis)new BuiltInTypeReferenceWithCodeAnalysis() :
                new UnspecifiedTypeReferenceWithCodeAnalysis();
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
