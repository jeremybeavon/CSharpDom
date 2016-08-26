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
        private readonly FilteredAttributeList filteredAttributes;
        private readonly FilteredAttributeList returnAttributes;
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
            filteredAttributes = new FilteredAttributeList(attributes, attribute => attribute.Syntax.Target == null);
            returnAttributes = new FilteredAttributeList(attributes, attribute => attribute.Syntax.Target != null);
            parameter = new CachedChildNode<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax, OperatorParameterWithCodeAnalysis>(
                node,
                syntax => new OperatorParameterWithCodeAnalysis(this),
                (syntax, value) => syntax.WithParameterList(syntax.ParameterList.WithParameters(SyntaxFactory.SeparatedList(new[] { value.Syntax }))),
                (child, parent) => child.Parameter.ConversionOperatorParent = parent);
            returnType = new CachedChildNode<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax, ITypeReferenceWithCodeAnalysis>(
                node,
                syntax => syntax.Type.ToTypeReference(),
                (syntax, value) => syntax.WithType(value.Syntax),
                (child, parent) => { });
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return filteredAttributes; }
            set { Syntax = Syntax.WithAttributeLists(value.Concat(returnAttributes).ToAttributes()); }
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
            get { return returnAttributes; }
            set { Syntax = Syntax.WithAttributeLists(filteredAttributes.Concat(value).ToAttributes()); }
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

        internal IChildCollection<ParameterWithCodeAnalysis, ParameterSyntax> ParameterList
        {
            get { return null; }
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
