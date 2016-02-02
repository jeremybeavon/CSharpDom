using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection
{
    public sealed class InterfacePropertyWithReflection :
        AbstractInterfaceProperty<
            AttributeWithReflection,
            IBasicTypeWithReflection,
            ITypeReferenceWithReflection>
    {
        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IBasicTypeWithReflection DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool HasGet
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool HasSet
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override InterfaceMemberInheritanceModifier InheritanceModifier
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
    }
}
