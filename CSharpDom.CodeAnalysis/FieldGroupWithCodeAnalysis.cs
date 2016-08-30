using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class FieldGroupWithCodeAnalysis :
        EditableFieldGroup<
            AttributeGroupWithCodeAnalysis,
            IType,
            ITypeReferenceWithCodeAnalysis,
            FieldWithCodeAnalysis>,
        IHasSyntax<FieldDeclarationSyntax>
    {
        private readonly Node<FieldGroupWithCodeAnalysis, FieldDeclarationSyntax> node;
        private readonly AttributeListWrapper<FieldGroupWithCodeAnalysis, FieldDeclarationSyntax> attributes;
        private readonly SeparatedSyntaxListWrapper<
            FieldGroupWithCodeAnalysis,
            FieldDeclarationSyntax,
            FieldWithCodeAnalysis,
            VariableDeclaratorSyntax> fields;
        private readonly CachedChildNode<
            FieldGroupWithCodeAnalysis,
            FieldDeclarationSyntax,
            ITypeReferenceWithCodeAnalysis,
            TypeSyntax> fieldType;

        public FieldGroupWithCodeAnalysis()
        {
            node = new Node<FieldGroupWithCodeAnalysis, FieldDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<FieldGroupWithCodeAnalysis, FieldDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.FieldGroupParent = parent);
            fields = new SeparatedSyntaxListWrapper<FieldGroupWithCodeAnalysis, FieldDeclarationSyntax, FieldWithCodeAnalysis, VariableDeclaratorSyntax>(
                node,
                syntax => syntax.Declaration.Variables,
                (parentSyntax, childSyntax) => parentSyntax.WithDeclaration(parentSyntax.Declaration.WithVariables(childSyntax)),
                parent => new FieldWithCodeAnalysis(parent),
                (child, parent) => child.Parent = parent);
            fieldType = new CachedChildNode<FieldGroupWithCodeAnalysis, FieldDeclarationSyntax, ITypeReferenceWithCodeAnalysis, TypeSyntax>(
                node,
                null,
                (parentSyntax, childSyntax) => parentSyntax.WithDeclaration(parentSyntax.Declaration.WithType(childSyntax)),
                null);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { Syntax = Syntax.WithAttributeLists(value.ToAttributes()); }
        }

        public override IType DeclaringType
        {
            get { return base.DeclaringType; }
            set { throw new NotSupportedException(); }
        }

        public override ICollection<FieldWithCodeAnalysis> Fields
        {
            get { return fields; }
            set
            {
                FieldDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithDeclaration(
                    syntax.Declaration.WithVariables(SyntaxFactory.SeparatedList(value.Select(node => node.Syntax))));
            }
        }

        public override ITypeReferenceWithCodeAnalysis FieldType
        {
            get { return fieldType.Value; }
            set { fieldType.Value = value; }
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

        internal IChildCollection<FieldWithCodeAnalysis, VariableDeclaratorSyntax> FieldList
        {
            get { return fields; }
        }
    }
}
