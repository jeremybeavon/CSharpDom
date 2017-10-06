using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialStructPropertyWithCodeAnalysis :
        EditableStructProperty<
            AttributeGroupWithCodeAnalysis,
            IPartialStructTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            StructAccessorWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>
    {
        private readonly StructPropertyWithCodeAnalysis property;

        public PartialStructPropertyWithCodeAnalysis(
            StructMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis type,
            string name,
            MethodBodyWithCodeAnalysis getAccessor,
            MethodBodyWithCodeAnalysis setAccessor)
            : this(new StructPropertyWithCodeAnalysis(visibility, type, name, getAccessor, setAccessor))
        {
        }

        internal PartialStructPropertyWithCodeAnalysis(StructPropertyWithCodeAnalysis property)
        {
            this.property = property;
            property.DeclaringTypeFunc = () => DeclaringType.Struct;
        }
        
        public StructPropertyWithCodeAnalysis Property
        {
            get { return property; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return property.Attributes; }
            set { property.Attributes = value; }
        }

        public override IPartialStructTypeWithCodeAnalysis DeclaringType
        {
            get { return property.Property.Property.Node.GetParentNode<IPartialStructTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override StructAccessorWithCodeAnalysis GetAccessor
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

        public override StructAccessorWithCodeAnalysis SetAccessor
        {
            get { return property.SetAccessor; }
            set { property.SetAccessor = value; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return property.Visibility; }
            set { property.Visibility = value; }
        }

        public override StructMemberInheritanceModifier InheritanceModifier
        {
            get { return property.InheritanceModifier; }
            set { property.InheritanceModifier = value; }
        }

        public PropertyDeclarationSyntax Syntax
        {
            get { return property.Syntax; }
            set { property.Syntax = value; }
        }
    }
}
