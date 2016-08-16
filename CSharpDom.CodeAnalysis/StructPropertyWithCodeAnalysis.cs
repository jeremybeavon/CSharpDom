using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructPropertyWithCodeAnalysis :
        AbstractStructProperty<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            StructAccessorWithCodeAnalysis>
    {
        private readonly PropertyWithCodeAnalysis property;
        private readonly StructAccessorWithCodeAnalysis getAccessor;
        private readonly StructAccessorWithCodeAnalysis setAccessor;

        internal StructPropertyWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, PropertyDefinition property)
        {
            this.property = new PropertyWithCodeAnalysis(declaringType, property);
            if (this.property.GetAccessor != null)
            {
                getAccessor = new StructAccessorWithCodeAnalysis(this, this.property.GetAccessor);
            }

            if (this.property.SetAccessor != null)
            {
                setAccessor = new StructAccessorWithCodeAnalysis(this, this.property.SetAccessor);
            }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return property.Attributes; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return property.DeclaringType; }
        }

        public override StructAccessorWithCodeAnalysis GetAccessor
        {
            get { return getAccessor; }
        }

        public override string Name
        {
            get { return property.Name; }
        }

        public override ITypeReferenceWithCodeAnalysis PropertyType
        {
            get { return property.PropertyType; }
        }

        public override StructAccessorWithCodeAnalysis SetAccessor
        {
            get { return setAccessor; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return property.PropertyDefinition.StructVisibility(); }
        }

        public override StructMemberInheritanceModifier InheritanceModifier
        {
            get { return property.PropertyDefinition.Method().IsStatic ? StructMemberInheritanceModifier.Static : StructMemberInheritanceModifier.None; }
        }
    }
}
