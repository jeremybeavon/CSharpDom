using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class AnonymousMethodParameterWithCodeAnalysis :
        EditableAnonymousMethodParameter<ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<ParameterSyntax>,
        IHasNode<ParameterSyntax>
    {
        private readonly Node<AnonymousMethodParameterWithCodeAnalysis, ParameterSyntax> node;
        private readonly CachedTypeReferenceNode<
            AnonymousMethodParameterWithCodeAnalysis,
            ParameterSyntax> parameterType;

        internal AnonymousMethodParameterWithCodeAnalysis()
        {
            node = new Node<AnonymousMethodParameterWithCodeAnalysis, ParameterSyntax>(this);
            parameterType = new CachedTypeReferenceNode<AnonymousMethodParameterWithCodeAnalysis, ParameterSyntax>(
                node,
                syntax => syntax.Type,
                (parentSyntax, childSyntax) => parentSyntax.WithType(childSyntax));
        }

        public override string Name
        {
            get { return Syntax.Identifier.Text; }
            set { Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public override AnonymousMethodParameterModifier Modifier
        {
            get
            {
                SyntaxTokenList modifiers = Syntax.Modifiers;
                if (modifiers.Count == 0)
                {
                    return AnonymousMethodParameterModifier.None;
                }

                switch (modifiers[0].Kind())
                {
                    case SyntaxKind.RefKeyword:
                        return AnonymousMethodParameterModifier.Ref;
                    case SyntaxKind.OutKeyword:
                        return AnonymousMethodParameterModifier.Out;
                    default:
                        throw new NotSupportedException();
                }
            }
            set
            {
                switch (value)
                {
                    case AnonymousMethodParameterModifier.None:
                        Syntax = Syntax.WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.None)));
                        break;
                    case AnonymousMethodParameterModifier.Ref:
                        Syntax = Syntax.WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.RefKeyword)));
                        break;
                    case AnonymousMethodParameterModifier.Out:
                        Syntax = Syntax.WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.OutKeyword)));
                        break;
                }
            }
        }

        public override ITypeReferenceWithCodeAnalysis ParameterType
        {
            get { return parameterType.Value; }
            set { parameterType.Value = value; }
        }

        public ParameterSyntax Syntax { get => node.Syntax; set => node.Syntax = value; }

        INode<ParameterSyntax> IHasNode<ParameterSyntax>.Node => node;
    }
}
