using CSharpDom.BaseClasses;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class PropertyWithMonoCecil :
        AbstractProperty<AttributeWithMonoCecil, ITypeWithMonoCecil, ITypeReferenceWithMonoCecil, AccessorWithMonoCecil>,
        IHasPropertyDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly PropertyDefinition property;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithMonoCecil propertyType;
        private readonly AccessorWithMonoCecil getAccessor;
        private readonly AccessorWithMonoCecil setAccessor;

        internal PropertyWithMonoCecil(ITypeWithMonoCecil declaringType, PropertyDefinition property)
        {
            this.declaringType = declaringType;
            this.property = property;
            attributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, property));
            propertyType = TypeReferenceWithMonoCecilFactory.CreateReference(declaringType.Assembly, property.PropertyType, property);
            if (property.GetMethod != null)
            {
                getAccessor = new AccessorWithMonoCecil(declaringType.Assembly, property.GetMethod);
            }

            if (property.SetMethod != null)
            {
                setAccessor = new AccessorWithMonoCecil(declaringType.Assembly, property.SetMethod);
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
            get { return property.Name; }
        }

        public override ITypeReferenceWithMonoCecil PropertyType
        {
            get { return propertyType; }
        }

        public override AccessorWithMonoCecil SetAccessor
        {
            get { return setAccessor; }
        }

        public PropertyDefinition PropertyDefinition
        {
            get { return property; }
        }
    }
}
