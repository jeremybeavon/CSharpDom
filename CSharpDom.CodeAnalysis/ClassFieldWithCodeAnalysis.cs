using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using System.Reflection;
using CSharpDom.NotSupported;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassFieldWithCodeAnalysis :
        EditableClassField<
            AttributeGroupWithCodeAnalysis,
            IClassTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            FieldWithCodeAnalysis>,
        IHasSyntax<FieldDeclarationSyntax>,
        IHasNode<FieldDeclarationSyntax>
    {
        private readonly FieldGroupWithCodeAnalysis field;

        public ClassFieldWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis type,
            params string[] names)
            : this()
        {
            Syntax = SyntaxFactory.FieldDeclaration(
                default(SyntaxList<AttributeListSyntax>),
                default(SyntaxTokenList).WithClassMemberVisibilityModifier(visibility),
                SyntaxFactory.VariableDeclaration(type.Syntax, SyntaxFactory.SeparatedList(names.Select(SyntaxFactory.VariableDeclarator))));
        }

        internal ClassFieldWithCodeAnalysis()
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

        public override IClassTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? field.Node.GetParentNode<IClassTypeWithCodeAnalysis>(); }
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
            get { return field.Node; }
        }

        internal Func<IClassTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}
