using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticConstructorWithCodeAnalysis :
        EditableStaticConstructor<AttributeGroupWithCodeAnalysis, IType, MethodBodyWithCodeAnalysis>,
        IHasSyntax<ConstructorDeclarationSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly Node<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> node;
        private readonly AttributeListWrapper<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> attributes;
        private readonly MethodBodyNode<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> body;

        internal StaticConstructorWithCodeAnalysis(ClassTypeWithCodeAnalysis parent)
            : this()
        {
            ClassParent = parent;
        }

        internal StaticConstructorWithCodeAnalysis(StaticTypeWithCodeAnalysis parent)
            : this()
        {
            StaticClassParent = parent;
        }

        internal StaticConstructorWithCodeAnalysis(StructTypeWithCodeAnalysis parent)
            : this()
        {
            StructParent = parent;
        }

        private StaticConstructorWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new Node<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.StaticConstructorParent = parent);
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
            get { return node.GetParentNode<IType>(); }
            set { throw new NotSupportedException(); }
        }

        public ConstructorDeclarationSyntax Syntax
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
                    parent => parent.StaticConstructorList);
            }
        }

        internal StaticTypeWithCodeAnalysis StaticClassParent
        {
            get { return node.GetParentNode<StaticTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.StaticConstructorList);
            }
        }

        internal StructTypeWithCodeAnalysis StructParent
        {
            get { return node.GetParentNode<StructTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<StructTypeWithCodeAnalysis, StructDeclarationSyntax>(
                    value,
                    parent => parent.StaticConstructorList);
            }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }
    }
}
