using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
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

        internal SealedClassFieldWithCodeAnalysis(ClassFieldWithCodeAnalysis field)
        {
            this.field = field ?? new ClassFieldWithCodeAnalysis();
        }
        
        public FieldGroupWithCodeAnalysis Field
        {
            get { return field.Field; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return field.Attributes; }
            set { field.Attributes = value; }
        }

        public override ISealedTypeWithCodeAnalysis DeclaringType
        {
            get { return field.Field.Node.GetParentNode<ISealedTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ITypeReferenceWithCodeAnalysis FieldType
        {
            get { return field.FieldType; }
            set { field.FieldType = value; }
        }

        public override ClassFieldModifier Modifier
        {
            get { return Syntax.Modifiers.ToClassFieldModifier(); }
            set
            {
                FieldDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassFieldModifier(value));
            }
        }
        
        public override ClassMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToClassMemberVisibilityModifier(); }
            set
            {
                FieldDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberVisibilityModifier(value));
            }
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

        internal ClassFieldWithCodeAnalysis InternalField
        {
            get { return field; }
        }
    }
}
