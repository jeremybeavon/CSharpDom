using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassAutoPropertyWithCodeAnalysis :
        EditableStaticClassAutoProperty<
            AttributeGroupWithCodeAnalysis,
            StaticPartialClassWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            StaticClassAutoPropertyAccessorWithCodeAnalysis,
            IExpressionWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>,
        IHasNode<PropertyDeclarationSyntax>
    {
        private readonly StaticClassAutoPropertyWithCodeAnalysis property;
        
        internal StaticPartialClassAutoPropertyWithCodeAnalysis(StaticClassAutoPropertyWithCodeAnalysis property)
        {
            this.property = property;
            property.DeclaringTypeFunc = () => DeclaringType.Class;
        }
        
        public StaticClassAutoPropertyWithCodeAnalysis Property
        {
            get { return property; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return property.Attributes; }
            set { property.Attributes = value; }
        }

        public override StaticPartialClassWithCodeAnalysis DeclaringType
        {
            get { return property.Property.Property.Node.GetParent<StaticPartialClassWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override StaticClassAutoPropertyAccessorWithCodeAnalysis GetAccessor
        {
            get { return property.GetAccessor; }
            set { property.GetAccessor = value; }
        }

        public override IExpressionWithCodeAnalysis InitialValue
        {
            get => property.InitialValue;
            set => property.InitialValue = value;
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

        public override StaticClassAutoPropertyAccessorWithCodeAnalysis SetAccessor
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
        
        INode<PropertyDeclarationSyntax> IHasNode<PropertyDeclarationSyntax>.Node
        {
            get { return property.Property.Property.Node; }
        }
    }
}
