using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructNestedEnumWithCodeAnalysis :
        EditableStructNestedEnum<
            AttributeGroupWithCodeAnalysis,
            IStructTypeWithCodeAnalysis,
            NestedEnumMemberWithCodeAnalysis>,
        IHasSyntax<EnumDeclarationSyntax>,
        IHasNode<EnumDeclarationSyntax>
    {
        private readonly NestedEnumWithCodeAnalysis nestedEnum;

        public StructNestedEnumWithCodeAnalysis(
            StructMemberVisibilityModifier visibility,
            string name)
            : this()
        {
            Syntax = SyntaxFactory.EnumDeclaration(
                default(SyntaxList<AttributeListSyntax>),
                default(SyntaxTokenList).WithStructMemberVisibilityModifier(visibility),
                SyntaxFactory.Identifier(name),
                null,
                default(SeparatedSyntaxList<EnumMemberDeclarationSyntax>));
        }

        internal StructNestedEnumWithCodeAnalysis()
        {
            nestedEnum = new NestedEnumWithCodeAnalysis();
        }
        
        public NestedEnumWithCodeAnalysis Enum
        {
            get { return nestedEnum; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return nestedEnum.Attributes; }
            set { nestedEnum.Attributes = value; }
        }

        public override EnumBaseType BaseType
        {
            get { return nestedEnum.BaseType; }
            set { nestedEnum.BaseType = value; }
        }

        public override IStructTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? nestedEnum.Node.GetParentNode<IStructTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override IList<NestedEnumMemberWithCodeAnalysis> EnumMembers
        {
            get { return nestedEnum.EnumMembers; }
            set { nestedEnum.EnumMembers = value; }
        }

        public override string Name
        {
            get { return nestedEnum.Name; }
            set { nestedEnum.Name = value; }
        }

        public EnumDeclarationSyntax Syntax
        {
            get { return nestedEnum.Syntax; }
            set { nestedEnum.Syntax = value; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToStructMemberVisibilityModifier(); }
            set
            {
                EnumDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStructMemberVisibilityModifier(value));
            }
        }
        
        INode<EnumDeclarationSyntax> IHasNode<EnumDeclarationSyntax>.Node
        {
            get { return nestedEnum.Node; }
        }

        internal Func<IStructTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}
