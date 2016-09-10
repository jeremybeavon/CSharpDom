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
        IHasId//,
        //IVisitable<IReflectionVisitor>
    {
        private static readonly IDictionary<SyntaxKind, OperatorOverloadType> operatorMap =
            new Dictionary<SyntaxKind, OperatorOverloadType>()
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
        private readonly SeparatedSyntaxListWrapper<
            OperatorOverloadWithCodeAnalysis,
            OperatorDeclarationSyntax,
            OperatorParameterWithCodeAnalysis,
            ParameterSyntax> parameters;
        private readonly CachedChildNode<
            OperatorOverloadWithCodeAnalysis,
            OperatorDeclarationSyntax,
            ITypeReferenceWithCodeAnalysis,
            TypeSyntax> returnType;

        internal OperatorOverloadWithCodeAnalysis(ClassTypeWithCodeAnalysis parent)
            : this()
        {
            ClassParent = parent;
        }

        internal OperatorOverloadWithCodeAnalysis(StructTypeWithCodeAnalysis parent)
            : this()
        {
            StructParent = parent;
        }

        private OperatorOverloadWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new Node<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.OperatorOverloadParent = parent);
            parameters = new SeparatedSyntaxListWrapper<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax, OperatorParameterWithCodeAnalysis, ParameterSyntax>(
                node,
                syntax => syntax.ParameterList.Parameters,
                (parentSyntax, childSyntax) => parentSyntax.WithParameterList(parentSyntax.ParameterList.WithParameters(childSyntax)),
                child => new OperatorParameterWithCodeAnalysis(child),
                (child, parent) => child.Parameter.OperatorOverloadParent = parent);
            returnType = new CachedChildNode<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax, ITypeReferenceWithCodeAnalysis, TypeSyntax>(
                node,
                (parentSyntax, childSyntax) => parentSyntax.WithReturnType(childSyntax),
                parent => parent.Syntax.ReturnType.ToTypeReference(),
                null);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override IType DeclaringType
        {
            get { return node.GetParentNode<IType>(); }
            set { throw new NotSupportedException(); }
        }

        public override OperatorOverloadType OperatorType
        {
            get { return operatorMap[Syntax.OperatorToken.Kind()]; }
            set { Syntax = Syntax.WithOperatorToken(SyntaxFactory.Token(operatorMap.First(map => map.Value == value).Key)); }
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

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }

        internal IChildCollection<OperatorParameterWithCodeAnalysis, ParameterSyntax> ParameterList
        {
            get { return parameters; }
        }

        internal ClassTypeWithCodeAnalysis ClassParent
        {
            get { return node.GetParentNode<ClassTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.OperatorOverloadList);
            }
        }

        internal StructTypeWithCodeAnalysis StructParent
        {
            get { return node.GetParentNode<StructTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<StructTypeWithCodeAnalysis, StructDeclarationSyntax>(
                    value,
                    parent => parent.OperatorOverloadList);
            }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
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
