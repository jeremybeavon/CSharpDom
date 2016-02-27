using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class InterfacePropertyWithMonoCecil :
        AbstractInterfaceProperty<
            AttributeWithMonoCecil,
            IBasicTypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            InterfaceAccessorWithMonoCecil>
    {
        private readonly PropertyInfo property;
        private readonly IBasicTypeWithMonoCecil declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithMonoCecil propertyType;
        private readonly InterfaceAccessorWithMonoCecil getAccessor;
        private readonly InterfaceAccessorWithMonoCecil setAccessor;

        internal InterfacePropertyWithMonoCecil(IBasicTypeWithMonoCecil declaringType, PropertyInfo property)
        {
            this.property = property;
            this.declaringType = declaringType;
            attributes = new Lazy<Attributes>(() => new Attributes(property));
            propertyType = TypeReferenceWithMonoCecilFactory.CreateReference(property.PropertyType);
            if (property.GetMethod != null)
            {
                getAccessor = new InterfaceAccessorWithMonoCecil(property.GetMethod);
            }

            if (property.SetMethod != null)
            {
                setAccessor = new InterfaceAccessorWithMonoCecil(property.SetMethod);
            }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override IBasicTypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }

        public override InterfaceAccessorWithMonoCecil GetAccessor
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

        public override ITypeReferenceWithMonoCecil PropertyType
        {
            get { return propertyType; }
        }

        public override InterfaceAccessorWithMonoCecil SetAccessor
        {
            get { return setAccessor; }
        }
    }
}
