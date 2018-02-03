using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
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
        IHasSyntax<FieldDeclarationSyntax>,
        IHasNode<FieldDeclarationSyntax>
    {
        private readonly Node<FieldGroupWithCodeAnalysis, FieldDeclarationSyntax> node;
        private readonly AttributeListWrapper<FieldGroupWithCodeAnalysis, FieldDeclarationSyntax> attributes;
        private readonly SeparatedSyntaxNodeList<
            FieldGroupWithCodeAnalysis,
            FieldDeclarationSyntax,
            FieldWithCodeAnalysis,
            VariableDeclaratorSyntax> fields;
        private readonly CachedTypeReferenceNode<FieldGroupWithCodeAnalysis, FieldDeclarationSyntax> fieldType;
        
        internal FieldGroupWithCodeAnalysis()
        {
            node = new Node<FieldGroupWithCodeAnalysis, FieldDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<FieldGroupWithCodeAnalysis, FieldDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            fields = new SeparatedSyntaxNodeList<FieldGroupWithCodeAnalysis, FieldDeclarationSyntax, FieldWithCodeAnalysis, VariableDeclaratorSyntax>(
                node,
                syntax => syntax.Declaration.Variables,
                (parentSyntax, childSyntax) => parentSyntax.WithDeclaration(parentSyntax.Declaration.WithVariables(childSyntax)),
                () => new FieldWithCodeAnalysis());
            fieldType = new CachedTypeReferenceNode<FieldGroupWithCodeAnalysis, FieldDeclarationSyntax>(
                node,
                syntax => syntax.Declaration.Type,
                (parentSyntax, childSyntax) => parentSyntax.WithDeclaration(parentSyntax.Declaration.WithType(childSyntax)));
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override IType DeclaringType
        {
            get { return node.GetParent<IType>(); }
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

        internal Node<FieldGroupWithCodeAnalysis, FieldDeclarationSyntax> Node
        {
            get { return node; }
        }

        INode<FieldDeclarationSyntax> IHasNode<FieldDeclarationSyntax>.Node => node;
    }
}
