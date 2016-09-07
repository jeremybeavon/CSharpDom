using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ConstantGroupWithCodeAnalysis :
        EditableConstantGroup<
            AttributeGroupWithCodeAnalysis,
            IType,
            ITypeReferenceWithCodeAnalysis,
            ConstantWithCodeAnalysis>,
        IHasSyntax<FieldDeclarationSyntax>,
        ISimpleMember
    {
        private readonly object constant;
        private readonly Node<ConstantGroupWithCodeAnalysis, FieldDeclarationSyntax> node;
        private readonly AttributeListWrapper<ConstantGroupWithCodeAnalysis, FieldDeclarationSyntax> attributes;
        private readonly SeparatedSyntaxListWrapper<
            ConstantGroupWithCodeAnalysis,
            FieldDeclarationSyntax,
            ConstantWithCodeAnalysis,
            VariableDeclaratorSyntax> constants;
        private readonly CachedChildNode<
            ConstantGroupWithCodeAnalysis,
            FieldDeclarationSyntax,
            ITypeReferenceWithCodeAnalysis,
            TypeSyntax> constantType;

        internal ConstantGroupWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ClassConstantWithCodeAnalysis constant)
            : this(constant)
        {
            ClassParent = parent;
        }

        internal ConstantGroupWithCodeAnalysis(StaticTypeWithCodeAnalysis parent, StaticClassConstantWithCodeAnalysis constant)
            : this(constant)
        {
            StaticClassParent = parent;
        }

        internal ConstantGroupWithCodeAnalysis(StructTypeWithCodeAnalysis parent, StructConstantWithCodeAnalysis constant)
            : this(constant)
        {
            StructParent = parent;
        }

        private ConstantGroupWithCodeAnalysis(object constant)
        {
            this.constant = constant;
            node = new Node<ConstantGroupWithCodeAnalysis, FieldDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<ConstantGroupWithCodeAnalysis, FieldDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.ConstantGroupParent = parent);
            constants = new SeparatedSyntaxListWrapper<ConstantGroupWithCodeAnalysis, FieldDeclarationSyntax, ConstantWithCodeAnalysis, VariableDeclaratorSyntax>(
                node,
                syntax => syntax.Declaration.Variables,
                (parentSyntax, childSyntax) => parentSyntax.WithDeclaration(parentSyntax.Declaration.WithVariables(childSyntax)),
                parent => new ConstantWithCodeAnalysis(parent),
                (child, parent) => child.Parent = parent);
            constantType = new CachedChildNode<ConstantGroupWithCodeAnalysis, FieldDeclarationSyntax, ITypeReferenceWithCodeAnalysis, TypeSyntax>(
                node,
                (parentSyntax, childSyntax) => parentSyntax.WithDeclaration(parentSyntax.Declaration.WithType(childSyntax)),
                null,
                null);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override IType DeclaringType
        {
            get { return base.DeclaringType; }
            set { throw new NotSupportedException(); }
        }

        public override ICollection<ConstantWithCodeAnalysis> Constants
        {
            get { return constants; }
            set
            {
                FieldDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithDeclaration(
                    syntax.Declaration.WithVariables(SyntaxFactory.SeparatedList(value.Select(node => node.Syntax))));
            }
        }

        public override ITypeReferenceWithCodeAnalysis FieldType
        {
            get { return constantType.Value; }
            set { constantType.Value = value; }
        }

        public FieldDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }

        internal IChildCollection<ConstantWithCodeAnalysis, VariableDeclaratorSyntax> FieldList
        {
            get { return constants; }
        }

        internal ClassTypeWithCodeAnalysis ClassParent
        {
            get { return node.GetParentNode<ClassTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.Fields.ConstantList);
            }
        }

        internal StaticTypeWithCodeAnalysis StaticClassParent
        {
            get { return node.GetParentNode<StaticTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.Fields.ConstantList);
            }
        }

        internal StructTypeWithCodeAnalysis StructParent
        {
            get { return node.GetParentNode<StructTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<StructTypeWithCodeAnalysis, StructDeclarationSyntax>(
                    value,
                    parent => parent.Fields.ConstantList);
            }
        }

        T ISimpleMember.Member<T>()
        {
            return (T)constant;
        }
    }
}
