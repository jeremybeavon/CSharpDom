using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ExplicitInterfacePropertyWithMonoCecil :
        AbstractExplicitInterfaceProperty<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            InterfaceReferenceWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            AccessorWithMonoCecil>
    {
        private readonly PropertyWithMonoCecil property;
        private readonly InterfaceReferenceWithMonoCecil explicitInterface;

        internal ExplicitInterfacePropertyWithMonoCecil(ITypeWithMonoCecil declaringType, TypeDefinition interfaceType, PropertyDefinition property)
        {
            this.property = new PropertyWithMonoCecil(declaringType, property);
            explicitInterface = new InterfaceReferenceWithMonoCecil(declaringType.Assembly, interfaceType);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return property.Attributes; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return property.DeclaringType; }
        }

        public override InterfaceReferenceWithMonoCecil ExplicitInterface
        {
            get { return explicitInterface; }
        }

        public override AccessorWithMonoCecil GetAccessor
        {
            get { return property.GetAccessor; }
        }

        public override string Name
        {
            get { return property.Name; }
        }

        public override ITypeReferenceWithMonoCecil PropertyType
        {
            get { return property.PropertyType; }
        }

        public override AccessorWithMonoCecil SetAccessor
        {
            get { return property.SetAccessor; }
        }
    }
}
