﻿using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassPropertyWithCodeAnalysis :
        EditableClassProperty<
            AttributeGroupWithCodeAnalysis,
            IAbstractPartialTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            ClassAccessorWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>
    {
        private readonly AbstractClassPropertyWithCodeAnalysis property;

        internal AbstractPartialClassPropertyWithCodeAnalysis(AbstractClassPropertyWithCodeAnalysis property)
        {
            this.property = property;
        }
        
        public PropertyWithBodyWithCodeAnalysis Property
        {
            get { return property.Property; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return property.Attributes; }
            set { property.Attributes = value; }
        }

        public override IAbstractPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return property.Property.Property.Node.GetParentNode<IAbstractPartialTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ClassAccessorWithCodeAnalysis GetAccessor
        {
            get { return property.GetAccessor; }
            set { property.GetAccessor = value; }
        }

        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return property.InheritanceModifier; }
            set { property.InheritanceModifier = value; }
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

        public override ClassAccessorWithCodeAnalysis SetAccessor
        {
            get { return property.SetAccessor; }
            set { property.SetAccessor = value; }
        }

        public PropertyDeclarationSyntax Syntax
        {
            get { return property.Syntax; }
            set { property.Syntax = value; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return property.Visibility; }
            set { property.Visibility = value; }
        }
        
        internal AbstractClassPropertyWithCodeAnalysis InternalProperty
        {
            get { return property; }
        }
    }
}
