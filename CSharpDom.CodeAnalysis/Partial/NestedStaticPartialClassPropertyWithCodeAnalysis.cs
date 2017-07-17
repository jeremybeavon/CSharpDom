using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class NestedStaticPartialClassPropertyWithCodeAnalysis :
        EditableStaticClassProperty<
            AttributeGroupWithCodeAnalysis,
            INestedStaticPartialTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            StaticClassAccessorWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>,
        IHasNode<PropertyDeclarationSyntax>
    {
        private readonly PropertyWithBodyWithCodeAnalysis property;
        
        internal NestedStaticPartialClassPropertyWithCodeAnalysis()
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

        public override INestedStaticPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return property.Property.Node.GetParentNode<INestedStaticPartialTypeWithCodeAnalysis>(); }
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
    }
}
