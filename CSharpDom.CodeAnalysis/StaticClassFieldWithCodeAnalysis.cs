﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassFieldWithCodeAnalysis :
        EditableStaticClassField<
            AttributeGroupWithCodeAnalysis,
            IStaticType,
            ITypeReferenceWithCodeAnalysis,
            FieldWithCodeAnalysis>,
        IHasSyntax<FieldDeclarationSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly FieldGroupWithCodeAnalysis field;

        internal StaticClassFieldWithCodeAnalysis(StaticTypeWithCodeAnalysis parent)
            : this()
        {
            field = new CodeAnalysis.FieldGroupWithCodeAnalysis(parent, this);
        }

        private StaticClassFieldWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
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

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }
    }
}
