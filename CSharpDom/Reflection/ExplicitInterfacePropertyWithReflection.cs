using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.BaseClasses;

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
        private ITypeWithReflection declaringType;
        private PropertyInfo property;

        internal ExplicitInterfacePropertyWithReflection(ITypeWithReflection declaringType, PropertyInfo property)
        {
            this.declaringType = declaringType;
            this.property = property;
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ITypeWithReflection DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override InterfaceReferenceWithReflection ExplicitInterface
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override AccessorWithReflection GetAccessor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ITypeReferenceWithReflection PropertyType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override AccessorWithReflection SetAccessor
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
