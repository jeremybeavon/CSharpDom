using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NestedEnumWithCodeAnalysis :
        EditableNestedEnum<AttributeGroupWithCodeAnalysis, IType, NestedEnumMemberWithCodeAnalysis>,
        IHasSyntax<EnumDeclarationSyntax>,
        ISimpleMember
    {
        private readonly object @enum;
        private readonly Node<NestedEnumWithCodeAnalysis, EnumDeclarationSyntax> node;
        private readonly AttributeListWrapper<NestedEnumWithCodeAnalysis, EnumDeclarationSyntax> attributes;

        internal NestedEnumWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ClassNestedEnumWithCodeAnalysis @enum)
            : this(@enum)
        {
            ClassParent = parent;
        }

        internal NestedEnumWithCodeAnalysis(StaticTypeWithCodeAnalysis parent, StaticClassNestedEnumWithCodeAnalysis @enum)
            : this(@enum)
        {
            StaticClassParent = parent;
        }

        internal NestedEnumWithCodeAnalysis(StructTypeWithCodeAnalysis parent, StructNestedEnumWithCodeAnalysis @enum)
            : this(@enum)
        {
            StructParent = parent;
        }

        private NestedEnumWithCodeAnalysis(object @enum)
        {
            node = new Node<NestedEnumWithCodeAnalysis, EnumDeclarationSyntax>(this);
            this.@enum = @enum;
            attributes = new AttributeListWrapper<NestedEnumWithCodeAnalysis, EnumDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.NestedEnumParent = parent);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override EnumBaseType BaseType
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

        public override IList<NestedEnumMemberWithCodeAnalysis> EnumMembers
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

        public override string Name
        {
            get { return Syntax.Identifier.Text; }
            set { Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public EnumDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal Node<NestedEnumWithCodeAnalysis, EnumDeclarationSyntax> Node
        {
            get { return node; }
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
                    parent => parent.EnumList);
            }
        }

        internal StaticTypeWithCodeAnalysis StaticClassParent
        {
            get { return node.GetParentNode<StaticTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.EnumList);
            }
        }

        internal StructTypeWithCodeAnalysis StructParent
        {
            get { return node.GetParentNode<StructTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<StructTypeWithCodeAnalysis, StructDeclarationSyntax>(
                    value,
                    parent => parent.EnumList);
            }
        }

        T ISimpleMember.Member<T>()
        {
            return (T)@enum;
        }
    }
}
