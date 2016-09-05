using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassPropertyWithCodeAnalysis :
        EditableClassProperty<
            AttributeGroupWithCodeAnalysis,
            IClassType,
            ITypeReferenceWithCodeAnalysis,
            ClassAccessorWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly PropertyWithBodyWithCodeAnalysis property;

        internal ClassPropertyWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ClassType classType)
            : this()
        {
            property = new PropertyWithBodyWithCodeAnalysis(parent, this, classType);
        }

        internal ClassPropertyWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, SealedClassPropertyWithCodeAnalysis property)
            : this()
        {
            this.property = new PropertyWithBodyWithCodeAnalysis(parent, property);
        }

        private ClassPropertyWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
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

        public override IClassType DeclaringType
        {
            get { return base.DeclaringType; }
            set { throw new NotSupportedException(); }
        }

        public override ClassAccessorWithCodeAnalysis GetAccessor
        {
            get { return new ClassAccessorWithCodeAnalysis(property.GetAccessor); }
            set { property.GetAccessor = value?.Accessor; }
        }

        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return property.Syntax.Modifiers.ToClassMemberInheritanceModifier(); }
            set
            {
                PropertyDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberInheritanceModifier(value));
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
            get { return new ClassAccessorWithCodeAnalysis(property.SetAccessor); }
            set { property.SetAccessor = value?.Accessor; }
        }

        public PropertyDeclarationSyntax Syntax
        {
            get { return property.Syntax; }
            set { property.Syntax = value; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToClassMemberVisibilityModifier(); }
            set
            {
                PropertyDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberVisibilityModifier(value));
            }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }
    }
}
