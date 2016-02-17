using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class ExplicitInterfacePropertyWithReflection :
        AbstractExplicitInterfaceProperty<
            AttributeWithReflection,
            ITypeWithReflection,
            InterfaceReferenceWithReflection,
            ITypeReferenceWithReflection,
            AccessorWithReflection>
    {
        private readonly PropertyWithReflection property;
        private readonly InterfaceReferenceWithReflection explicitInterface;

        internal ExplicitInterfacePropertyWithReflection(ITypeWithReflection declaringType, Type interfaceType, PropertyInfo property)
        {
            this.property = new PropertyWithReflection(declaringType, property);
            explicitInterface = new InterfaceReferenceWithReflection(interfaceType);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return property.Attributes; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return property.DeclaringType; }
        }

        public override InterfaceReferenceWithReflection ExplicitInterface
        {
            get { return explicitInterface; }
        }

        public override AccessorWithReflection GetAccessor
        {
            get { return property.GetAccessor; }
        }

        public override string Name
        {
            get { return property.Name; }
        }

        public override ITypeReferenceWithReflection PropertyType
        {
            get { return property.PropertyType; }
        }

        public override AccessorWithReflection SetAccessor
        {
            get { return property.SetAccessor; }
        }
    }
}
