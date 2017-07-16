using CSharpDom.Common;
using CSharpDom.Editable;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class OperatorOverloadWithCodeAnalysis :
        EditableOperatorOverload<
            AttributeGroupWithCodeAnalysis,
            IType,
            ITypeReferenceWithCodeAnalysis,
            OperatorParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<OperatorDeclarationSyntax>,
        IHasNode<OperatorDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private static readonly Map<SyntaxKind, OperatorOverloadType> operatorMap =
            new Map<SyntaxKind, OperatorOverloadType>()
            {
                { SyntaxKind.AmpersandToken, OperatorOverloadType.And },
                { SyntaxKind.TildeToken, OperatorOverloadType.BitwiseNot },
                { SyntaxKind.MinusMinusToken, OperatorOverloadType.Decrement },
                { SyntaxKind.SlashToken, OperatorOverloadType.Divide },
                { SyntaxKind.EqualsEqualsToken, OperatorOverloadType.Equal },
                { SyntaxKind.CaretToken, OperatorOverloadType.ExclusiveOr },
                { SyntaxKind.FalseKeyword, OperatorOverloadType.False },
                { SyntaxKind.GreaterThanToken, OperatorOverloadType.GreaterThan },
                { SyntaxKind.GreaterThanEqualsToken, OperatorOverloadType.GreaterThanOrEqual },
                { SyntaxKind.PlusPlusToken, OperatorOverloadType.Increment },
                { SyntaxKind.LessThanLessThanToken, OperatorOverloadType.LeftShift },
                { SyntaxKind.LessThanToken, OperatorOverloadType.LessThan },
                { SyntaxKind.LessThanEqualsToken, OperatorOverloadType.LessThanOrEqual },
                { SyntaxKind.ExclamationToken, OperatorOverloadType.LogicalNot },
                { SyntaxKind.MinusToken, OperatorOverloadType.Minus },
                { SyntaxKind.PercentToken, OperatorOverloadType.Modulo },
                { SyntaxKind.AsteriskToken, OperatorOverloadType.Multiply },
                { SyntaxKind.ExclamationEqualsToken, OperatorOverloadType.NotEqual },
                { SyntaxKind.BarToken, OperatorOverloadType.Or },
                { SyntaxKind.PlusToken, OperatorOverloadType.Plus },
                { SyntaxKind.GreaterThanGreaterThanToken, OperatorOverloadType.RightShift },
                { SyntaxKind.TrueKeyword, OperatorOverloadType.True }
            };

        private readonly Guid internalId;
        private readonly Node<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax> node;
        private readonly AttributeListWrapper<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax> attributes;
        private readonly MethodBodyNode<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax> body;
        private readonly SeparatedSyntaxListWrapper<
            OperatorOverloadWithCodeAnalysis,
            OperatorDeclarationSyntax,
            OperatorParameterWithCodeAnalysis,
            ParameterSyntax> parameters;
        private readonly CachedTypeReferenceNode<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax> returnType;
        
        internal OperatorOverloadWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new Node<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            body = new MethodBodyNode<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax>(
                node,
                syntax => syntax.Body,
                (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
            parameters = new SeparatedSyntaxListWrapper<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax, OperatorParameterWithCodeAnalysis, ParameterSyntax>(
                node,
                syntax => syntax.ParameterList.Parameters,
                (parentSyntax, childSyntax) => parentSyntax.WithParameterList(parentSyntax.ParameterList.WithParameters(childSyntax)),
                () => new OperatorParameterWithCodeAnalysis());
            returnType = new CachedTypeReferenceNode<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax>(
                node,
                syntax => syntax.ReturnType,
                (parentSyntax, childSyntax) => parentSyntax.WithReturnType(childSyntax));
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return body.Value; }
            set { body.Value = value; }
        }

        public override IType DeclaringType
        {
            get { return node.GetParentNode<IType>(); }
            set { throw new NotSupportedException(); }
        }

        public override OperatorOverloadType OperatorType
        {
            get { return operatorMap[Syntax.OperatorToken.Kind()]; }
            set { Syntax = Syntax.WithOperatorToken(SyntaxFactory.Token(operatorMap[value])); }
        }

        public override IList<OperatorParameterWithCodeAnalysis> Parameters
        {
            get { return parameters; }
            set
            {
                Syntax = Syntax.WithParameterList(
                    SyntaxFactory.ParameterList(SyntaxFactory.SeparatedList(value.Select(node => node.Syntax))));
            }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return returnType.Value; }
            set { returnType.Value = value; }
        }
        
        public OperatorDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        INode<OperatorDeclarationSyntax> IHasNode<OperatorDeclarationSyntax>.Node
        {
            get { return node; }
        }

        internal Node<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax> Node
        {
            get { return node; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitOperatorOverloadWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
