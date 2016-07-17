using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly string name;
        private readonly InterfaceReferenceWithMonoCecil explicitInterface;

        internal ExplicitInterfacePropertyWithMonoCecil(ITypeWithMonoCecil declaringType, PropertyDefinition property)
        {
            this.property = new PropertyWithMonoCecil(declaringType, property);
            name = property.Name.Split('.').Last();
            TypeReference interfaceType = property.Method().FindExplicitInterface();
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
            get { return name; }
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
