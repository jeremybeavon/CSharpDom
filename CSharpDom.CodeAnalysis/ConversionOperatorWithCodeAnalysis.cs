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
        IHasSyntax<ConversionOperatorDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Node<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax> node;
        private readonly IType declaringType;
        private readonly AttributeListWrapper<
            ConversionOperatorWithCodeAnalysis,
            ConversionOperatorDeclarationSyntax> attributes;
        private readonly CachedChildNode<
            ConversionOperatorWithCodeAnalysis,
            ConversionOperatorDeclarationSyntax,
            OperatorParameterWithCodeAnalysis> parameter;
        private readonly CachedChildNode<
            ConversionOperatorWithCodeAnalysis,
            ConversionOperatorDeclarationSyntax,
            ITypeReferenceWithCodeAnalysis> returnType;

        internal ConversionOperatorWithCodeAnalysis(IType declaringType)
        {
            node = new Node<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax>(this);
            this.declaringType = declaringType;
            attributes = new AttributeListWrapper<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => { });
            parameter = new CachedChildNode<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax, OperatorParameterWithCodeAnalysis>(
                node,
                parent => new OperatorParameterWithCodeAnalysis(parent),
                WithParameter,
                (child, parent) => child.Parameter.ConversionOperatorParent = parent);
            returnType = new CachedChildNode<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax, ITypeReferenceWithCodeAnalysis>(
                node,
                parent => parent.Syntax.Type.ToTypeReference(),
                (parent, child) => parent.Syntax.WithType(child.Syntax),
                (child, parent) => { });
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Attributes; }
            set { attributes.Attributes = value; }
        }

        public override IType DeclaringType
        {
            get { return declaringType; }
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

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }

        private static ConversionOperatorDeclarationSyntax WithParameter(
            ConversionOperatorWithCodeAnalysis parent,
            OperatorParameterWithCodeAnalysis child)
        {
            ConversionOperatorDeclarationSyntax syntax = parent.Syntax;
            return syntax.WithParameterList(syntax.ParameterList.WithParameters(SyntaxFactory.SingletonSeparatedList(child.Syntax)));
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
