using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassPropertyWithCodeAnalysis :
        EditableStaticClassProperty<
            AttributeGroupWithCodeAnalysis,
            StaticClassWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            StaticClassAccessorWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>,
        IHasNode<PropertyDeclarationSyntax>
    {
        private readonly PropertyWithBodyWithCodeAnalysis property;

        public StaticClassPropertyWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis type,
            string name,
            MethodBodyWithCodeAnalysis getAccessor,
            MethodBodyWithCodeAnalysis setAccessor)
            : this()
        {
            List<AccessorDeclarationSyntax> accessorSyntax = new List<AccessorDeclarationSyntax>();
            if (getAccessor != null)
            {
                accessorSyntax.Add(SyntaxFactory.AccessorDeclaration(SyntaxKind.GetKeyword, getAccessor.Syntax));
            }

            if (setAccessor != null)
            {
                accessorSyntax.Add(SyntaxFactory.AccessorDeclaration(SyntaxKind.SetKeyword, setAccessor.Syntax));
            }

            Syntax = SyntaxFactory.PropertyDeclaration(
                default(SyntaxList<AttributeListSyntax>),
                default(SyntaxTokenList).WithClassMemberVisibilityModifier(visibility),
                type.Syntax,
                null,
                SyntaxFactory.Identifier(name),
                SyntaxFactory.AccessorList(SyntaxFactory.List(accessorSyntax)));
        }

        internal StaticClassPropertyWithCodeAnalysis()
        {
            property = new PropertyWithBodyWithCodeAnalysis();
        }
        
        public PropertyWithBodyWithCodeAnalysis Property
        {
            get { return property; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return property.Attributes; }
            set { property.Attributes = value; }
        }

        public override StaticClassWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? property.Property.Node.GetParentNode<StaticClassWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override StaticClassAccessorWithCodeAnalysis GetAccessor
        {
            get { return new StaticClassAccessorWithCodeAnalysis(property.GetAccessor); }
            set { property.GetAccessor = value?.Accessor; }
        }

        public override string Name
        {
            get { return property.Name; }
            set { property.Name = value; }
        }

        public override ITypeReferenceWithCodeAnalysis PropertyType
        {
            get { return property.PropertyType; }
            set { property.PropertyType = value; }
        }

        public override StaticClassAccessorWithCodeAnalysis SetAccessor
        {
            get { return new StaticClassAccessorWithCodeAnalysis(property.SetAccessor); }
            set { property.SetAccessor = value?.Accessor; }
        }

        public PropertyDeclarationSyntax Syntax
        {
            get { return property.Syntax; }
            set { property.Syntax = value; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToStaticClassMemberVisibilityModifier(); }
            set
            {
                PropertyDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStaticClassMemberVisibilityModifier(value));
            }
        }
        
        INode<PropertyDeclarationSyntax> IHasNode<PropertyDeclarationSyntax>.Node
        {
            get { return property.Property.Node; }
        }

        internal Func<StaticClassWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}
