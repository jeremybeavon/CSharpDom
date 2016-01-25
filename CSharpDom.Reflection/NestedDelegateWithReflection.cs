using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection
{
    public sealed class NestedDelegateWithReflection : AbstractNestedDelegate<AttributeWithReflection, ITypeWithReflection>
    {
        internal NestedDelegateWithReflection(ITypeWithReflection declaringType, Type type)
        {

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

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
