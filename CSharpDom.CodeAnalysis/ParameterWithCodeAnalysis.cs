using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ParameterWithCodeAnalysis :
        EditableParameter<AttributeGroupWithCodeAnalysis, ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<ParameterSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Node<ParameterWithCodeAnalysis, ParameterSyntax> node;
        private readonly object wrapper;
        private readonly AttributeListWrapper<ParameterWithCodeAnalysis, ParameterSyntax> attributes;
        private readonly CachedChildNode<ParameterWithCodeAnalysis, ParameterSyntax, ITypeReferenceWithCodeAnalysis> parameterType;

        internal ParameterWithCodeAnalysis(ConstructorWithCodeAnalysis parent, ConstructorParameterWithCodeAnalysis parameter)
            : this(parameter)
        {
            ConstructorParent = parent;
        }

        internal ParameterWithCodeAnalysis(ConversionOperatorWithCodeAnalysis parent, OperatorParameterWithCodeAnalysis parameter)
            : this(parameter)
        {
            ConversionOperatorParent = parent;
        }

        internal ParameterWithCodeAnalysis(IndexerWithCodeAnalysis parent, IndexerParameterWithCodeAnalysis parameter)
            : this(parameter)
        {
            IndexerParent = parent;
        }

        internal ParameterWithCodeAnalysis(MethodWithCodeAnalysis parent, MethodParameterWithCodeAnalysis parameter)
            : this(parameter)
        {
            MethodParent = parent;
        }

        internal ParameterWithCodeAnalysis(OperatorOverloadWithCodeAnalysis parent, OperatorParameterWithCodeAnalysis parameter)
            : this(parameter)
        {
            OperatorOverloadParent = parent;
        }

        private ParameterWithCodeAnalysis(object parameter)
        {
            node = new Node<ParameterWithCodeAnalysis, ParameterSyntax>(this);
            wrapper = parameter;
            attributes = new AttributeListWrapper<ParameterWithCodeAnalysis, ParameterSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.ParameterParent = parent);
            parameterType = new CachedChildNode<ParameterWithCodeAnalysis, ParameterSyntax, ITypeReferenceWithCodeAnalysis>(
                node,
                parent => parent.Syntax.Type.ToTypeReference(),
                (parent, child) => parent.Syntax.WithType(child.Syntax),
                null);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { Syntax = Syntax.WithAttributeLists(value.ToAttributes()); }
        }

        public override string Name
        {
            get { return Syntax.Identifier.Text; }
            set { Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public override ITypeReferenceWithCodeAnalysis ParameterType
        {
            get { return parameterType.Value; }
            set { parameterType.Value = value; }
        }
        
        public ParameterSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }

        internal ConstructorWithCodeAnalysis ConstructorParent
        {
            get { return node.GetParentNode<ConstructorWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ConstructorWithCodeAnalysis, ConstructorDeclarationSyntax, ConstructorParameterWithCodeAnalysis>(
                    value,
                    (ConstructorParameterWithCodeAnalysis)wrapper,
                    parent => parent.ParameterList);
            }
        }

        internal ConversionOperatorWithCodeAnalysis ConversionOperatorParent
        {
            get { return node.GetParentNode<ConversionOperatorWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax>(
                    value,
                    syntax => syntax.ParameterList.Parameters[0],
                    WithParameter);
            }
        }

        internal IndexerWithCodeAnalysis IndexerParent
        {
            get { return node.GetParentNode<IndexerWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<IndexerWithCodeAnalysis, IndexerDeclarationSyntax, IndexerParameterWithCodeAnalysis>(
                    value,
                    (IndexerParameterWithCodeAnalysis)wrapper,
                    parent => parent.ParameterList);
            }
        }

        internal MethodWithCodeAnalysis MethodParent
        {
            get { return node.GetParentNode<MethodWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<MethodWithCodeAnalysis, MethodDeclarationSyntax, MethodParameterWithCodeAnalysis>(
                    value,
                    (MethodParameterWithCodeAnalysis)wrapper,
                    parent => parent.ParameterList);
            }
        }

        internal OperatorOverloadWithCodeAnalysis OperatorOverloadParent
        {
            get { return node.GetParentNode<OperatorOverloadWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax, OperatorParameterWithCodeAnalysis>(
                    value,
                    (OperatorParameterWithCodeAnalysis)wrapper,
                    parent => parent.ParameterList);
            }
        }

        private static ConversionOperatorDeclarationSyntax WithParameter(
            ConversionOperatorDeclarationSyntax parentSyntax,
            ParameterSyntax childSyntax)
        {
            return parentSyntax.WithParameterList(
                parentSyntax.ParameterList.WithParameters(SyntaxFactory.SeparatedList(new[] { childSyntax })));
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitParameterWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
