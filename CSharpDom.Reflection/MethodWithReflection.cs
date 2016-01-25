using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class MethodWithReflection :
        AbstractMethod<AttributeWithReflection, IBasicTypeWithReflection, GenericParameterWithReflection, ParameterWithReflection>
    {
        internal MethodWithReflection(IBasicTypeWithReflection declaringType, MethodInfo method)
        {

        }

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

        public override IReadOnlyList<GenericParameterWithReflection> GenericParameters
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

        public override IReadOnlyList<ParameterWithReflection> Parameters
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
