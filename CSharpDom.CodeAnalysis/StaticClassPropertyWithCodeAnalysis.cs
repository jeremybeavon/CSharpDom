using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassPropertyWithCodeAnalysis :
        AbstractStaticClassProperty<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            StaticClassAccessorWithCodeAnalysis>
    {
        private readonly PropertyWithCodeAnalysis property;
        private readonly StaticClassAccessorWithCodeAnalysis getAccessor;
        private readonly StaticClassAccessorWithCodeAnalysis setAccessor;

        internal StaticClassPropertyWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, PropertyDefinition property)
        {
            this.property = new PropertyWithCodeAnalysis(declaringType, property);
            if (this.property.GetAccessor != null)
            {
                getAccessor = new StaticClassAccessorWithCodeAnalysis(this, this.property.GetAccessor);
            }

            if (this.property.SetAccessor != null)
            {
                setAccessor = new StaticClassAccessorWithCodeAnalysis(this, this.property.SetAccessor);
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

        public override StaticClassAccessorWithCodeAnalysis GetAccessor
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

        public override StaticClassAccessorWithCodeAnalysis SetAccessor
        {
            get { return setAccessor; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return property.PropertyDefinition.StaticClassVisibility(); }
        }
    }
}
