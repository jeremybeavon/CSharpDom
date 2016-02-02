using System;
using System.Collections.Generic;
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
