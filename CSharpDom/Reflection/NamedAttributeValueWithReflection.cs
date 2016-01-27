using System;
using System.Reflection;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection
{
    public sealed class NamedAttributeValueWithReflection : AbstractNamedAttributeValue
    {
        private readonly CustomAttributeNamedArgument attributeValue;

        internal NamedAttributeValueWithReflection(CustomAttributeNamedArgument attributeValue)
        {
            this.attributeValue = attributeValue;
        }

        public override string Name
        {
            get { return attributeValue.MemberName; }
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
