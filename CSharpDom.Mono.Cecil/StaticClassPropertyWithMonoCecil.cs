using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StaticClassPropertyWithMonoCecil :
        AbstractStaticClassProperty<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            StaticClassAccessorWithMonoCecil>
    {
        private readonly PropertyWithMonoCecil property;
        private readonly StaticClassAccessorWithMonoCecil getAccessor;
        private readonly StaticClassAccessorWithMonoCecil setAccessor;

        internal StaticClassPropertyWithMonoCecil(ITypeWithMonoCecil declaringType, PropertyDefinition property)
        {
            this.property = new PropertyWithMonoCecil(declaringType, property);
            if (this.property.GetAccessor != null)
            {
                getAccessor = new StaticClassAccessorWithMonoCecil(this, this.property.GetAccessor);
            }

            if (this.property.SetAccessor != null)
            {
                setAccessor = new StaticClassAccessorWithMonoCecil(this, this.property.SetAccessor);
            }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return property.Attributes; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return property.DeclaringType; }
        }

        public override StaticClassAccessorWithMonoCecil GetAccessor
        {
            get { return getAccessor; }
        }

        public override string Name
        {
            get { return property.Name; }
        }

        public override ITypeReferenceWithMonoCecil PropertyType
        {
            get { return property.PropertyType; }
        }

        public override StaticClassAccessorWithMonoCecil SetAccessor
        {
            get { return setAccessor; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return property.PropertyDefinition.StaticClassVisibility(); }
        }
    }
}
