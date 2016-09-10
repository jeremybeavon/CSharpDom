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
        IHasId//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Guid internalId;
        private readonly Node<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax> node;
        private readonly IType declaringType;
        private readonly AttributeListWrapper<
            ConversionOperatorWithCodeAnalysis,
            ConversionOperatorDeclarationSyntax> attributes;
        private readonly CachedChildNode<
            ConversionOperatorWithCodeAnalysis,
            ConversionOperatorDeclarationSyntax,
            OperatorParameterWithCodeAnalysis,
            ParameterSyntax> parameter;
        private readonly CachedChildNode<
            ConversionOperatorWithCodeAnalysis,
            ConversionOperatorDeclarationSyntax,
            ITypeReferenceWithCodeAnalysis,
            TypeSyntax> returnType;

        internal ConversionOperatorWithCodeAnalysis(ClassTypeWithCodeAnalysis parent)
            : this()
        {
            ClassParent = parent;
        }

        internal ConversionOperatorWithCodeAnalysis(StructTypeWithCodeAnalysis parent)
            : this()
        {
            StructParent = parent;
        }

        private ConversionOperatorWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new Node<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => { });
            parameter = new CachedChildNode<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax, OperatorParameterWithCodeAnalysis, ParameterSyntax>(
                node,
                WithParameter,
                parent => new OperatorParameterWithCodeAnalysis(parent),
                (child, parent) => child.Parameter.ConversionOperatorParent = parent);
            returnType = new CachedChildNode<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax, ITypeReferenceWithCodeAnalysis, TypeSyntax>(
                node,
                (parentSyntax, childSyntax) => parentSyntax.WithType(childSyntax),
                parent => parent.Syntax.Type.ToTypeReference(),
                (child, parent) => { });
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

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }

        internal ClassTypeWithCodeAnalysis ClassParent
        {
            get { return node.GetParentNode<ClassTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.ConversionOperatorList);
            }
        }

        internal StructTypeWithCodeAnalysis StructParent
        {
            get { return node.GetParentNode<StructTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<StructTypeWithCodeAnalysis, StructDeclarationSyntax>(
                    value,
                    parent => parent.ConversionOperatorList);
            }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
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
