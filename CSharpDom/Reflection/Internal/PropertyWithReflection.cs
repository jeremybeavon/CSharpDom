using CSharpDom.BaseClasses;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class PropertyWithReflection :
        AbstractProperty<AttributeWithReflection, ITypeWithReflection, ITypeReferenceWithReflection, AccessorWithReflection>,
        IHasPropertyInfo//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeWithReflection declaringType;
        private readonly PropertyInfo property;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithReflection propertyType;
        private readonly AccessorWithReflection getAccessor;
        private readonly AccessorWithReflection setAccessor;

        internal PropertyWithReflection(ITypeWithReflection declaringType, PropertyInfo property)
        {
            this.declaringType = declaringType;
            this.property = property;
            attributes = new Lazy<Attributes>(() => new Attributes(property));
            propertyType = TypeReferenceWithReflectionFactory.CreateReference(property.PropertyType, property);
            if (property.GetMethod != null)
            {
                getAccessor = new AccessorWithReflection(property.GetMethod);
            }

            if (property.SetMethod != null)
            {
                setAccessor = new AccessorWithReflection(property.SetMethod);
            }
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public override AccessorWithReflection GetAccessor
        {
            get { return getAccessor; }
        }
        
        public override string Name
        {
            get { return property.Name(); }
        }

        public override ITypeReferenceWithReflection PropertyType
        {
            get { return propertyType; }
        }

        public override AccessorWithReflection SetAccessor
        {
            get { return setAccessor; }
        }

        public PropertyInfo PropertyInfo
        {
            get { return property; }
        }
    }
}
