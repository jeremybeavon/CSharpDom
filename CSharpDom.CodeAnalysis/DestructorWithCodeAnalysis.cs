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
        INestedDestructor//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Node<DestructorWithCodeAnalysis, DestructorDeclarationSyntax> node;
        private readonly AttributeListWrapper<DestructorWithCodeAnalysis, DestructorDeclarationSyntax> attributes;
        private readonly MethodBodyNode<DestructorWithCodeAnalysis, DestructorDeclarationSyntax> body;
        
        internal DestructorWithCodeAnalysis(IClass declaringType)
        {
            node = new Node<DestructorWithCodeAnalysis, DestructorDeclarationSyntax>(this);
            base.DeclaringType = declaringType;
            attributes = new AttributeListWrapper<DestructorWithCodeAnalysis, DestructorDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.DestructorParent = parent);
            body = new MethodBodyNode<DestructorWithCodeAnalysis, DestructorDeclarationSyntax>(
                node,
                (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax),
                parent => new MethodBodyWithCodeAnalysis(parent),
                (child, parent) => child.DestructorParent = parent);
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
            get { return base.DeclaringType; }
            set { throw new NotSupportedException(); }
        }
        
        public DestructorDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
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
