using System;
using CSharpDom.BaseClasses;
using CSharpDom.Common;

namespace CSharpDom.Reflection
{
    public sealed class GenericParameterWithReflection : AbstractGenericParameter<ITypeReference>
    {
        private readonly Type type;

        internal GenericParameterWithReflection(Type type)
        {
            this.type = type;
        }

        public override ITypeReference Type
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
