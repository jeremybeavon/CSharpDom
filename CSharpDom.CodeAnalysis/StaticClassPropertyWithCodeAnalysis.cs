using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassPropertyWithCodeAnalysis :
        EditableStaticClassProperty<
            AttributeGroupWithCodeAnalysis,
            IStaticType,
            ITypeReferenceWithCodeAnalysis,
            StaticClassAccessorWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly PropertyWithBodyWithCodeAnalysis property;
        
        internal StaticClassPropertyWithCodeAnalysis(StaticTypeWithCodeAnalysis parent)
            : this()
        {
            property = new PropertyWithBodyWithCodeAnalysis(parent, this);
        }

        private StaticClassPropertyWithCodeAnalysis()
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

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }
    }
}
