using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class NestedStaticPartialClassPropertyWithCodeAnalysis :
        EditableStaticClassProperty<
            AttributeGroupWithCodeAnalysis,
            INestedStaticPartialTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            StaticClassAccessorWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>
    {
        private readonly NestedStaticClassPropertyWithCodeAnalysis property;

        public NestedStaticPartialClassPropertyWithCodeAnalysis(
            StaticClassMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis type,
            string name,
            MethodBodyWithCodeAnalysis getAccessor,
            MethodBodyWithCodeAnalysis setAccessor)
            : this(new NestedStaticClassPropertyWithCodeAnalysis(visibility, type, name, getAccessor, setAccessor))
        {
        }

        internal NestedStaticPartialClassPropertyWithCodeAnalysis(NestedStaticClassPropertyWithCodeAnalysis property)
        {
            this.property = property;
            property.DeclaringTypeFunc = () => DeclaringType.Class;
        }
        
        public NestedStaticClassPropertyWithCodeAnalysis Property
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
            get { return property.Property.Property.Node.GetParentNode<INestedStaticPartialTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override StaticClassAccessorWithCodeAnalysis GetAccessor
        {
            get { return property.GetAccessor; }
            set { property.GetAccessor = value; }
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
            get { return property.SetAccessor; }
            set { property.SetAccessor = value; }
        }

        public PropertyDeclarationSyntax Syntax
        {
            get { return property.Syntax; }
            set { property.Syntax = value; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return property.Visibility; }
            set { property.Visibility = value; }
        }
    }
}
