using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class InterfacePropertyWithReflection :
        AbstractInterfaceProperty<
            AttributeWithReflection,
            IBasicTypeWithReflection,
            ITypeReferenceWithReflection,
            InterfaceAccessorWithReflection>
    {
        private readonly PropertyInfo property;
        private readonly IBasicTypeWithReflection declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithReflection propertyType;
        private readonly InterfaceAccessorWithReflection getAccessor;
        private readonly InterfaceAccessorWithReflection setAccessor;

        internal InterfacePropertyWithReflection(IBasicTypeWithReflection declaringType, PropertyInfo property)
        {
            this.property = property;
            this.declaringType = declaringType;
            attributes = new Lazy<Attributes>(() => new Attributes(property));
            propertyType = TypeReferenceWithReflectionFactory.CreateReference(property.PropertyType, property);
            if (property.GetMethod != null)
            {
                getAccessor = new InterfaceAccessorWithReflection(property.GetMethod);
            }

            if (property.SetMethod != null)
            {
                setAccessor = new InterfaceAccessorWithReflection(property.SetMethod);
            }
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override IBasicTypeWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public override InterfaceAccessorWithReflection GetAccessor
        {
            get { return getAccessor; }
        }

        public override InterfaceMemberInheritanceModifier InheritanceModifier
        {
            get
            {
                if ((property.GetMethod ?? property.SetMethod).IsHideBySig)
                {
                    return InterfaceMemberInheritanceModifier.New;
                }

                return InterfaceMemberInheritanceModifier.None;
            }
        }

        public override string Name
        {
            get { return property.Name; }
        }

        public override ITypeReferenceWithReflection PropertyType
        {
            get { return propertyType; }
        }

        public override InterfaceAccessorWithReflection SetAccessor
        {
            get { return setAccessor; }
        }
    }
}
