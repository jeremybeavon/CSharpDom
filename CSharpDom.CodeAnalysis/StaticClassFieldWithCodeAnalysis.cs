﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassFieldWithCodeAnalysis :
        EditableStaticClassField<
            AttributeGroupWithCodeAnalysis,
            StaticClassWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            FieldWithCodeAnalysis>,
        IHasSyntax<FieldDeclarationSyntax>,
        IHasNode<FieldDeclarationSyntax>
    {
        private readonly FieldGroupWithCodeAnalysis field;

        public StaticClassFieldWithCodeAnalysis(
            StaticClassMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis type,
            params string[] names)
            : this()
        {
            Syntax = SyntaxFactory.FieldDeclaration(
                default(SyntaxList<AttributeListSyntax>),
                default(SyntaxTokenList).WithStaticClassMemberVisibilityModifier(visibility),
                SyntaxFactory.VariableDeclaration(type.Syntax, SyntaxFactory.SeparatedList(names.Select(SyntaxFactory.VariableDeclarator))));
        }

        internal StaticClassFieldWithCodeAnalysis()
        {
            field = new FieldGroupWithCodeAnalysis();
        }
        
        public FieldGroupWithCodeAnalysis Field
        {
            get { return field; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return field.Attributes; }
            set { field.Attributes = value; }
        }

        public override StaticClassWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? field.Node.GetParent<StaticClassWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ICollection<FieldWithCodeAnalysis> Fields
        {
            get { return field.Fields; }
            set { field.Fields = value; }
        }

        public override ITypeReferenceWithCodeAnalysis FieldType
        {
            get { return field.FieldType; }
            set { field.FieldType = value; }
        }
        
        public override StaticClassFieldModifier Modifier
        {
            get
            {
                SyntaxTokenList modifiers = Syntax.Modifiers;
                if (modifiers.Any(SyntaxKind.ReadOnlyKeyword))
                {
                    return StaticClassFieldModifier.ReadOnly;
                }

                if (modifiers.Any(SyntaxKind.VolatileKeyword))
                {
                    return StaticClassFieldModifier.Volatile;
                }

                return StaticClassFieldModifier.None;
            }
            set
            {
                FieldDeclarationSyntax syntax = Syntax;
                SyntaxTokenList tokens = syntax.Modifiers.Remove(SyntaxKind.ReadOnlyKeyword).Remove(SyntaxKind.VolatileKeyword);
                switch (value)
                {
                    case StaticClassFieldModifier.ReadOnly:
                        tokens = tokens.Add(SyntaxKind.ReadOnlyKeyword);
                        break;
                    case StaticClassFieldModifier.Volatile:
                        tokens = tokens.Add(SyntaxKind.VolatileKeyword);
                        break;
                }

                Syntax = syntax.WithModifiers(tokens);
            }
        }
        
        public FieldDeclarationSyntax Syntax
        {
            get { return field.Syntax; }
            set { field.Syntax = value; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToStaticClassMemberVisibilityModifier(); }
            set
            {
                FieldDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStaticClassMemberVisibilityModifier(value));
            }
        }
        
        INode<FieldDeclarationSyntax> IHasNode<FieldDeclarationSyntax>.Node
        {
            get { return field.Node; }
        }

        internal Func<StaticClassWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}
