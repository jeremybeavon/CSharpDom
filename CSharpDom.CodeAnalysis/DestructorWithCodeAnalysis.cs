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
        INestedDestructor,
        IHasId//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Guid internalId;
        private readonly SimpleNode<
            ClassTypeWithCodeAnalysis,
            ClassDeclarationSyntax,
            DestructorWithCodeAnalysis,
            DestructorDeclarationSyntax> node;
        private readonly AttributeListWrapper<DestructorWithCodeAnalysis, DestructorDeclarationSyntax> attributes;
        private readonly MethodBodyNode<DestructorWithCodeAnalysis, DestructorDeclarationSyntax> body;
        
        internal DestructorWithCodeAnalysis(ClassTypeWithCodeAnalysis parent)
        {
            internalId = Guid.NewGuid();
            node = new SimpleNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax, DestructorWithCodeAnalysis, DestructorDeclarationSyntax>(
                parent,
                this,
                newParent => newParent.DestructorList);
            attributes = new AttributeListWrapper<DestructorWithCodeAnalysis, DestructorDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                newParent => new AttributeGroupWithCodeAnalysis(newParent),
                (child, newParent) => child.DestructorParent = newParent);
            body = new MethodBodyNode<DestructorWithCodeAnalysis, DestructorDeclarationSyntax>(
                node,
                (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax),
                newParent => new MethodBodyWithCodeAnalysis(newParent),
                (child, newParent) => child.DestructorParent = newParent);
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

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }
        
        internal ClassTypeWithCodeAnalysis ClassParent
        {
            get { return node.Parent; }
            set { node.Parent = value; }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
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
