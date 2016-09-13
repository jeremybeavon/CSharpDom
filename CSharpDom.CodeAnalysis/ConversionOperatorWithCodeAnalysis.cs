using CSharpDom.Common;
using CSharpDom.Editable;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ConversionOperatorWithCodeAnalysis :
        EditableConversionOperator<
            AttributeGroupWithCodeAnalysis,
            IType,
            ITypeReferenceWithCodeAnalysis,
            OperatorParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<ConversionOperatorDeclarationSyntax>,
        IHasNode<ConversionOperatorDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Node<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax> node;
        private readonly AttributeListWrapper<
            ConversionOperatorWithCodeAnalysis,
            ConversionOperatorDeclarationSyntax> attributes;
        private readonly MethodBodyNode<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax> body;
        private readonly CachedChildNode<
            ConversionOperatorWithCodeAnalysis,
            ConversionOperatorDeclarationSyntax,
            OperatorParameterWithCodeAnalysis,
            ParameterSyntax> parameter;
        private readonly CachedTypeReferenceNode<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax> returnType;
        
        internal ConversionOperatorWithCodeAnalysis()
        {
            node = new Node<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            body = new MethodBodyNode<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax>(
                node,
                syntax => syntax.Body,
                (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
            parameter = new CachedChildNode<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax, OperatorParameterWithCodeAnalysis, ParameterSyntax>(
                node,
                () => new OperatorParameterWithCodeAnalysis(),
                syntax => syntax.ParameterList.Parameters[0],
                WithParameter);
            returnType = new CachedTypeReferenceNode<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax>(
                node,
                syntax => syntax.Type,
                (parentSyntax, childSyntax) => parentSyntax.WithType(childSyntax));
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Attributes; }
            set { attributes.Attributes = value; }
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

        public override ConversionOperatorType OperatorType
        {
            get
            {
                return Syntax.ImplicitOrExplicitKeyword.Kind() == SyntaxKind.ExplicitKeyword ?
                    ConversionOperatorType.Explicit :
                    ConversionOperatorType.Implicit;
            }
            set
            {
                SyntaxKind kind = value == ConversionOperatorType.Explicit ?
                    SyntaxKind.ExplicitKeyword :
                    SyntaxKind.ImplicitKeyword;
                Syntax = Syntax.WithImplicitOrExplicitKeyword(SyntaxFactory.Token(kind));
            }
        }

        public override OperatorParameterWithCodeAnalysis Parameter
        {
            get { return parameter.Value; }
            set { parameter.Value = value; }
        }
        
        public override ICollection<AttributeGroupWithCodeAnalysis> ReturnAttributes
        {
            get { return attributes.TargetedAttributes; }
            set { attributes.TargetedAttributes = value; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return returnType.Value; }
            set { returnType.Value = value; }
        }
        
        public ConversionOperatorDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        INode<ConversionOperatorDeclarationSyntax> IHasNode<ConversionOperatorDeclarationSyntax>.Node
        {
            get { return node; }
        }

        private static ConversionOperatorDeclarationSyntax WithParameter(
            ConversionOperatorDeclarationSyntax parentSyntax,
            ParameterSyntax childSyntax)
        {
            return parentSyntax.WithParameterList(
                parentSyntax.ParameterList.WithParameters(SyntaxFactory.SingletonSeparatedList(childSyntax)));
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitConversionOperatorWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
