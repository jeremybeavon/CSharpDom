using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructPropertyWithCodeAnalysis :
        EditableStructProperty<
            AttributeGroupWithCodeAnalysis,
            IStructType,
            ITypeReferenceWithCodeAnalysis,
            StructAccessorWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly PropertyWithBodyWithCodeAnalysis property;
        
        internal StructPropertyWithCodeAnalysis(StructTypeWithCodeAnalysis parent)
            : this()
        {
            property = new PropertyWithBodyWithCodeAnalysis(parent, this);
        }

        private StructPropertyWithCodeAnalysis()
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
        
        public override StructAccessorWithCodeAnalysis GetAccessor
        {
            get { return new StructAccessorWithCodeAnalysis(property.GetAccessor); }
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

        public override StructAccessorWithCodeAnalysis SetAccessor
        {
            get { return new StructAccessorWithCodeAnalysis(property.SetAccessor); }
            set { property.SetAccessor = value?.Accessor; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToStructMemberVisibilityModifier(); }
            set
            {
                PropertyDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStructMemberVisibilityModifier(value));
            }
        }

        public override StructMemberInheritanceModifier InheritanceModifier
        {
            get { return Syntax.Modifiers.ToStructMemberInheritanceModifier(); }
            set
            {
                PropertyDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStructMemberInheritanceModifier(value));
            }
        }

        public PropertyDeclarationSyntax Syntax
        {
            get { return property.Syntax; }
            set { property.Syntax = value; }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }
    }
}
