using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class PropertyWithBodyWithCodeAnalysis :
        EditableProperty<
            AttributeGroupWithCodeAnalysis,
            IBasicType,
            ITypeReferenceWithCodeAnalysis,
            AccessorWithBodyWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>
    {
        private readonly PropertyWithCodeAnalysis property;

        internal PropertyWithBodyWithCodeAnalysis(
            ClassTypeWithCodeAnalysis parent,
            ClassPropertyWithCodeAnalysis property,
            ClassType classType)
        {
            this.property = new PropertyWithCodeAnalysis(parent, property, classType);
        }

        internal PropertyWithBodyWithCodeAnalysis(
            ClassTypeWithCodeAnalysis parent,
            ExplicitInterfacePropertyWithCodeAnalysis property)
        {
            this.property = new PropertyWithCodeAnalysis(parent, property);
        }

        internal PropertyWithBodyWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, SealedClassPropertyWithCodeAnalysis property)
        {
            this.property = new PropertyWithCodeAnalysis(parent, property);
        }

        public PropertyWithCodeAnalysis Property
        {
            get { return property; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return property.Attributes; }
            set { property.Attributes = value; }
        }

        public override IBasicType DeclaringType
        {
            get { return property.DeclaringType; }
            set { throw new NotSupportedException(); }
        }

        public override AccessorWithBodyWithCodeAnalysis GetAccessor
        {
            get { return new AccessorWithBodyWithCodeAnalysis(property.GetAccessor); }
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

        public override AccessorWithBodyWithCodeAnalysis SetAccessor
        {
            get { return new AccessorWithBodyWithCodeAnalysis(property.SetAccessor); }
            set { property.SetAccessor = value?.Accessor; }
        }

        public PropertyDeclarationSyntax Syntax
        {
            get { return property.Syntax; }
            set { property.Syntax = value; }
        }
        
        internal Node<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> Node
        {
            get { return property.Node; }
        }
    }
}
