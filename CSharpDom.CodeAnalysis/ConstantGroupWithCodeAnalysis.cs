﻿using System;
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
        IHasSyntax<FieldDeclarationSyntax>
    {
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

        public ConstantGroupWithCodeAnalysis()
        {
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
    }
}
