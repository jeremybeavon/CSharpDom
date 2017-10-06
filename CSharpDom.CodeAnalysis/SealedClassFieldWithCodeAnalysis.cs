using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using System.Reflection;
using CSharpDom.NotSupported;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassFieldWithCodeAnalysis :
        EditableClassField<
            AttributeGroupWithCodeAnalysis,
            ISealedTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            FieldWithCodeAnalysis>,
        IHasSyntax<FieldDeclarationSyntax>,
        IHasNode<FieldDeclarationSyntax>
    {
        private readonly ClassFieldWithCodeAnalysis field;

        public SealedClassFieldWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis type,
            params string[] names)
            : this(new ClassFieldWithCodeAnalysis(visibility, type, names))
        {
        }

        internal SealedClassFieldWithCodeAnalysis(ClassFieldWithCodeAnalysis field)
        {
            this.field = field ?? new ClassFieldWithCodeAnalysis();
            field.DeclaringTypeFunc = () => DeclaringType.Class;
        }
        
        public ClassFieldWithCodeAnalysis Field
        {
            get { return field; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return field.Attributes; }
            set { field.Attributes = value; }
        }

        public override ISealedTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? field.Field.Node.GetParentNode<ISealedTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ITypeReferenceWithCodeAnalysis FieldType
        {
            get { return field.FieldType; }
            set { field.FieldType = value; }
        }

        public override ClassFieldModifier Modifier
        {
            get { return field.Modifier; }
            set { field.Modifier = value; }
        }
        
        public override ClassMemberVisibilityModifier Visibility
        {
            get { return field.Visibility; }
            set { field.Visibility = value; }
        }

        public override ICollection<FieldWithCodeAnalysis> Fields
        {
            get { return field.Fields; }
            set { field.Fields = value; }
        }
        
        public FieldDeclarationSyntax Syntax
        {
            get { return field.Syntax; }
            set { field.Syntax = value; }
        }
        
        INode<FieldDeclarationSyntax> IHasNode<FieldDeclarationSyntax>.Node
        {
            get { return field.Field.Node; }
        }

        internal Func<ISealedTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}
