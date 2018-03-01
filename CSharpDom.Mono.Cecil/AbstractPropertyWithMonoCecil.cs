using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class AbstractPropertyWithMonoCecil :
        AbstractAbstractProperty<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            AbstractAccessorWithMonoCecil>
    {
        private readonly PropertyWithMonoCecil property;
        private readonly AbstractAccessorWithMonoCecil getAccessor;
        private readonly AbstractAccessorWithMonoCecil setAccessor;

        internal AbstractPropertyWithMonoCecil(ITypeWithMonoCecil declaringType, PropertyDefinition property)
        {
            this.property = new PropertyWithMonoCecil(declaringType, property);
            if (this.property.GetAccessor != null)
            {
                getAccessor = new AbstractAccessorWithMonoCecil(this, this.property.GetAccessor);
            }

            if (this.property.SetAccessor != null)
            {
                setAccessor = new AbstractAccessorWithMonoCecil(this, this.property.SetAccessor);
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

        public override AbstractAccessorWithMonoCecil GetAccessor
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

        public override AbstractAccessorWithMonoCecil SetAccessor
        {
            get { return setAccessor; }
        }

        public override AbstractMemberVisibilityModifier Visibility
        {
            get { return property.PropertyDefinition.AbstractClassVisibility(); }
        }
    }
}
