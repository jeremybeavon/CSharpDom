using CSharpDom.BaseClasses;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class PropertyWithMonoCecil :
        AbstractProperty<AttributeWithMonoCecil, ITypeWithMonoCecil, ITypeReferenceWithMonoCecil, AccessorWithMonoCecil>,
        IHasPropertyInfo//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly PropertyInfo property;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithMonoCecil propertyType;
        private readonly AccessorWithMonoCecil getAccessor;
        private readonly AccessorWithMonoCecil setAccessor;

        internal PropertyWithMonoCecil(ITypeWithMonoCecil declaringType, PropertyInfo property)
        {
            this.declaringType = declaringType;
            this.property = property;
            attributes = new Lazy<Attributes>(() => new Attributes(property));
            propertyType = TypeReferenceWithMonoCecilFactory.CreateReference(property.PropertyType);
            if (property.GetMethod != null)
            {
                getAccessor = new AccessorWithMonoCecil(property.GetMethod);
            }

            if (property.SetMethod != null)
            {
                setAccessor = new AccessorWithMonoCecil(property.SetMethod);
            }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }

        public override AccessorWithMonoCecil GetAccessor
        {
            get { return getAccessor; }
        }
        
        public override string Name
        {
            get { return property.Name(); }
        }

        public override ITypeReferenceWithMonoCecil PropertyType
        {
            get { return propertyType; }
        }

        public override AccessorWithMonoCecil SetAccessor
        {
            get { return setAccessor; }
        }

        public PropertyInfo PropertyInfo
        {
            get { return property; }
        }
    }
}
