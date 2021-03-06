﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassAbstractPropertyWithCodeAnalysis :
        EditableAbstractProperty<
            AttributeGroupWithCodeAnalysis,
            IAbstractPartialTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            AbstractAccessorWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>
    {
        private readonly AbstractPropertyWithCodeAnalysis property;

        public AbstractPartialClassAbstractPropertyWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis type,
            string name,
            AccessorTypes accessors)
            : this(new AbstractPropertyWithCodeAnalysis(visibility, type, name, accessors))
        {
        }

        internal AbstractPartialClassAbstractPropertyWithCodeAnalysis(AbstractPropertyWithCodeAnalysis property)
        {
            this.property = property;
            property.DeclaringTypeFunc = () => DeclaringType.Class;
        }
        
        public AbstractPropertyWithCodeAnalysis Property
        {
            get { return property; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return property.Attributes; }
            set { property.Attributes = value; }
        }

        public override IAbstractPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return property.Property.Node.GetParent<IAbstractPartialTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override AbstractAccessorWithCodeAnalysis GetAccessor
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

        public override AbstractAccessorWithCodeAnalysis SetAccessor
        {
            get { return property.SetAccessor; }
            set { property.SetAccessor = value; }
        }

        public PropertyDeclarationSyntax Syntax
        {
            get { return property.Syntax; }
            set { property.Syntax = value; }
        }

        public override AbstractMemberVisibilityModifier Visibility
        {
            get { return property.Visibility; }
            set { property.Visibility = value; }
        }
    }
}
