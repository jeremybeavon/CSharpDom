using System;
using System.Reflection;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection
{
    public sealed class UnnamedAttributeValueWithReflection : AbstractUnnamedAttributeValue
    {
        private readonly CustomAttributeTypedArgument attributeValue;

        internal UnnamedAttributeValueWithReflection(CustomAttributeTypedArgument attributeValue)
        {
            this.attributeValue = attributeValue;
        }

        public override string RawValue
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
