using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using CSharpDom.NotSupported;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructFieldWithCodeAnalysis :
        EditableStructField<
            AttributeGroupWithCodeAnalysis,
            IStructTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            FieldWithCodeAnalysis>,
        IHasSyntax<FieldDeclarationSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly FieldGroupWithCodeAnalysis field;

        internal StructFieldWithCodeAnalysis(StructTypeWithCodeAnalysis parent)
            : this()
        {
            field = new FieldGroupWithCodeAnalysis(parent, this);
        }

        private StructFieldWithCodeAnalysis()
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

        public override IStructTypeWithCodeAnalysis DeclaringType
        {
            get { return field.Node.GetParentNode<IStructTypeWithCodeAnalysis>(); }
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
        
        public override StructFieldModifier Modifier
        {
            get
            {
                switch (Syntax.Modifiers.ToClassFieldModifier())
                {
                    case ClassFieldModifier.None:
                        return StructFieldModifier.None;
                    case ClassFieldModifier.ReadOnly:
                        return StructFieldModifier.ReadOnly;
                    case ClassFieldModifier.Static:
                        return StructFieldModifier.Static;
                    case ClassFieldModifier.StaticReadOnly:
                        return StructFieldModifier.StaticReadOnly;
                    case ClassFieldModifier.StaticVolatile:
                        return StructFieldModifier.StaticVolatile;
                    case ClassFieldModifier.Volatile:
                        return StructFieldModifier.Volatile;
                    default:
                        throw new NotSupportedException();
                }
            }
            set
            {
                FieldDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassFieldModifier(ToClassFieldModifier(value)));
            }
        }
        
        public FieldDeclarationSyntax Syntax
        {
            get { return field.Syntax; }
            set { field.Syntax = value; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToStructMemberVisibilityModifier(); }
            set
            {
                FieldDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStructMemberVisibilityModifier(value));
            }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }

        private static ClassFieldModifier ToClassFieldModifier(StructFieldModifier modifier)
        {
            switch (modifier)
            {
                case StructFieldModifier.None:
                    return ClassFieldModifier.None;
                case StructFieldModifier.ReadOnly:
                    return ClassFieldModifier.ReadOnly;
                case StructFieldModifier.Static:
                    return ClassFieldModifier.Static;
                case StructFieldModifier.StaticReadOnly:
                    return ClassFieldModifier.StaticReadOnly;
                case StructFieldModifier.StaticVolatile:
                    return ClassFieldModifier.StaticVolatile;
                case StructFieldModifier.Volatile:
                    return ClassFieldModifier.Volatile;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
