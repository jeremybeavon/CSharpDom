﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class SealedPartialClassPropertyWithCodeAnalysis :
        EditableSealedClassProperty<
            AttributeGroupWithCodeAnalysis,
            ISealedPartialTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            ClassAccessorWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>
    {
        private readonly SealedClassPropertyWithCodeAnalysis property;

        public SealedPartialClassPropertyWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis type,
            string name,
            MethodBodyWithCodeAnalysis getAccessor,
            MethodBodyWithCodeAnalysis setAccessor)
            : this(new SealedClassPropertyWithCodeAnalysis(visibility, type, name, getAccessor, setAccessor))
        {
        }

        internal SealedPartialClassPropertyWithCodeAnalysis(SealedClassPropertyWithCodeAnalysis property)
        {
            this.property = property;
            property.DeclaringTypeFunc = () => DeclaringType.Class;
        }
           
        public SealedClassPropertyWithCodeAnalysis Property
        {
            get { return property; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return property.Attributes; }
            set { property.Attributes = value; }
        }

        public override ISealedPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return property.Property.Property.Property.Node.GetParent<ISealedPartialTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ClassAccessorWithCodeAnalysis GetAccessor
        {
            get { return property.GetAccessor; }
            set { property.GetAccessor = value; }
        }

        public override SealedClassMemberInheritanceModifier InheritanceModifier
        {
            get { return Syntax.Modifiers.ToSealedClassMemberInheritanceModifier(); }
            set
            {
                PropertyDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithSealedClassMemberInheritanceModifier(value));
            }
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
    }
}
