using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class ConversionOperatorWithReflection :
        AbstractConversionOperator<AttributeWithReflection, ITypeWithReflection, ParameterWithReflection>
    {
        internal ConversionOperatorWithReflection(ITypeWithReflection declaringType, MethodInfo method)
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

        public override IReadOnlyList<ParameterWithReflection> Parameters
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<AttributeWithReflection> ReturnAttributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
