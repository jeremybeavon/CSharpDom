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
        private readonly AttributeListWrapper<ParameterWithCodeAnalysis, ParameterSyntax> attributes;
        private readonly CachedChildNode<ParameterWithCodeAnalysis, ParameterSyntax, ITypeReferenceWithCodeAnalysis> parameterType;

        internal ParameterWithCodeAnalysis(ConversionOperatorWithCodeAnalysis parent)
            : this()
        {

        }

        internal ParameterWithCodeAnalysis(OperatorOverloadWithCodeAnalysis parent)
            : this()
        {
            OperatorOverloadParent = parent;
        }

        private ParameterWithCodeAnalysis()
        {
            node = new Node<ParameterWithCodeAnalysis, ParameterSyntax>(this);
            attributes = new AttributeListWrapper<ParameterWithCodeAnalysis, ParameterSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.ParameterParent = parent);
            parameterType = new CachedChildNode<ParameterWithCodeAnalysis, ParameterSyntax, ITypeReferenceWithCodeAnalysis>(
                node,
                syntax => syntax.Type.ToTypeReference(),
                (parentSyntax, childSyntax) => parentSyntax.WithType(childSyntax.Syntax),
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

        internal ConversionOperatorWithCodeAnalysis ConversionOperatorParent
        {
            get { return node.GetParentNode<ConversionOperatorWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax>(
                    value,
                    parent => parent.ParameterList);
            }
        }

        internal OperatorOverloadWithCodeAnalysis OperatorOverloadParent
        {
            get { return node.GetParentNode<OperatorOverloadWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax>(
                    value,
                    parent => parent.ParameterList);
            }
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
