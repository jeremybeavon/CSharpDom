using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Reflection;

namespace CSharpDom.Reflection.Internal.Hiding
{
    internal sealed class PropertySignature :
        AbstractProperty<AttributeGroupNotSupported, IBasicType, ITypeReferenceWithReflection, AccessorSignature>
    {
        private readonly ITypeReferenceWithReflection propertyType;
        private readonly string name;
        private readonly AccessorSignature getAccessor;
        private readonly AccessorSignature setAccessor;

        public PropertySignature(PropertyInfo property)
        {
            propertyType = TypeReferenceWithReflectionFactory.CreateReference(property.PropertyType);
            name = property.Name;
            if (property.GetMethod != null)
            {
                getAccessor = AccessorSignature.Default;
            }

            if (property.SetMethod != null)
            {
                setAccessor = AccessorSignature.Default;
            }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IBasicType DeclaringType
        {
            get { return null; }
        }

        public override AccessorSignature GetAccessor
        {
            get { return getAccessor; }
        }

        public override string Name
        {
            get { return name; }
        }

        public override ITypeReferenceWithReflection PropertyType
        {
            get { return propertyType; }
        }

        public override AccessorSignature SetAccessor
        {
            get { return setAccessor; }
        }
    }
}
