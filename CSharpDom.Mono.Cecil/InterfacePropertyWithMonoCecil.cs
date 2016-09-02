using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class InterfacePropertyWithMonoCecil :
        AbstractInterfaceProperty<
            AttributeWithMonoCecil,
            IInterfaceTypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            InterfaceAccessorWithMonoCecil>
    {
        private readonly PropertyDefinition property;
        private readonly IInterfaceTypeWithMonoCecil declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithMonoCecil propertyType;
        private readonly InterfaceAccessorWithMonoCecil getAccessor;
        private readonly InterfaceAccessorWithMonoCecil setAccessor;

        internal InterfacePropertyWithMonoCecil(IInterfaceTypeWithMonoCecil declaringType, PropertyDefinition property)
        {
            this.property = property;
            this.declaringType = declaringType;
            AssemblyWithMonoCecil assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, property));
            propertyType = TypeReferenceWithMonoCecilFactory.CreateReference(assembly, property.PropertyType, property);
            if (property.GetMethod != null)
            {
                getAccessor = new InterfaceAccessorWithMonoCecil(assembly, property.GetMethod);
            }

            if (property.SetMethod != null)
            {
                setAccessor = new InterfaceAccessorWithMonoCecil(assembly, property.SetMethod);
            }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override IInterfaceTypeWithMonoCecil DeclaringType
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
