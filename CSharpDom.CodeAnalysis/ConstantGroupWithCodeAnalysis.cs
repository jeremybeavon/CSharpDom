using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
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
        IHasNode<FieldDeclarationSyntax>
    {
        private readonly Node<ConstantGroupWithCodeAnalysis, FieldDeclarationSyntax> node;
        private readonly AttributeListWrapper<ConstantGroupWithCodeAnalysis, FieldDeclarationSyntax> attributes;
        private readonly SeparatedSyntaxNodeList<
            ConstantGroupWithCodeAnalysis,
            FieldDeclarationSyntax,
            ConstantWithCodeAnalysis,
            VariableDeclaratorSyntax> constants;
        private readonly CachedTypeReferenceNode<ConstantGroupWithCodeAnalysis, FieldDeclarationSyntax> constantType;
        
        internal ConstantGroupWithCodeAnalysis()
        {
            node = new Node<ConstantGroupWithCodeAnalysis, FieldDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<ConstantGroupWithCodeAnalysis, FieldDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            constants = new SeparatedSyntaxNodeList<ConstantGroupWithCodeAnalysis, FieldDeclarationSyntax, ConstantWithCodeAnalysis, VariableDeclaratorSyntax>(
                node,
                syntax => syntax.Declaration.Variables,
                (parentSyntax, childSyntax) => parentSyntax.WithDeclaration(parentSyntax.Declaration.WithVariables(childSyntax)),
                () => new ConstantWithCodeAnalysis());
            constantType = new CachedTypeReferenceNode<ConstantGroupWithCodeAnalysis, FieldDeclarationSyntax>(
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

        internal Node<ConstantGroupWithCodeAnalysis, FieldDeclarationSyntax> Node
        {
            get { return node; }
        }

        INode<FieldDeclarationSyntax> IHasNode<FieldDeclarationSyntax>.Node => node;
    }
}
