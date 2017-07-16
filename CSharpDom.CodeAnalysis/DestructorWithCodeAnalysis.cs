using CSharpDom.Editable;
using System;
using System.Collections.Generic;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class DestructorWithCodeAnalysis :
        EditableDestructor<AttributeGroupWithCodeAnalysis, IClass, MethodBodyWithCodeAnalysis>,
        IHasSyntax<DestructorDeclarationSyntax>,
        IHasNode<DestructorDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Node<DestructorWithCodeAnalysis, DestructorDeclarationSyntax> node;
        private readonly AttributeListWrapper<DestructorWithCodeAnalysis, DestructorDeclarationSyntax> attributes;
        private readonly MethodBodyNode<DestructorWithCodeAnalysis, DestructorDeclarationSyntax> body;
        
        internal DestructorWithCodeAnalysis()
        {
            node = new Node<DestructorWithCodeAnalysis, DestructorDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<DestructorWithCodeAnalysis, DestructorDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            body = new MethodBodyNode<DestructorWithCodeAnalysis, DestructorDeclarationSyntax>(
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

        public override IClass DeclaringType
        {
            get { return node.GetParentNode<IClass>(); }
            set { throw new NotSupportedException(); }
        }
        
        public DestructorDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        INode<DestructorDeclarationSyntax> IHasNode<DestructorDeclarationSyntax>.Node
        {
            get { return node; }
        }

        internal Node<DestructorWithCodeAnalysis, DestructorDeclarationSyntax> Node
        {
            get { return node; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitDestructorWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
