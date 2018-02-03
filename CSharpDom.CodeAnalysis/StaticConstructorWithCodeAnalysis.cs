using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticConstructorWithCodeAnalysis :
        EditableStaticConstructor<AttributeGroupWithCodeAnalysis, IType, MethodBodyWithCodeAnalysis>,
        IHasSyntax<ConstructorDeclarationSyntax>,
        IHasNode<ConstructorDeclarationSyntax>
    {
        private readonly Node<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> node;
        private readonly AttributeListWrapper<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> attributes;
        private readonly MethodBodyNode<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> body;

        internal StaticConstructorWithCodeAnalysis()
        {
            node = new Node<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            body = new MethodBodyNode<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                node,
                syntax => syntax.Body,
                (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
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
            get { return node.GetParent<IType>(); }
            set { throw new NotSupportedException(); }
        }

        public ConstructorDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        INode<ConstructorDeclarationSyntax> IHasNode<ConstructorDeclarationSyntax>.Node
        {
            get { return node; }
        }

        internal Node<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> Node
        {
            get { return node; }
        }
    }
}
